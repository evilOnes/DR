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
            Close();
        }

        private void newPhone_Load(object sender, EventArgs e)
        {
            foreach (var pd in Main.pds)
                cb_idA.Items.Add(pd.id);
        }
    }
}
