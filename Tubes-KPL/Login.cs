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

        int attempt = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            Enum usr = tableDriven.uname.cypher;
            user = usr.ToString();
            pwd = tableDriven.getUser(tableDriven.uname.cypher);

            Debug.Assert(txtUsername.Text.Length > 2, "Username minimal memiliki 3 karakter.");

            if ((txtUsername.Text == user) && (txtPassword.Text == pwd))
            {
                MessageBox.Show("Login berhasil !", "");
                //this.Hide();
            }
            else
            {
                attempt = attempt + 1;
                int max = 5;
                MessageBox.Show("Username atau password yang anda masukkan salah", "");
                txtPassword.Clear();
                txtUsername.Clear();
                if (attempt == max)
                {
                    MessageBox.Show("Akun anda terblokir, kembali lagi setelah 5 menit", "");
                    btLogin.Hide();
                }
            }
        }
    }
}
