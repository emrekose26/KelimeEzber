using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace İngilizce_Kelime_Ezber_Programı
{
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }

        private void istatistik_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EnglishTurkishSozluk.accdb;");
            DataSet dtst = new DataSet();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT dogru,yanlis,tarih,yuzdeBasari FROM istatistik", baglanti);

            adtr.Fill(dtst, "istatistik");

            dataGridView1.DataSource = dtst.Tables["istatistik"];

            adtr.Dispose();

            dataGridView1.Columns[0].HeaderText = "Doğru Sayısı";
            dataGridView1.Columns[1].HeaderText = "Yanlış Sayısı";
            dataGridView1.Columns[2].HeaderText = "Uygulamanın Yapıldığı\nTarih ve Saat";
            dataGridView1.Columns[3].HeaderText = "% Başarı";
            dataGridView1.Columns[0].Width = 83;
            dataGridView1.Columns[1].Width = 83;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 70;
            baglanti.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
