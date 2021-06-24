using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InputKue
{
    public partial class InputKue : Form
    {

        DataTable tabKue;
        private string pathDirectory = Environment.CurrentDirectory;
        private string pathKue = @"\InputKue.json";
        public InputKue()
        {
            InitializeComponent();
            try
            {
                tabKue = ReadFromJson<DataTable>(pathDirectory + pathKue);
            }
            catch
            {
                tabKue = new DataTable();
                tabKue.Columns.Add("Kode Kue");
                tabKue.Columns.Add("Nama Kue");
                tabKue.Columns.Add("Jumlah");
                tabKue.Columns.Add("Harga");

                SaveToJson<DataTable>(tabKue, pathDirectory + pathKue);
            }
            dataGridView1.DataSource = tabKue;            
        }
        public static T ReadFromJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static void SaveToJson<T>(T obj, string path)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public void reset()
        {
            textBoxKode.Text = "";
            textBoxNama.Text = "";
            textBoxJumlah.Text = "";
            textBoxHarga.Text = "";
        }
        
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            List<Kue> DataKue = new List<Kue>();

            String kode = textBoxKode.Text;
            String nama = textBoxNama.Text;
            int jmlh = Int32.Parse(textBoxJumlah.Text);
            int hrg = Int32.Parse(textBoxHarga.Text);

            DataKue.Add(new Kue(kode, nama, jmlh, hrg));


            for (int i = 0; i < DataKue.Count; i++)
            {
                tabKue.Rows.Add(
                        DataKue[i].getKodeKue().ToString(),
                        DataKue[i].getNamaKue().ToString(),
                        DataKue[i].getJumlah().ToString(),
                        DataKue[i].getHarga().ToString()
                        ); 
            }
            dataGridView1.DataSource = tabKue;
            SaveToJson<DataTable>(tabKue, pathDirectory + pathKue);
            reset();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new dashboard().Show();
        }
    }
}
