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
    public partial class catalog_Tariffs : Form
    {
        public catalog_Tariffs()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void catalog_Tariffs_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Код тарифа");
            dt.Columns.Add("Тариф");
            dt.Columns.Add("Баланс");

            foreach (var a in Main.tariffs)
            {
                dt.Rows.Add(new object[] { a.id, a.tariff, a.balance });
            }

            dgv_abonents.DataSource = dt;

            int w = (dgv_abonents.Width - 40) / dgv_abonents.ColumnCount;
            for (int i = 0; i <  dgv_abonents.ColumnCount; i++)
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
                    if (dgv_abonents.Rows[i].Cells[1].Value.ToString().Contains(tb_search.Text))
                        dgv_abonents.Rows[i].Selected = true;
                }
            }
        }
    }
}
