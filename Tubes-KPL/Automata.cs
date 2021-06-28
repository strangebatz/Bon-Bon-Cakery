using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tubes_KPL
{
    class Automata
    {
        string[] State = { "Login", "Dashboard", "Input Kue", "Pembeli", "Transaksi", "Logout" };
        string posisi;

        public Automata() { }
        public void setPosisi(string pos)
        {
            this.posisi = pos;
        }

        public string getPosisi()
        {
            return this.posisi;
        }

        public void posisiController(string btn)
        {
            if (this.posisi == "Login")
            {
                if (btn == "Login")
                    new Dashboard().Show();

            }
            else if (this.posisi == "Dashboard")
            {
                if (btn == "Input Kue")
                    new InputKue().Show();
                else if (btn == "Pembeli")
                    new Pembeli().Show();
                else if (btn == "Transaksi")
                    new Transaksi().Show();
                else if (btn == "Logout")
                    new Login().Show();
            }
        }
    }
}
