using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ATC_cs
{
    public partial class Main : Form
    {
        public static OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\АТС.accdb");
        public static OleDbCommand cmd = c.CreateCommand();
        public static OleDbDataReader reader;

        public static List<Abonent> abonents = new List<Abonent>();
        public static List<PersonalData> pds = new List<PersonalData>();
        public static List<Payment> payments = new List<Payment>();
        public static List<Tariff> tariffs = new List<Tariff>();
        public static List<TariffA> tariffsA = new List<TariffA>();
        public static List<Phone> phones = new List<Phone>();

        public static bool ok;
        public Main()
        {
            InitializeComponent();
        }

        void UpdateDgv()
        {
            GetPDs();
            GetPayments();
            GetTariffs();
            GetTariffsA();
            GetPhones();

            GetAbonents();

            SetPhones();

            SetAbonents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }
        void SetPhones()
        {
            cb_phone.Items.Clear();
            foreach(var p in phones)
                cb_phone.Items.Add(p.phone);
        }
        void GetPDs()
        {
            Open();

            cmd.CommandText = "select * from `Личные данные`";
            reader = cmd.ExecuteReader();

            pds.Clear();
            PersonalData pd;
            while (reader.Read())
            {
                pd = new PersonalData();
                pd.id = (int)reader[0];
                pd.name = reader[1].ToString();
                pd.date = reader[2].ToString();
                pd.phoneHome = reader[3].ToString();

                pds.Add(pd);
            }
            reader.Close();

            c.Close();
        }
        void GetPayments()
        {
            Open();

            cmd.CommandText = "select * from `Оплата`";
            reader = cmd.ExecuteReader();

            payments.Clear();
            Payment pd;
            while (reader.Read())
            {
                pd = new Payment();
                pd.id = (int)reader[0];
                pd.idA = (int)reader[1];
                pd.summa = (double)reader[2];
                pd.zadol = (double)reader[3];
                pd.date = reader[4].ToString();
                pd.phone = reader[5].ToString();

                payments.Add(pd);
            }
            reader.Close();

            c.Close();
        }
        void GetTariffs()
        {
            Open();

            cmd.CommandText = "select * from `Тариф`";
            reader = cmd.ExecuteReader();

            tariffs.Clear();
            Tariff pd;
            while (reader.Read())
            {
                pd = new Tariff();
                pd.id = (int)reader[0];
                pd.tariff = reader[1].ToString();
                pd.balance = (double)reader[2];
                
                tariffs.Add(pd);
            }
            reader.Close();

            c.Close();
        }
        void GetTariffsA()
        {
            Open();

            cmd.CommandText = "select * from `Тариф абонента`";
            reader = cmd.ExecuteReader();

            tariffsA.Clear();
            TariffA pd;
            while (reader.Read())
            {
                pd = new TariffA();
                pd.id = (int)reader[0];
                pd.phone = reader[1].ToString();
                pd.idTariff = (int)reader[2];
                pd.date = reader[3].ToString();

                tariffsA.Add(pd);
            }
            reader.Close();

            c.Close();
        }
        void GetPhones()
        {
            Open();

            cmd.CommandText = "select * from `Телефон`";
            reader = cmd.ExecuteReader();

            phones.Clear();
            Phone pd;
            while (reader.Read())
            {
                pd = new Phone();
                pd.phone = reader[0].ToString();
                pd.idA = (int)reader[1];
                pd.zadol = Convert.ToDouble(reader[2]);
                pd.date = reader[3].ToString();

                phones.Add(pd);
            }
            reader.Close();

            c.Close();
        }
        void GetAbonents()//get other first
        {
            abonents.Clear();
            Abonent a;
            Payment p;
            for (int i = 0; i < pds.Count; i++)
            {
                a = new Abonent();
                p = payments.Find(x => x.idA == pds[i].id);

                a.pd_id = pds[i].id;
                a.pd_name = pds[i].name;
                a.p_phone = p.phone;
                a.t_tariff = tariffs.Find(x1 => x1.id == tariffsA.Find(x2 => x2.phone == p.phone).idTariff).tariff;
                a.p_summa = p.summa;
                a.p_zadol = p.zadol;
                a.p_date = p.date;

                abonents.Add(a);
            }
        }
        void SetAbonents()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Код абонента");
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Телефон");
            dt.Columns.Add("Тариф");
            dt.Columns.Add("Сумма");
            dt.Columns.Add("Задолженность");
            dt.Columns.Add("Дата");
            
            foreach (var a in abonents)
            {
                dt.Rows.Add(new object[] { a.pd_id, a.pd_name, a.p_phone, a.t_tariff, a.p_summa, a.p_zadol, a.p_date });
            }

            dgv_abonents.DataSource = dt;

        }
        public static void Open()
        {
            if (c.State != ConnectionState.Open)
                c.Open();
        }

        private void dgv_abonents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_phone.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            tb_abonent.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            tb_date.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[6].Value.ToString();
            tb_tariff.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[3].Value.ToString();
        }

        private void btn_newPhone_Click(object sender, EventArgs e)
        {
            newPhone f = new newPhone();
            f.ShowDialog();
            if (ok)
                UpdateDgv();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    //класс, объединяющий все другие
    public class Abonent
    {
        public int pd_id;
        public string pd_name;

        public string p_phone;

        public string t_tariff;

        public double p_summa;
        public double p_zadol;
        public string p_date;

    };
    public class PersonalData
    {
        public int id;
        public string name;
        public string date;
        public string phoneHome;
    }
    public class Payment
    {
        public int id;
        public int idA;
        public double summa;
        public double zadol;
        public string date;
        public string phone;
    }
    public class Tariff
    {
        public int id;
        public string tariff;
        public double balance;
    }
    public class TariffA
    {
        public int id;
        public string phone;
        public int idTariff;
        public string date;
    }
    public class Phone
    {
        public string phone;
        public int idA;//abonenta
        public double zadol;
        public string date;
    }
}
