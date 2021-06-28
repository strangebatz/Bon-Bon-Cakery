using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class Datapembeli
    {
        private String namaPembeli;
        private String kodePembeli;
        private String no_Hp;

        public Datapembeli(string kode, string nama,  string No_hp)
            {
            this.kodePembeli = kode;
            this.namaPembeli = nama;
            this.no_Hp = No_hp;
        }

        public void setKodePembeli(string kode)
        {
            this.kodePembeli = kode;
        }
        public String getKodePembeli()
        {
            return kodePembeli;
        }
        public void setNamaPembeli(string nama)
        {
            this.namaPembeli = nama;
        }

        public String getNamaPembeli()
        {
            return namaPembeli;
        }
        public void setno_Hp(string No_Hp)
        {
            this.no_Hp = No_Hp;
        }

        public String getno_Hp()
        {
            return no_Hp;
        }


        }
        
    
}

