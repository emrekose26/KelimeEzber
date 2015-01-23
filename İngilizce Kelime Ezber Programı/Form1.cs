/*
    author: Emre Köse
    date: 22.01.2015
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace İngilizce_Kelime_Ezber_Programı
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Tanımlamalar
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EnglishTurkishSozluk.accdb;");

        ArrayList kelimeNext;
        ArrayList anlamNext;
        static int baslangic = 1;
        static int dogruSayaci, yanlisSayaci;

        #endregion

        private void DataGridViewFill()
        {
            DataSet dtst = new DataSet();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT kelime,anlam FROM sozluk Order By kelime Asc", baglanti);

            adtr.Fill(dtst, "sozluk");

            dataGridView1.DataSource = dtst.Tables["sozluk"];

            adtr.Dispose();

            dataGridView1.Columns[0].HeaderText = "Kelime";
            dataGridView1.Columns[1].HeaderText = "Anlamı";
            baglanti.Close();

        }

        private ArrayList ArrayListAta(byte parameter)
        {
            ArrayList AL_kelime = new ArrayList();
            ArrayList AL_anlam = new ArrayList();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM sozluk ORDER BY RND(ID)", baglanti);

            baglanti.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                AL_kelime.Add(dr["kelime"].ToString());
                AL_anlam.Add(dr["anlam"].ToString());
            }
            baglanti.Close();

            if (parameter == 1)
                return AL_kelime;
            else
                return AL_anlam;
        }

        public void rastgeleElemanGetir()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM sozluk ORDER BY RND(ID)", baglanti);
            baglanti.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kelimeNext.Add(dr["kelime"].ToString());
                anlamNext.Add(dr["anlam"].ToString());
            }
            baglanti.Close();

        }

        private void sonrakiKelimeGetir()
        {
            txtSecim.Text = "";
            if (baslangic == 0)
                rastgeleElemanGetir();

            if (kelimeNext.Count > baslangic)
            {
                if (comboBox1.SelectedIndex == 0)
                    lblSecim.Text = kelimeNext[baslangic].ToString();
                else if (comboBox1.SelectedIndex == 1)
                    lblSecim.Text = anlamNext[baslangic].ToString();
                baslangic++;
            }
            else
            {
                MessageBox.Show("Başka Kelime Kalmadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show("Doğru Sayısı : " + (dogruSayaci) + "\nYanlış Sayısı : " + (yanlisSayaci), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                istatistikKaydet();

                DialogResult result = MessageBox.Show("Baştan başlamak ister misiniz ? ", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dogruSayaci = 0;
                    yanlisSayaci = 0;
                    baslangic = 1;
                    lblSecim.Text = "";
                    btnBaslat.Enabled = true;
                    btnKontrol.Enabled = false;
                    comboBox1.Enabled = true;
                }

                else if (result == DialogResult.No)
                {
                    dogruSayaci = 0;
                    yanlisSayaci = 0;
                    baslangic = 1;
                    groupBox1.Enabled = true;
                    DataGridViewFill();
                    comboBox1.Enabled = true;
                    btnBaslat.Enabled = true;
                    btnKontrol.Enabled = false;
                    lblSecim.Text = "-";
                }

            }
        }

        private void istatistikKaydet()
        {
            double basari = (100 * dogruSayaci) / (dogruSayaci + yanlisSayaci);
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                OleDbCommand komut = new OleDbCommand("INSERT INTO istatistik(dogru,yanlis,tarih,yuzdeBasari) VALUES (@dogru,@yanlis,@tarih,@basari)", baglanti);

                komut.Parameters.AddWithValue("@dogru", dogruSayaci);
                komut.Parameters.AddWithValue("@yanlis", yanlisSayaci);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                komut.Parameters.AddWithValue("@basari", basari);

                komut.ExecuteNonQuery();

            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem sırasındabir hata oluştu\n Hata : " + hata.ToString());
            }
            finally
            {
                baglanti.Close();

            }
        }

        private void kelimeSifrele(string kelime)
        {
            string ilkHarf = kelime.Substring(0, 1);
            string sonHarf = kelime.Substring(kelime.Length - 1, 1);
            string ortaHarfler = null; ;

            for (int i = 0; i < kelime.Length - 2; i++)
            {
                ortaHarfler += "*";
            }
            MessageBox.Show(ilkHarf + ortaHarfler + sonHarf, "İpucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewFill();
            lblKelimeSayisi.Text = (dataGridView1.Rows.Count-1).ToString();
            dataGridView1.Columns[0].Width = 129;
            dataGridView1.Columns[1].Width = 128;
            btnKontrol.Enabled = false;
            txtSecim.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKelime.Text == "" || txtAnlam.Text == "")
            {
                MessageBox.Show("Kelime veya Anlam alanlarından herhangi birini boş geçemezsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO sozluk (kelime,anlam) VALUES (@kelime,@anlam)", baglanti);

                    cmd.Parameters.AddWithValue("@kelime", txtKelime.Text);
                    cmd.Parameters.AddWithValue("@anlam", txtAnlam.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKelime.Text = "";
                    txtAnlam.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu\n Hata : " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    baglanti.Close();
                    DataGridViewFill();
                    lblKelimeSayisi.Text = (dataGridView1.Rows.Count - 1).ToString();
                }
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Çalışmak için bir dil seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.DataSource = null;
                groupBox1.Enabled = false;
                btnKontrol.Enabled = true;
                comboBox1.Enabled = false;
                btnBaslat.Enabled = false;

                kelimeNext = ArrayListAta(1);
                anlamNext = ArrayListAta(2);
                if (comboBox1.SelectedIndex == 0)
                {
                    lblSecim.Text = kelimeNext[0].ToString();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    lblSecim.Text = anlamNext[0].ToString();
                }
            }
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                if (comboBox1.SelectedIndex == 0)
                {
                    OleDbCommand kontrol_kelime = new OleDbCommand("SELECT anlam FROM sozluk WHERE kelime ='" + lblSecim.Text + "'", baglanti);
                    OleDbDataReader dr = kontrol_kelime.ExecuteReader();
                    string anlam = null;

                    while (dr.Read())
                    {
                        anlam = dr["anlam"].ToString();
                    }
                    dr.Close();

                    if (anlam == txtSecim.Text)
                    {
                        MessageBox.Show("Doğru bildiniz", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dogruSayaci++;
                        baglanti.Close();
                        sonrakiKelimeGetir();
                    }

                    else
                    {
                        MessageBox.Show("Maalesef Bilemediniz!!\nKelimenin Doğrusu : " + anlam.ToString(), "Olmadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        yanlisSayaci++;
                        baglanti.Close();
                        sonrakiKelimeGetir();

                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    OleDbCommand kontrol_anlam = new OleDbCommand("SELECT kelime FROM sozluk WHERE anlam = '" + lblSecim.Text + "'", baglanti);
                    OleDbDataReader dr2 = kontrol_anlam.ExecuteReader();
                    string kelime = null;

                    while (dr2.Read())
                    {
                        kelime = dr2["kelime"].ToString();
                    }
                    dr2.Close();

                    if (kelime == txtSecim.Text)
                    {
                        MessageBox.Show("Doğru bildiniz", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dogruSayaci++;
                        baglanti.Close();
                        sonrakiKelimeGetir();

                    }

                    else
                    {
                        MessageBox.Show("Maalesef Bilemediniz!!\nKelimenin Doğrusu : " + kelime.ToString(), "Olmadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        yanlisSayaci++;
                        baglanti.Close();
                        sonrakiKelimeGetir();

                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu \nHata : " + hata.ToString());
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnIpucu_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                if (comboBox1.SelectedIndex == 0)
                {
                    OleDbCommand cmdIpucuAnlam = new OleDbCommand("SELECT anlam FROM sozluk WHERE kelime = '" + lblSecim.Text + "'", baglanti);
                    OleDbDataReader drIpucu = cmdIpucuAnlam.ExecuteReader();

                    string anlam = null;

                    while (drIpucu.Read())
                    {
                        anlam = drIpucu["anlam"].ToString();
                    }
                    drIpucu.Close();

                    kelimeSifrele(anlam);

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    OleDbCommand cmdIpucuKelime = new OleDbCommand("SELECT kelime FROM sozluk WHERE anlam = '" + lblSecim.Text + "'", baglanti);

                    OleDbDataReader drIpucu = cmdIpucuKelime.ExecuteReader();

                    string kelime = null;

                    while (drIpucu.Read())
                    {
                        kelime = drIpucu["kelime"].ToString();
                    }
                    drIpucu.Close();

                    kelimeSifrele(kelime);

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bir hata meydana geldi\nHata : " + hata.ToString());
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            istatistik newForm = new istatistik();
            newForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lblKelimeAnlam1.Text = "Kelime : ";
                lblKelimeAnlam2.Text = "Anlam : ";
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                lblKelimeAnlam1.Text = "Anlam : ";
                lblKelimeAnlam2.Text = "Kelime : ";
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.No)
                return;
            else
                Application.Exit();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletisim newForm2 = new iletisim();
            newForm2.Show();
        }

        private void istatistikleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istatistik newForm = new istatistik();
            newForm.Show();
        }

        private void yeniKelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtKelime.Focus();
            txtKelime.BackColor = Color.LavenderBlush;
        }

        private void kelimeÇalışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            groupBox1.Enabled = false;
            btnKontrol.Enabled = true;
        }

        private void txtSecim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnKontrol_Click(sender, e);
            }

        }

        private void txtKelime_Leave(object sender, EventArgs e)
        {
            txtKelime.BackColor = Color.White;
        }

        private void txtAnlam_Enter(object sender, EventArgs e)
        {
            txtAnlam.BackColor = Color.LavenderBlush;
        }

        private void txtAnlam_Leave(object sender, EventArgs e)
        {
            txtAnlam.BackColor = Color.White;
        }

        private void txtKelime_Enter(object sender, EventArgs e)
        {
            txtKelime.BackColor = Color.LavenderBlush;
        }



    }
}
