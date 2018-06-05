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
    public partial class catalog_Phones : Form
    {
        public catalog_Phones()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void catalog_Phones_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Номер телефона");
            dt.Columns.Add("Код абонента");
            dt.Columns.Add("Задолжность");
            dt.Columns.Add("Дата");

            foreach (var a in Main.phones)
            {
                dt.Rows.Add(new object[] { a.phone, a.idA, a.zadol, a.date });
            }

            dgv_abonents.DataSource = dt;

            int w = (dgv_abonents.Width - 40) / dgv_abonents.ColumnCount;
            for (int i = 0; i < dgv_abonents.ColumnCount; i++)
            {
                dgv_abonents.Columns[i].Width = w;
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dgv_abonents.ClearSelection();
            if (tb_search.Text != "")
            {
                for (int i = 0; i < dgv_abonents.RowCount; i++)
                {
                    if (dgv_abonents.Rows[i].Cells[0].Value.ToString().Contains(tb_search.Text))
                        dgv_abonents.Rows[i].Selected = true;
                }
            }
        }
    }
}
