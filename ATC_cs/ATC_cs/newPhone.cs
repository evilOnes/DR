using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC_cs
{
    public partial class newPhone : Form
    {
        public newPhone()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Main.ok = false;
            Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            Main.ok = true;
            Main.Open();
            string query = "insert into `Телефон` (`Номер телефона`,`Код абонента`,`Задолжность`,`Дата`) values ('" +
                tb_phone.Text + "', " +
                cb_idA.SelectedItem + ", (" +
                nud_zadol.Value.ToString().Replace(',', '.') + "), '" +
                date.Value.Day + "." + date.Value.Month + "." + date.Value.Year + "')";

            MessageBox.Show(query);
            Main.cmd.CommandText = query;
            Main.cmd.ExecuteScalar();

            Main.c.Close();
            Close();
        }

        private void newPhone_Load(object sender, EventArgs e)
        {
            foreach (var pd in Main.pds)
                cb_idA.Items.Add(pd.id);
        }
    }
}
