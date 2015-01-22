namespace İngilizce_Kelime_Ezber_Programı
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKelimeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeÇalışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAnlam = new System.Windows.Forms.TextBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnIpucu = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.txtSecim = new System.Windows.Forms.TextBox();
            this.lblSecim = new System.Windows.Forms.Label();
            this.lblKelimeAnlam2 = new System.Windows.Forms.Label();
            this.lblKelimeAnlam1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKelimeEkleToolStripMenuItem,
            this.istatistikleriGörüntüleToolStripMenuItem,
            this.kelimeÇalışToolStripMenuItem});
            this.menüToolStripMenuItem.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.home;
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // yeniKelimeEkleToolStripMenuItem
            // 
            this.yeniKelimeEkleToolStripMenuItem.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.Custom_Icon_Design_Flatastic_1_Add;
            this.yeniKelimeEkleToolStripMenuItem.Name = "yeniKelimeEkleToolStripMenuItem";
            this.yeniKelimeEkleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.yeniKelimeEkleToolStripMenuItem.Text = "Yeni Kelime Ekle";
            this.yeniKelimeEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKelimeEkleToolStripMenuItem_Click);
            // 
            // istatistikleriGörüntüleToolStripMenuItem
            // 
            this.istatistikleriGörüntüleToolStripMenuItem.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.stats;
            this.istatistikleriGörüntüleToolStripMenuItem.Name = "istatistikleriGörüntüleToolStripMenuItem";
            this.istatistikleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.istatistikleriGörüntüleToolStripMenuItem.Text = "İstatistikleri Görüntüle";
            this.istatistikleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.istatistikleriGörüntüleToolStripMenuItem_Click);
            // 
            // kelimeÇalışToolStripMenuItem
            // 
            this.kelimeÇalışToolStripMenuItem.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.Chromatix_Aerial_Work;
            this.kelimeÇalışToolStripMenuItem.Name = "kelimeÇalışToolStripMenuItem";
            this.kelimeÇalışToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kelimeÇalışToolStripMenuItem.Text = "Kelime Çalış";
            this.kelimeÇalışToolStripMenuItem.Click += new System.EventHandler(this.kelimeÇalışToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.Hopstarter_Gloss_Mac_Get_Info;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.communication1;
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.exit;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtAnlam);
            this.groupBox1.Controls.Add(this.txtKelime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblKelime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kelime Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources._199;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(97, 142);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(172, 46);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "   Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAnlam
            // 
            this.txtAnlam.Location = new System.Drawing.Point(97, 101);
            this.txtAnlam.Name = "txtAnlam";
            this.txtAnlam.Size = new System.Drawing.Size(172, 23);
            this.txtAnlam.TabIndex = 3;
            this.txtAnlam.Enter += new System.EventHandler(this.txtAnlam_Enter);
            this.txtAnlam.Leave += new System.EventHandler(this.txtAnlam_Leave);
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(97, 52);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(172, 23);
            this.txtKelime.TabIndex = 2;
            this.txtKelime.Enter += new System.EventHandler(this.txtKelime_Enter);
            this.txtKelime.Leave += new System.EventHandler(this.txtKelime_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Anlamı : ";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(18, 55);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(62, 17);
            this.lblKelime.TabIndex = 0;
            this.lblKelime.Text = "Kelime : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(227, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "İngilizce Kelime Ezber Programı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(323, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 511);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelime - Anlam";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIstatistik);
            this.groupBox3.Controls.Add(this.btnIpucu);
            this.groupBox3.Controls.Add(this.btnKontrol);
            this.groupBox3.Controls.Add(this.btnBaslat);
            this.groupBox3.Controls.Add(this.txtSecim);
            this.groupBox3.Controls.Add(this.lblSecim);
            this.groupBox3.Controls.Add(this.lblKelimeAnlam2);
            this.groupBox3.Controls.Add(this.lblKelimeAnlam1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 300);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kelime Çalış";
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIstatistik.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources._088;
            this.btnIstatistik.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIstatistik.Location = new System.Drawing.Point(141, 211);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(128, 44);
            this.btnIstatistik.TabIndex = 19;
            this.btnIstatistik.Text = "İstatistikleri Görüntüle";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnIpucu
            // 
            this.btnIpucu.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources._049;
            this.btnIpucu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIpucu.Location = new System.Drawing.Point(20, 211);
            this.btnIpucu.Name = "btnIpucu";
            this.btnIpucu.Size = new System.Drawing.Size(115, 44);
            this.btnIpucu.TabIndex = 18;
            this.btnIpucu.Text = "        İpucu";
            this.btnIpucu.UseVisualStyleBackColor = true;
            this.btnIpucu.Click += new System.EventHandler(this.btnIpucu_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources._020;
            this.btnKontrol.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKontrol.Location = new System.Drawing.Point(141, 164);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(128, 41);
            this.btnKontrol.TabIndex = 17;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources._113;
            this.btnBaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaslat.Location = new System.Drawing.Point(20, 164);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(115, 41);
            this.btnBaslat.TabIndex = 14;
            this.btnBaslat.Text = "        Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // txtSecim
            // 
            this.txtSecim.Location = new System.Drawing.Point(132, 123);
            this.txtSecim.Name = "txtSecim";
            this.txtSecim.Size = new System.Drawing.Size(137, 23);
            this.txtSecim.TabIndex = 13;
            this.txtSecim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecim_KeyPress);
            // 
            // lblSecim
            // 
            this.lblSecim.AutoSize = true;
            this.lblSecim.Location = new System.Drawing.Point(147, 91);
            this.lblSecim.Name = "lblSecim";
            this.lblSecim.Size = new System.Drawing.Size(13, 17);
            this.lblSecim.TabIndex = 12;
            this.lblSecim.Text = "-";
            // 
            // lblKelimeAnlam2
            // 
            this.lblKelimeAnlam2.AutoSize = true;
            this.lblKelimeAnlam2.Location = new System.Drawing.Point(17, 129);
            this.lblKelimeAnlam2.Name = "lblKelimeAnlam2";
            this.lblKelimeAnlam2.Size = new System.Drawing.Size(105, 17);
            this.lblKelimeAnlam2.TabIndex = 11;
            this.lblKelimeAnlam2.Text = "Kelime/Anlam : ";
            // 
            // lblKelimeAnlam1
            // 
            this.lblKelimeAnlam1.AutoSize = true;
            this.lblKelimeAnlam1.Location = new System.Drawing.Point(17, 91);
            this.lblKelimeAnlam1.Name = "lblKelimeAnlam1";
            this.lblKelimeAnlam1.Size = new System.Drawing.Size(105, 17);
            this.lblKelimeAnlam1.TabIndex = 10;
            this.lblKelimeAnlam1.Text = "Kelime/Anlam : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İngilizce ",
            "Türkçe"});
            this.comboBox1.Location = new System.Drawing.Point(21, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Çalışacağınız Dili Seçiniz...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İngilizce_Kelime_Ezber_Programı.Properties.Resources.Dictionary_Mac_Book_icon;
            this.pictureBox1.Location = new System.Drawing.Point(160, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(647, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Ezber Programı V.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKelimeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAnlam;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSecim;
        private System.Windows.Forms.Label lblSecim;
        private System.Windows.Forms.Label lblKelimeAnlam2;
        private System.Windows.Forms.Label lblKelimeAnlam1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIpucu;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.ToolStripMenuItem istatistikleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeÇalışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
    }
}

