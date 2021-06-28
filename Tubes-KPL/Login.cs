using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class Login : Form
    {
        string user, pwd;
        Config config = new uiConfig().getConfig();
        int attempt = 0;
        public Login()
        {
            InitializeComponent();
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            Enum usr = TableDriven.uname.cypher;
            user = usr.ToString();
            pwd = TableDriven.getUser(TableDriven.uname.cypher);

            Debug.Assert(txtUsername.Text.Length >= config.user.Length, "Username minimal memiliki 3 karakter.");

            if ((txtUsername.Text == user) && (txtPassword.Text == pwd))
            {
                MessageBox.Show("Login berhasil !", "");
                this.Hide();
                new Dashboard().Show();
            }
            else
            {
                attempt = attempt + 1;
                int max = 5;
                txtPassword.Clear();
                txtUsername.Clear();
                if (attempt == max)
                {
                    MessageBox.Show("Akun anda terblokir, kembali lagi setelah 5 menit", "warning");
                    btLogin.Hide();
                }
            }
        }
    }
}
