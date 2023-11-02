namespace DBConnector
{
    partial class DBConnector
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
            this.label_arkaplan = new System.Windows.Forms.Label();
            this.label_baslik = new System.Windows.Forms.Label();
            this.label_altbaslik = new System.Windows.Forms.Label();
            this.label_versiyon = new System.Windows.Forms.Label();
            this.progressBar_durum = new System.Windows.Forms.ProgressBar();
            this.button_hakkinda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_veritabanituru = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_veritabaniadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.textBox_sunucuadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sunucuport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.button_baglantibaslat = new System.Windows.Forms.Button();
            this.checkBox_sifregoster = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_arkaplan
            // 
            this.label_arkaplan.BackColor = System.Drawing.Color.White;
            this.label_arkaplan.Location = new System.Drawing.Point(0, 1);
            this.label_arkaplan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.label_baslik.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.label_versiyon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_versiyon.Location = new System.Drawing.Point(291, 16);
            this.label_versiyon.Name = "label_versiyon";
            this.label_versiyon.Size = new System.Drawing.Size(39, 20);
            this.label_versiyon.TabIndex = 3;
            this.label_versiyon.Text = "v1.0";
            // 
            // progressBar_durum
            // 
            this.progressBar_durum.Location = new System.Drawing.Point(0, 139);
            this.progressBar_durum.Name = "progressBar_durum";
            this.progressBar_durum.Size = new System.Drawing.Size(484, 8);
            this.progressBar_durum.TabIndex = 4;
            // 
            // button_hakkinda
            // 
            this.button_hakkinda.Location = new System.Drawing.Point(19, 74);
            this.button_hakkinda.Name = "button_hakkinda";
            this.button_hakkinda.Size = new System.Drawing.Size(50, 50);
            this.button_hakkinda.TabIndex = 9;
            this.button_hakkinda.Text = "button1";
            this.button_hakkinda.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_veritabanituru);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Veritabanı Türü";
            // 
            // comboBox_veritabanituru
            // 
            this.comboBox_veritabanituru.FormattingEnabled = true;
            this.comboBox_veritabanituru.Location = new System.Drawing.Point(141, 34);
            this.comboBox_veritabanituru.Name = "comboBox_veritabanituru";
            this.comboBox_veritabanituru.Size = new System.Drawing.Size(303, 29);
            this.comboBox_veritabanituru.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_sifregoster);
            this.groupBox2.Controls.Add(this.button_baglantibaslat);
            this.groupBox2.Controls.Add(this.textBox_sifre);
            this.groupBox2.Controls.Add(this.textBox_sunucuport);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_sunucuadi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_kullaniciadi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_veritabaniadi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 345);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Veritabanı Adı";
            // 
            // textBox_veritabaniadi
            // 
            this.textBox_veritabaniadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_veritabaniadi.Location = new System.Drawing.Point(141, 31);
            this.textBox_veritabaniadi.Name = "textBox_veritabaniadi";
            this.textBox_veritabaniadi.Size = new System.Drawing.Size(303, 31);
            this.textBox_veritabaniadi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // textBox_kullaniciadi
            // 
            this.textBox_kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciadi.Location = new System.Drawing.Point(141, 83);
            this.textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            this.textBox_kullaniciadi.Size = new System.Drawing.Size(303, 31);
            this.textBox_kullaniciadi.TabIndex = 2;
            // 
            // textBox_sunucuadi
            // 
            this.textBox_sunucuadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sunucuadi.Location = new System.Drawing.Point(141, 135);
            this.textBox_sunucuadi.Name = "textBox_sunucuadi";
            this.textBox_sunucuadi.Size = new System.Drawing.Size(216, 31);
            this.textBox_sunucuadi.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sunucu / Port";
            // 
            // textBox_sunucuport
            // 
            this.textBox_sunucuport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sunucuport.Location = new System.Drawing.Point(363, 135);
            this.textBox_sunucuport.Name = "textBox_sunucuport";
            this.textBox_sunucuport.Size = new System.Drawing.Size(81, 31);
            this.textBox_sunucuport.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Şifre";
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifre.Location = new System.Drawing.Point(141, 190);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(303, 31);
            this.textBox_sifre.TabIndex = 5;
            // 
            // button_baglantibaslat
            // 
            this.button_baglantibaslat.Location = new System.Drawing.Point(16, 269);
            this.button_baglantibaslat.Name = "button_baglantibaslat";
            this.button_baglantibaslat.Size = new System.Drawing.Size(428, 60);
            this.button_baglantibaslat.TabIndex = 7;
            this.button_baglantibaslat.Text = "Bağlantı Başlat";
            this.button_baglantibaslat.UseVisualStyleBackColor = true;
            // 
            // checkBox_sifregoster
            // 
            this.checkBox_sifregoster.AutoSize = true;
            this.checkBox_sifregoster.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_sifregoster.Location = new System.Drawing.Point(141, 227);
            this.checkBox_sifregoster.Name = "checkBox_sifregoster";
            this.checkBox_sifregoster.Size = new System.Drawing.Size(122, 24);
            this.checkBox_sifregoster.TabIndex = 6;
            this.checkBox_sifregoster.Text = "Şifreyi Göster";
            this.checkBox_sifregoster.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(187, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // DBConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_hakkinda);
            this.Controls.Add(this.progressBar_durum);
            this.Controls.Add(this.label_versiyon);
            this.Controls.Add(this.label_altbaslik);
            this.Controls.Add(this.label_baslik);
            this.Controls.Add(this.label_arkaplan);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "DBConnector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBConnector";
            this.Load += new System.EventHandler(this.DBConnector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_veritabanituru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_kullaniciadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_veritabaniadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_sunucuport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_sunucuadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_sifregoster;
        private System.Windows.Forms.Button button_baglantibaslat;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

