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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_arkaplan = new System.Windows.Forms.Label();
            label_baslik = new System.Windows.Forms.Label();
            label_altbaslik = new System.Windows.Forms.Label();
            progressBar_durum = new System.Windows.Forms.ProgressBar();
            button_hakkinda = new System.Windows.Forms.Button();
            ımageList1 = new System.Windows.Forms.ImageList(components);
            groupBox_veritabanituru = new System.Windows.Forms.GroupBox();
            comboBox1_veritabanituru = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            groupBox_veritabanibaglanti = new System.Windows.Forms.GroupBox();
            button_baglantibaslat = new System.Windows.Forms.Button();
            checkBox_sifregoster = new System.Windows.Forms.CheckBox();
            textBox_sifre = new System.Windows.Forms.TextBox();
            textBox_port = new System.Windows.Forms.TextBox();
            textBox_sunucu = new System.Windows.Forms.TextBox();
            textBox_kullaniciadi = new System.Windows.Forms.TextBox();
            textBox_veritabaniadi = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            timer_sayac = new System.Windows.Forms.Timer(components);
            panel_connector = new System.Windows.Forms.Panel();
            panel_settings = new System.Windows.Forms.Panel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox_veritabanituru.SuspendLayout();
            groupBox_veritabanibaglanti.SuspendLayout();
            panel_connector.SuspendLayout();
            panel_settings.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_arkaplan
            // 
            label_arkaplan.BackColor = System.Drawing.SystemColors.ControlLight;
            label_arkaplan.Location = new System.Drawing.Point(0, 0);
            label_arkaplan.Name = "label_arkaplan";
            label_arkaplan.Size = new System.Drawing.Size(485, 121);
            label_arkaplan.TabIndex = 11;
            // 
            // label_baslik
            // 
            label_baslik.AutoSize = true;
            label_baslik.BackColor = System.Drawing.SystemColors.ControlLight;
            label_baslik.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            label_baslik.ForeColor = System.Drawing.Color.SeaGreen;
            label_baslik.Location = new System.Drawing.Point(7, 9);
            label_baslik.Name = "label_baslik";
            label_baslik.Size = new System.Drawing.Size(165, 28);
            label_baslik.TabIndex = 13;
            label_baslik.Text = "DBConnector";
            // 
            // label_altbaslik
            // 
            label_altbaslik.AutoSize = true;
            label_altbaslik.BackColor = System.Drawing.SystemColors.ControlLight;
            label_altbaslik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label_altbaslik.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_altbaslik.Location = new System.Drawing.Point(8, 36);
            label_altbaslik.Name = "label_altbaslik";
            label_altbaslik.Size = new System.Drawing.Size(352, 21);
            label_altbaslik.TabIndex = 12;
            label_altbaslik.Text = "Database Connection Checker Application\r\n";
            // 
            // progressBar_durum
            // 
            progressBar_durum.Location = new System.Drawing.Point(0, 119);
            progressBar_durum.Name = "progressBar_durum";
            progressBar_durum.Size = new System.Drawing.Size(484, 8);
            progressBar_durum.TabIndex = 10;
            // 
            // button_hakkinda
            // 
            button_hakkinda.ImageIndex = 0;
            button_hakkinda.ImageList = ımageList1;
            button_hakkinda.Location = new System.Drawing.Point(12, 64);
            button_hakkinda.Name = "button_hakkinda";
            button_hakkinda.Size = new System.Drawing.Size(45, 45);
            button_hakkinda.TabIndex = 8;
            button_hakkinda.UseVisualStyleBackColor = true;
            button_hakkinda.Click += button_hakkinda_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            ımageList1.Images.SetKeyName(0, "ayarlar.png");
            ımageList1.Images.SetKeyName(1, "connect.png");
            ımageList1.Images.SetKeyName(2, "logo.png");
            ımageList1.Images.SetKeyName(3, "cmd.png");
            // 
            // groupBox_veritabanituru
            // 
            groupBox_veritabanituru.Controls.Add(comboBox1_veritabanituru);
            groupBox_veritabanituru.Controls.Add(label1);
            groupBox_veritabanituru.Location = new System.Drawing.Point(12, 3);
            groupBox_veritabanituru.Name = "groupBox_veritabanituru";
            groupBox_veritabanituru.Size = new System.Drawing.Size(460, 69);
            groupBox_veritabanituru.TabIndex = 6;
            groupBox_veritabanituru.TabStop = false;
            // 
            // comboBox1_veritabanituru
            // 
            comboBox1_veritabanituru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1_veritabanituru.FormattingEnabled = true;
            comboBox1_veritabanituru.Location = new System.Drawing.Point(157, 24);
            comboBox1_veritabanituru.Name = "comboBox1_veritabanituru";
            comboBox1_veritabanituru.Size = new System.Drawing.Size(287, 29);
            comboBox1_veritabanituru.TabIndex = 0;
            comboBox1_veritabanituru.SelectedIndexChanged += comboBox1_veritabanituru_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label1.Location = new System.Drawing.Point(6, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "Database Brands";
            // 
            // groupBox_veritabanibaglanti
            // 
            groupBox_veritabanibaglanti.Controls.Add(button_baglantibaslat);
            groupBox_veritabanibaglanti.Controls.Add(checkBox_sifregoster);
            groupBox_veritabanibaglanti.Controls.Add(textBox_sifre);
            groupBox_veritabanibaglanti.Controls.Add(textBox_port);
            groupBox_veritabanibaglanti.Controls.Add(textBox_sunucu);
            groupBox_veritabanibaglanti.Controls.Add(textBox_kullaniciadi);
            groupBox_veritabanibaglanti.Controls.Add(textBox_veritabaniadi);
            groupBox_veritabanibaglanti.Controls.Add(label5);
            groupBox_veritabanibaglanti.Controls.Add(label4);
            groupBox_veritabanibaglanti.Controls.Add(label3);
            groupBox_veritabanibaglanti.Controls.Add(label2);
            groupBox_veritabanibaglanti.Location = new System.Drawing.Point(12, 72);
            groupBox_veritabanibaglanti.Name = "groupBox_veritabanibaglanti";
            groupBox_veritabanibaglanti.Size = new System.Drawing.Size(460, 274);
            groupBox_veritabanibaglanti.TabIndex = 7;
            groupBox_veritabanibaglanti.TabStop = false;
            // 
            // button_baglantibaslat
            // 
            button_baglantibaslat.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button_baglantibaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_baglantibaslat.ImageIndex = 1;
            button_baglantibaslat.ImageList = ımageList1;
            button_baglantibaslat.Location = new System.Drawing.Point(16, 199);
            button_baglantibaslat.Name = "button_baglantibaslat";
            button_baglantibaslat.Size = new System.Drawing.Size(428, 60);
            button_baglantibaslat.TabIndex = 7;
            button_baglantibaslat.Text = "Connect Database";
            button_baglantibaslat.UseVisualStyleBackColor = true;
            button_baglantibaslat.Click += button_baglantibaslat_Click;
            // 
            // checkBox_sifregoster
            // 
            checkBox_sifregoster.AutoSize = true;
            checkBox_sifregoster.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            checkBox_sifregoster.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            checkBox_sifregoster.Location = new System.Drawing.Point(157, 169);
            checkBox_sifregoster.Name = "checkBox_sifregoster";
            checkBox_sifregoster.Size = new System.Drawing.Size(142, 24);
            checkBox_sifregoster.TabIndex = 6;
            checkBox_sifregoster.Text = "Show Password";
            checkBox_sifregoster.UseVisualStyleBackColor = true;
            checkBox_sifregoster.CheckedChanged += checkBox_sifregoster_CheckedChanged;
            // 
            // textBox_sifre
            // 
            textBox_sifre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_sifre.Location = new System.Drawing.Point(157, 132);
            textBox_sifre.Name = "textBox_sifre";
            textBox_sifre.PasswordChar = '*';
            textBox_sifre.Size = new System.Drawing.Size(287, 31);
            textBox_sifre.TabIndex = 5;
            // 
            // textBox_port
            // 
            textBox_port.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_port.Location = new System.Drawing.Point(363, 95);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new System.Drawing.Size(81, 31);
            textBox_port.TabIndex = 4;
            textBox_port.KeyPress += textBox_port_KeyPress;
            // 
            // textBox_sunucu
            // 
            textBox_sunucu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_sunucu.Location = new System.Drawing.Point(157, 95);
            textBox_sunucu.Name = "textBox_sunucu";
            textBox_sunucu.Size = new System.Drawing.Size(200, 31);
            textBox_sunucu.TabIndex = 3;
            // 
            // textBox_kullaniciadi
            // 
            textBox_kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_kullaniciadi.Location = new System.Drawing.Point(157, 58);
            textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            textBox_kullaniciadi.Size = new System.Drawing.Size(287, 31);
            textBox_kullaniciadi.TabIndex = 2;
            // 
            // textBox_veritabaniadi
            // 
            textBox_veritabaniadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_veritabaniadi.Location = new System.Drawing.Point(157, 21);
            textBox_veritabaniadi.Name = "textBox_veritabaniadi";
            textBox_veritabaniadi.Size = new System.Drawing.Size(287, 31);
            textBox_veritabaniadi.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label5.Location = new System.Drawing.Point(69, 136);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 21);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label4.Location = new System.Drawing.Point(49, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 21);
            label4.TabIndex = 4;
            label4.Text = "Server - Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label3.Location = new System.Drawing.Point(57, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 21);
            label3.TabIndex = 3;
            label3.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label2.Location = new System.Drawing.Point(10, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 21);
            label2.TabIndex = 2;
            label2.Text = "Database Name";
            // 
            // timer_sayac
            // 
            timer_sayac.Interval = 15;
            timer_sayac.Tick += timer_sayac_Tick;
            // 
            // panel_connector
            // 
            panel_connector.Controls.Add(groupBox_veritabanituru);
            panel_connector.Controls.Add(groupBox_veritabanibaglanti);
            panel_connector.Location = new System.Drawing.Point(0, 127);
            panel_connector.Name = "panel_connector";
            panel_connector.Size = new System.Drawing.Size(484, 375);
            panel_connector.TabIndex = 14;
            // 
            // panel_settings
            // 
            panel_settings.Controls.Add(linkLabel1);
            panel_settings.Controls.Add(groupBox2);
            panel_settings.Controls.Add(groupBox1);
            panel_settings.Location = new System.Drawing.Point(0, 127);
            panel_settings.Name = "panel_settings";
            panel_settings.Size = new System.Drawing.Size(484, 375);
            panel_settings.TabIndex = 15;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            linkLabel1.LinkColor = System.Drawing.Color.Gray;
            linkLabel1.Location = new System.Drawing.Point(332, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(140, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "yazilimturkiye.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // groupBox2
            // 
            groupBox2.Location = new System.Drawing.Point(14, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(458, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new System.Drawing.Point(14, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(458, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label7.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label7.Location = new System.Drawing.Point(90, 52);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(364, 109);
            label7.TabIndex = 2;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label6.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label6.Location = new System.Drawing.Point(88, 23);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(179, 20);
            label6.TabIndex = 1;
            label6.Text = "DBConnector FREE v2.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(70, 70);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 502);
            Controls.Add(button_hakkinda);
            Controls.Add(progressBar_durum);
            Controls.Add(label_altbaslik);
            Controls.Add(label_baslik);
            Controls.Add(label_arkaplan);
            Controls.Add(panel_connector);
            Controls.Add(panel_settings);
            Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DBConnector";
            Load += Form1_Load;
            groupBox_veritabanituru.ResumeLayout(false);
            groupBox_veritabanituru.PerformLayout();
            groupBox_veritabanibaglanti.ResumeLayout(false);
            groupBox_veritabanibaglanti.PerformLayout();
            panel_connector.ResumeLayout(false);
            panel_settings.ResumeLayout(false);
            panel_settings.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Panel panel_connector;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

