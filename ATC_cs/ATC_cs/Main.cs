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
using System.Drawing.Printing;

namespace ATC_cs
{
    public partial class Main : Form
    {
        public static OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\АТС.accdb");
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
            SetPDs();
            SetTariffs();

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
        void SetPDs()
        {
            cb_abonent.Items.Clear();
            foreach (var p in pds)
                cb_abonent.Items.Add(p.name);
        }
        void SetTariffs()
        {
            cb_tariff.Items.Clear();
            foreach (var p in tariffs)
                cb_tariff.Items.Add(p.tariff);
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
            Tariff t;
            TariffA tA;
            Phone ph;
            for (int i = 0; i < pds.Count; i++)
            {
                a = new Abonent();
                
                //get payments
                p = payments.Find(x => x.idA == pds[i].id);
                if (p == null)
                    p = new Payment();
                
                //get phone
                ph = phones.Find(x => x.idA == pds[i].id);
                if (ph == null)
                    ph = new Phone();
                
                //get tariffs of abonent
                tA = tariffsA.Find(x2 => x2.phone == ph.phone);
                if (tA == null)
                    tA = new TariffA();

                //get tariffs
                t = tariffs.Find(x1 => x1.id == tA.idTariff);
                if(t == null)
                    t = new Tariff();

                a.pd_id = pds[i].id;
                a.pd_name = pds[i].name;
                a.p_phone = ph.phone;
                a.t_tariff = t.tariff;
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
            dt.Columns.Add("Задолжность");
            dt.Columns.Add("Дата");
            
            foreach (var a in abonents)
            {
                dt.Rows.Add(new object[] { a.pd_id, a.pd_name, a.p_phone, a.t_tariff, a.p_summa, a.p_zadol, a.p_date });
            }

            dgv_abonents.DataSource = dt;

            int w = (dgv_abonents.Width - 40) / dgv_abonents.ColumnCount;
            for (int i = 0; i < dgv_abonents.ColumnCount; i++)
            {
                dgv_abonents.Columns[i].Width = w;
            }

        }
        public static void Open()
        {
            if (c.State != ConnectionState.Open)
                c.Open();
        }

        private void dgv_abonents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_phone.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            cb_abonent.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            date.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[6].Value.ToString();
            cb_tariff.Text = dgv_abonents.SelectedCells[0].OwningRow.Cells[3].Value.ToString();
            nud_summa.Value = Convert.ToDecimal(dgv_abonents.SelectedCells[0].OwningRow.Cells[4].Value);
            nud_zadol.Value = Convert.ToDecimal(dgv_abonents.SelectedCells[0].OwningRow.Cells[5].Value);
        }

        private void btn_newPhone_Click(object sender, EventArgs e)
        {
            newPhone f = new newPhone();
            f.ShowDialog();
            if (ok)
            {
                Open();
                string query = "insert into `Телефон` (`Номер телефона`,`Код абонента`,`Задолжность`,`Дата`) values ('" +
                    f.tb_phone.Text + "', " +
                    f.cb_idA.SelectedItem + ", " +
                    f.nud_zadol.Value.ToString().Replace(',', '.') + ", '" +
                    f.date.Value + "')";
                Clipboard.SetText(query);//works in access but not works here

                MessageBox.Show(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                c.Close();
                UpdateDgv();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_newAbonent_Click(object sender, EventArgs e)
        {
            newAbonent f = new newAbonent();
            f.ShowDialog();
            if(ok)
            {
                cmd.CommandText = "insert into `Личные данные` (`ФИО абонента`, `Дата рождения`, `Домашний адрес`) values ('" +
                    f.tb_name.Text + "', '" +
                   f.date.Value + "', '" + 
                   f.tb_address.Text + "')";

                Open();
                cmd.ExecuteNonQuery();
                c.Close();
                UpdateDgv();
            }
        }

        private void btn_newTariff_Click(object sender, EventArgs e)
        {
            newTariff f = new newTariff();
            f.ShowDialog();
            if(ok)
            {
                cmd.CommandText = "insert into `Тариф` (`Тариф`, `Баланс`) values ('" +
                    f.tb_tariff.Text + "', " + f.nud_balance.Value.ToString().Replace(',', '.') + ")";
                Open();
                cmd.ExecuteNonQuery();
                c.Close();
                UpdateDgv();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программный продукт создан для получения практических навыков по своей специальности.");
        }
        bool PaymentExists()
        {
            PersonalData pd;
            bool res = true;
            //get personal data
            pd = pds.Find(x => x.name == cb_abonent.Text);

            cmd.CommandText = "select * from `Оплата` where `Код абонента` = " + pd.id;
            MessageBox.Show(cmd.CommandText);
            Open();
            if (cmd.ExecuteScalar() == null)
                res = false;
            c.Close();

            return res;
        }
        private void btn_done_Click(object sender, EventArgs e)
        {
            string sql;

            PersonalData pd = null;
            pd = pds.Find(x => x.name == cb_abonent.Text);       
            Open();

            if (true)
            {
                sql = "select * from `Оплата` where `Код абонента` = " + pd.id;
                if (ExistsSql(sql))
                    sql = "update `Оплата` set " +
                        "`Сумма` = " + nud_summa.Value.ToString().Replace(',', '.') +
                        ", `Задолжность` = " + nud_zadol.Value.ToString().Replace(',', '.') +
                        ", `Дата оплаты` = '" + date.Value + "'" +
                        ", `Номер телефона` = '" + cb_phone.Text +

                        "' where `Код абонента` = " + pd.id;
                else
                    sql = "insert into `Оплата` (`Код абонента`, `Сумма`, `Задолжность`, `Дата оплаты`, `Номер телефона`) values (" +
                       pd.id + ", " +
                        nud_summa.Value.ToString().Replace(',', '.') + ", " +
                        nud_zadol.Value.ToString().Replace(',', '.') + ", '" +
                        date.Value + "', '" +
                        cb_phone.Text + "')";

                cmd.CommandText = sql;
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();//`Оплата`
                
                sql = "select * from `Телефон` where `Номер телефона` = '" + cb_phone.Text + "'";
                if (ExistsSql(sql))
                {
                    cmd.CommandText = "update `Телефон` set " +
                        "`Код абонента` = " + pd.id +
                        ", `Задолжность` = " + nud_zadol.Value.ToString().Replace(',', '.') + 
                        ",`Дата` = '" + date.Value + "'" + 

                        " where `Номер телефона` = '" + cb_phone.Text + "'";
                }
                else
                    cmd.CommandText = "insert into `Телефон` (`Номер телефона`,`Код абонента`,`Задолжность`,`Дата`) values ('" +
                        cb_phone.Text + "', " +
                        pd.id + ", " +
                        nud_zadol.Value.ToString().Replace(',', '.') + ", '" +
                        date.Value + "')";

                MessageBox.Show(cmd.CommandText);
                Clipboard.SetText(cmd.CommandText);
                cmd.ExecuteNonQuery();//`Телефон`

                sql = "select * from `Тариф абонента` where `Номер телефона` = '" + cb_phone.Text + "'";
                if (ExistsSql(sql))
                {
                    cmd.CommandText = "update `Тариф абонента` set " +
                        "`Код тарифа` = " + tariffsA.Find(x => x.phone == cb_phone.Text).idTariff +
                        ", `Дата` = '" + date.Value + "'"
                        + "where `Номер телефона` = '" + cb_phone.Text + "'";
                }
                else
                    cmd.CommandText = "insert into `Тариф абонента` (`Номер телефона`, `Код тарифа`, `Дата`) values (" +
                         cb_phone.Text + ", " +
                         tariffs.Find(x => x.tariff == cb_tariff.Text).id + ", '" +
                         date.Value + "')";

                cmd.ExecuteNonQuery();//`Тариф абонента`
            }

            c.Close();
            UpdateDgv();
        }

        bool ExistsSql(string sql)
        {
            bool res = true;

            Open();
            cmd.CommandText = sql;
            if (cmd.ExecuteScalar() == null)
                res = false;

            return res;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int idA = Convert.ToInt32(dgv_abonents.SelectedCells[0].OwningRow.Cells[0].Value);
            Open();

            cmd.CommandText = "delete from `Оплата` where `Код абонента` = " + idA;
            cmd.ExecuteNonQuery();
            string s = null;
            try { s = phones.Find(x => x.idA == idA).phone; } catch (Exception ex) {}
            if ( s != null)
            {
                cmd.CommandText = "delete from `Тариф абонента` where `Номер телефона` = '" + phones.Find(x => x.idA == idA).phone + "'";
                cmd.ExecuteNonQuery();
            }
            cmd.CommandText = "delete from `Телефон` where `Код абонента` = " + idA;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from `Личные данные` where `Код абонента` = " + idA;
            cmd.ExecuteNonQuery();

            c.Close();
            UpdateDgv();
        }

        private void телефонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog_Phones f = new catalog_Phones();
            f.ShowDialog();
        }

        private void абонентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog_Abonents f = new catalog_Abonents();
            f.ShowDialog();
        }

        private void тарифыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog_Tariffs f = new catalog_Tariffs();
            f.ShowDialog();
        }

        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        // Declare a string to hold the entire document contents.
        private string documentContents;

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint;

        private void CreateDocument()
        {
            stringToPrint = "       Задолженности абонентов:\n\n\n";
            for (int i = 0; i < dgv_abonents.Rows.Count; i++)
            {
                stringToPrint += "----------------------------\n";
                stringToPrint += "ФИО абонента:                " + dgv_abonents.Rows[i].Cells[1].Value + "\n";
                stringToPrint += "Телефон:                           " + dgv_abonents.Rows[i].Cells[2].Value + "\n";
                stringToPrint += "Задолжность:                  " + dgv_abonents.Rows[i].Cells[5].Value + "\n";
                stringToPrint += "\n\n";
            }
            documentContents = stringToPrint;
        }

        void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }
        private void printPreviewButton_Click(object sender, EventArgs e)
        {
            CreateDocument();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage +=
                new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewButton_Click(sender, e);
        }

        private void nud_summa_ValueChanged(object sender, EventArgs e)
        {
            decimal res = Convert.ToDecimal(tariffs.Find(x => x.tariff == cb_tariff.Text).balance) - nud_summa.Value;
            if (res < 0) res = 0;
            nud_zadol.Value = res;
        }

        private void cb_tariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal res = Convert.ToDecimal(tariffs.Find(x => x.tariff == cb_tariff.Text).balance) - nud_summa.Value;
            if (res < 0) res = 0;
            nud_zadol.Value = res;
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
