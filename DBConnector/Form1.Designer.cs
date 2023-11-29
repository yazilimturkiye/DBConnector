namespace DBConnector
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_arkaplan = new System.Windows.Forms.Label();
            this.label_baslik = new System.Windows.Forms.Label();
            this.label_altbaslik = new System.Windows.Forms.Label();
            this.label_versiyon = new System.Windows.Forms.Label();
            this.progressBar_durum = new System.Windows.Forms.ProgressBar();
            this.button_hakkinda = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox_veritabanituru = new System.Windows.Forms.GroupBox();
            this.groupBox_veritabanibaglanti = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_veritabanituru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_veritabaniadi = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.textBox_sunucu = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.checkBox_sifregoster = new System.Windows.Forms.CheckBox();
            this.button_baglantibaslat = new System.Windows.Forms.Button();
            this.timer_sayac = new System.Windows.Forms.Timer(this.components);
            this.groupBox_veritabanituru.SuspendLayout();
            this.groupBox_veritabanibaglanti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_arkaplan
            // 
            this.label_arkaplan.BackColor = System.Drawing.Color.White;
            this.label_arkaplan.Location = new System.Drawing.Point(0, 1);
            this.label_arkaplan.Name = "label_arkaplan";
            this.label_arkaplan.Size = new System.Drawing.Size(485, 137);
            this.label_arkaplan.TabIndex = 0;
            // 
            // label_baslik
            // 
            this.label_baslik.AutoSize = true;
            this.label_baslik.BackColor = System.Drawing.Color.White;
            this.label_baslik.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baslik.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_baslik.Location = new System.Drawing.Point(14, 9);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(282, 28);
            this.label_baslik.TabIndex = 1;
            this.label_baslik.Text = "VT Bağlantı Kontrolcüsü";
            // 
            // label_altbaslik
            // 
            this.label_altbaslik.AutoSize = true;
            this.label_altbaslik.BackColor = System.Drawing.Color.White;
            this.label_altbaslik.Location = new System.Drawing.Point(15, 42);
            this.label_altbaslik.Name = "label_altbaslik";
            this.label_altbaslik.Size = new System.Drawing.Size(274, 21);
            this.label_altbaslik.TabIndex = 2;
            this.label_altbaslik.Text = "Veritabanı Bağlantısı Kontrol Aracı";
            // 
            // label_versiyon
            // 
            this.label_versiyon.AutoSize = true;
            this.label_versiyon.BackColor = System.Drawing.Color.White;
            this.label_versiyon.Location = new System.Drawing.Point(291, 16);
            this.label_versiyon.Name = "label_versiyon";
            this.label_versiyon.Size = new System.Drawing.Size(42, 21);
            this.label_versiyon.TabIndex = 3;
            this.label_versiyon.Text = "v1.0";
            // 
            // progressBar_durum
            // 
            this.progressBar_durum.Location = new System.Drawing.Point(0, 138);
            this.progressBar_durum.Name = "progressBar_durum";
            this.progressBar_durum.Size = new System.Drawing.Size(484, 8);
            this.progressBar_durum.TabIndex = 4;
            // 
            // button_hakkinda
            // 
            this.button_hakkinda.ImageIndex = 0;
            this.button_hakkinda.ImageList = this.ımageList1;
            this.button_hakkinda.Location = new System.Drawing.Point(19, 74);
            this.button_hakkinda.Name = "button_hakkinda";
            this.button_hakkinda.Size = new System.Drawing.Size(50, 50);
            this.button_hakkinda.TabIndex = 5;
            this.button_hakkinda.UseVisualStyleBackColor = true;
            this.button_hakkinda.Click += new System.EventHandler(this.button_hakkinda_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ayarlar.png");
            // 
            // groupBox_veritabanituru
            // 
            this.groupBox_veritabanituru.Controls.Add(this.comboBox1_veritabanituru);
            this.groupBox_veritabanituru.Controls.Add(this.label1);
            this.groupBox_veritabanituru.Location = new System.Drawing.Point(12, 148);
            this.groupBox_veritabanituru.Name = "groupBox_veritabanituru";
            this.groupBox_veritabanituru.Size = new System.Drawing.Size(460, 100);
            this.groupBox_veritabanituru.TabIndex = 6;
            this.groupBox_veritabanituru.TabStop = false;
            // 
            // groupBox_veritabanibaglanti
            // 
            this.groupBox_veritabanibaglanti.Controls.Add(this.button_baglantibaslat);
            this.groupBox_veritabanibaglanti.Controls.Add(this.checkBox_sifregoster);
            this.groupBox_veritabanibaglanti.Controls.Add(this.textBox_sifre);
            this.groupBox_veritabanibaglanti.Controls.Add(this.textBox_port);
            this.groupBox_veritabanibaglanti.Controls.Add(this.textBox_sunucu);
            this.groupBox_veritabanibaglanti.Controls.Add(this.textBox_kullaniciadi);
            this.groupBox_veritabanibaglanti.Controls.Add(this.textBox_veritabaniadi);
            this.groupBox_veritabanibaglanti.Controls.Add(this.label5);
            this.groupBox_veritabanibaglanti.Controls.Add(this.label4);
            this.groupBox_veritabanibaglanti.Controls.Add(this.label3);
            this.groupBox_veritabanibaglanti.Controls.Add(this.label2);
            this.groupBox_veritabanibaglanti.Location = new System.Drawing.Point(12, 248);
            this.groupBox_veritabanibaglanti.Name = "groupBox_veritabanibaglanti";
            this.groupBox_veritabanibaglanti.Size = new System.Drawing.Size(460, 333);
            this.groupBox_veritabanibaglanti.TabIndex = 7;
            this.groupBox_veritabanibaglanti.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SeaGreen;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(322, 584);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 21);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yazilimturkiye.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veritabanı Türü";
            // 
            // comboBox1_veritabanituru
            // 
            this.comboBox1_veritabanituru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_veritabanituru.FormattingEnabled = true;
            this.comboBox1_veritabanituru.Location = new System.Drawing.Point(141, 42);
            this.comboBox1_veritabanituru.Name = "comboBox1_veritabanituru";
            this.comboBox1_veritabanituru.Size = new System.Drawing.Size(303, 29);
            this.comboBox1_veritabanituru.TabIndex = 1;
            this.comboBox1_veritabanituru.SelectedIndexChanged += new System.EventHandler(this.comboBox1_veritabanituru_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veritabanı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sunucu / Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre";
            // 
            // textBox_veritabaniadi
            // 
            this.textBox_veritabaniadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_veritabaniadi.Location = new System.Drawing.Point(141, 27);
            this.textBox_veritabaniadi.Name = "textBox_veritabaniadi";
            this.textBox_veritabaniadi.Size = new System.Drawing.Size(303, 31);
            this.textBox_veritabaniadi.TabIndex = 6;
            // 
            // textBox_kullaniciadi
            // 
            this.textBox_kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciadi.Location = new System.Drawing.Point(141, 83);
            this.textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            this.textBox_kullaniciadi.Size = new System.Drawing.Size(303, 31);
            this.textBox_kullaniciadi.TabIndex = 7;
            // 
            // textBox_sunucu
            // 
            this.textBox_sunucu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sunucu.Location = new System.Drawing.Point(141, 135);
            this.textBox_sunucu.Name = "textBox_sunucu";
            this.textBox_sunucu.Size = new System.Drawing.Size(216, 31);
            this.textBox_sunucu.TabIndex = 8;
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_port.Location = new System.Drawing.Point(363, 135);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(81, 31);
            this.textBox_port.TabIndex = 9;
            this.textBox_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_port_KeyPress);
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifre.Location = new System.Drawing.Point(141, 190);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(303, 31);
            this.textBox_sifre.TabIndex = 10;
            // 
            // checkBox_sifregoster
            // 
            this.checkBox_sifregoster.AutoSize = true;
            this.checkBox_sifregoster.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_sifregoster.Location = new System.Drawing.Point(141, 227);
            this.checkBox_sifregoster.Name = "checkBox_sifregoster";
            this.checkBox_sifregoster.Size = new System.Drawing.Size(122, 24);
            this.checkBox_sifregoster.TabIndex = 11;
            this.checkBox_sifregoster.Text = "Şifreyi Göster";
            this.checkBox_sifregoster.UseVisualStyleBackColor = true;
            this.checkBox_sifregoster.CheckedChanged += new System.EventHandler(this.checkBox_sifregoster_CheckedChanged);
            // 
            // button_baglantibaslat
            // 
            this.button_baglantibaslat.Location = new System.Drawing.Point(16, 257);
            this.button_baglantibaslat.Name = "button_baglantibaslat";
            this.button_baglantibaslat.Size = new System.Drawing.Size(428, 60);
            this.button_baglantibaslat.TabIndex = 12;
            this.button_baglantibaslat.Text = "Bağlantı Kur";
            this.button_baglantibaslat.UseVisualStyleBackColor = true;
            this.button_baglantibaslat.Click += new System.EventHandler(this.button_baglantibaslat_Click);
            // 
            // timer_sayac
            // 
            this.timer_sayac.Interval = 15;
            this.timer_sayac.Tick += new System.EventHandler(this.timer_sayac_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox_veritabanibaglanti);
            this.Controls.Add(this.groupBox_veritabanituru);
            this.Controls.Add(this.button_hakkinda);
            this.Controls.Add(this.progressBar_durum);
            this.Controls.Add(this.label_versiyon);
            this.Controls.Add(this.label_altbaslik);
            this.Controls.Add(this.label_baslik);
            this.Controls.Add(this.label_arkaplan);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBConnector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_veritabanituru.ResumeLayout(false);
            this.groupBox_veritabanituru.PerformLayout();
            this.groupBox_veritabanibaglanti.ResumeLayout(false);
            this.groupBox_veritabanibaglanti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_arkaplan;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.Label label_altbaslik;
        private System.Windows.Forms.Label label_versiyon;
        private System.Windows.Forms.ProgressBar progressBar_durum;
        private System.Windows.Forms.Button button_hakkinda;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox_veritabanituru;
        private System.Windows.Forms.GroupBox groupBox_veritabanibaglanti;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1_veritabanituru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_veritabaniadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_baglantibaslat;
        private System.Windows.Forms.CheckBox checkBox_sifregoster;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_sunucu;
        private System.Windows.Forms.TextBox textBox_kullaniciadi;
        private System.Windows.Forms.Timer timer_sayac;
    }
}

