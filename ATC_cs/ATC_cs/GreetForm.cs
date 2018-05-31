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
    public partial class GreetForm : Form
    {
        public GreetForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            AuthForm f = new AuthForm();
            f.Show();
        }

        private void GreetForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1500;
            timer1.Start();
        }
    }
}
