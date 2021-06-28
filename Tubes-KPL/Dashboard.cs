using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonInputKue_Click(object sender, EventArgs e)
        {
            new InputKue().Show();
            this.Hide();
        }

        private void buttonPembeli_Click(object sender, EventArgs e)
        {
            new Pembeli().Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            new Transaksi().Show();
            this.Hide();
        }
    }
}
