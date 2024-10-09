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
            this.progressBar_durum = new System.Windows.Forms.ProgressBar();
            this.button_hakkinda = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox_veritabanituru = new System.Windows.Forms.GroupBox();
            this.comboBox1_veritabanituru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_veritabanibaglanti = new System.Windows.Forms.GroupBox();
            this.button_baglantibaslat = new System.Windows.Forms.Button();
            this.checkBox_sifregoster = new System.Windows.Forms.CheckBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_sunucu = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.textBox_veritabaniadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_sayac = new System.Windows.Forms.Timer(this.components);
            this.groupBox_veritabanituru.SuspendLayout();
            this.groupBox_veritabanibaglanti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_arkaplan
            // 
            this.label_arkaplan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_arkaplan.Location = new System.Drawing.Point(0, 0);
            this.label_arkaplan.Name = "label_arkaplan";
            this.label_arkaplan.Size = new System.Drawing.Size(485, 121);
            this.label_arkaplan.TabIndex = 11;
            // 
            // label_baslik
            // 
            this.label_baslik.AutoSize = true;
            this.label_baslik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_baslik.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baslik.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_baslik.Location = new System.Drawing.Point(7, 9);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(165, 28);
            this.label_baslik.TabIndex = 13;
            this.label_baslik.Text = "DBConnector";
            // 
            // label_altbaslik
            // 
            this.label_altbaslik.AutoSize = true;
            this.label_altbaslik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_altbaslik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_altbaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_altbaslik.Location = new System.Drawing.Point(8, 36);
            this.label_altbaslik.Name = "label_altbaslik";
            this.label_altbaslik.Size = new System.Drawing.Size(352, 21);
            this.label_altbaslik.TabIndex = 12;
            this.label_altbaslik.Text = "Database Connection Checker Application\r\n";
            // 
            // progressBar_durum
            // 
            this.progressBar_durum.Location = new System.Drawing.Point(0, 119);
            this.progressBar_durum.Name = "progressBar_durum";
            this.progressBar_durum.Size = new System.Drawing.Size(484, 8);
            this.progressBar_durum.TabIndex = 10;
            // 
            // button_hakkinda
            // 
            this.button_hakkinda.ImageIndex = 0;
            this.button_hakkinda.ImageList = this.ımageList1;
            this.button_hakkinda.Location = new System.Drawing.Point(12, 61);
            this.button_hakkinda.Name = "button_hakkinda";
            this.button_hakkinda.Size = new System.Drawing.Size(50, 50);
            this.button_hakkinda.TabIndex = 8;
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
            this.groupBox_veritabanituru.Location = new System.Drawing.Point(12, 129);
            this.groupBox_veritabanituru.Name = "groupBox_veritabanituru";
            this.groupBox_veritabanituru.Size = new System.Drawing.Size(460, 69);
            this.groupBox_veritabanituru.TabIndex = 6;
            this.groupBox_veritabanituru.TabStop = false;
            // 
            // comboBox1_veritabanituru
            // 
            this.comboBox1_veritabanituru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_veritabanituru.FormattingEnabled = true;
            this.comboBox1_veritabanituru.Location = new System.Drawing.Point(157, 24);
            this.comboBox1_veritabanituru.Name = "comboBox1_veritabanituru";
            this.comboBox1_veritabanituru.Size = new System.Drawing.Size(287, 29);
            this.comboBox1_veritabanituru.TabIndex = 0;
            this.comboBox1_veritabanituru.SelectedIndexChanged += new System.EventHandler(this.comboBox1_veritabanituru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Brands";
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
            this.groupBox_veritabanibaglanti.Location = new System.Drawing.Point(12, 198);
            this.groupBox_veritabanibaglanti.Name = "groupBox_veritabanibaglanti";
            this.groupBox_veritabanibaglanti.Size = new System.Drawing.Size(460, 274);
            this.groupBox_veritabanibaglanti.TabIndex = 7;
            this.groupBox_veritabanibaglanti.TabStop = false;
            // 
            // button_baglantibaslat
            // 
            this.button_baglantibaslat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_baglantibaslat.Location = new System.Drawing.Point(16, 199);
            this.button_baglantibaslat.Name = "button_baglantibaslat";
            this.button_baglantibaslat.Size = new System.Drawing.Size(428, 60);
            this.button_baglantibaslat.TabIndex = 7;
            this.button_baglantibaslat.Text = "Connect";
            this.button_baglantibaslat.UseVisualStyleBackColor = true;
            this.button_baglantibaslat.Click += new System.EventHandler(this.button_baglantibaslat_Click);
            // 
            // checkBox_sifregoster
            // 
            this.checkBox_sifregoster.AutoSize = true;
            this.checkBox_sifregoster.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_sifregoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_sifregoster.Location = new System.Drawing.Point(302, 169);
            this.checkBox_sifregoster.Name = "checkBox_sifregoster";
            this.checkBox_sifregoster.Size = new System.Drawing.Size(142, 24);
            this.checkBox_sifregoster.TabIndex = 6;
            this.checkBox_sifregoster.Text = "Show Password";
            this.checkBox_sifregoster.UseVisualStyleBackColor = true;
            this.checkBox_sifregoster.CheckedChanged += new System.EventHandler(this.checkBox_sifregoster_CheckedChanged);
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifre.Location = new System.Drawing.Point(157, 132);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(287, 31);
            this.textBox_sifre.TabIndex = 5;
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_port.Location = new System.Drawing.Point(363, 95);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(81, 31);
            this.textBox_port.TabIndex = 4;
            this.textBox_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_port_KeyPress);
            // 
            // textBox_sunucu
            // 
            this.textBox_sunucu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sunucu.Location = new System.Drawing.Point(157, 95);
            this.textBox_sunucu.Name = "textBox_sunucu";
            this.textBox_sunucu.Size = new System.Drawing.Size(200, 31);
            this.textBox_sunucu.TabIndex = 3;
            // 
            // textBox_kullaniciadi
            // 
            this.textBox_kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciadi.Location = new System.Drawing.Point(157, 58);
            this.textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            this.textBox_kullaniciadi.Size = new System.Drawing.Size(287, 31);
            this.textBox_kullaniciadi.TabIndex = 2;
            // 
            // textBox_veritabaniadi
            // 
            this.textBox_veritabaniadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_veritabaniadi.Location = new System.Drawing.Point(157, 21);
            this.textBox_veritabaniadi.Name = "textBox_veritabaniadi";
            this.textBox_veritabaniadi.Size = new System.Drawing.Size(287, 31);
            this.textBox_veritabaniadi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(69, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(47, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Server / Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(57, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Name";
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
            this.ClientSize = new System.Drawing.Size(484, 497);
            this.Controls.Add(this.groupBox_veritabanibaglanti);
            this.Controls.Add(this.groupBox_veritabanituru);
            this.Controls.Add(this.button_hakkinda);
            this.Controls.Add(this.progressBar_durum);
            this.Controls.Add(this.label_altbaslik);
            this.Controls.Add(this.label_baslik);
            this.Controls.Add(this.label_arkaplan);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.ProgressBar progressBar_durum;
        private System.Windows.Forms.Button button_hakkinda;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox_veritabanituru;
        private System.Windows.Forms.GroupBox groupBox_veritabanibaglanti;
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

