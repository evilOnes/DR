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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == "user" && tb_pwd.Text == "user")
            {
                Hide();
                Main f = new Main();
                f.Show();
            }
            else
                MessageBox.Show("Учетные данные введены неверно", "Авторизация");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            tb_login.Text = "user";
            tb_pwd.Text = "user";
        }
    }
}
