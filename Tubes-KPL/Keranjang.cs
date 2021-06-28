using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    public class Keranjang
    {
        private String kodeTransaksi;
        private String nPembeli;
        private String nKue;
        private int jumlah;
        private int harga;
        private int subTotal;
        private String status;

        public Keranjang(string kode, string pembeli, string kue, int jmlh, int harga, int sub, string status)
        {
            this.kodeTransaksi = kode;
            this.nPembeli = pembeli;
            this.nKue = kue;
            this.jumlah = jmlh;
            this.harga = harga;
            this.subTotal = sub;
            this.status = status;
        }
        public void setKodeTransaksi(string kode)
        {
            this.kodeTransaksi = kode;
        }

        public String getKodeTransaksi()
        {
            return kodeTransaksi;
        }

        public void setKodeKue(string pembeli)
        {
            this.nPembeli = pembeli;
        }

        public String getNPembeli()
        {
            return nPembeli;
        }
        public void setNKue(string kue)
        {
            this.nKue = kue;
        }

        public String getNKue()
        {
            return nKue;
        }
        public void setJumlah(int jmlh)
        {
            this.jumlah = jmlh;
        }

        public int getJumlah()
        {
            return jumlah;
        }
        public void setHarga(int harga)
        {
            this.harga = harga;
        }

        public int getHarga()
        {
            return harga;
        }
        public void setSubtotal(int harga)
        {
            this.harga = harga;
        }

        public int getSubtotal()
        {
            return subTotal;
        }
        public String getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }
    }
}
