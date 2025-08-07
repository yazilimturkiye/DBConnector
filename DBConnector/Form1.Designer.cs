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
            button_hakkinda = new System.Windows.Forms.Button();
            ımageList1 = new System.Windows.Forms.ImageList(components);
            groupBox_veritabanituru = new System.Windows.Forms.GroupBox();
            comboBox1_veritabanituru = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            groupBox_veritabanibaglanti = new System.Windows.Forms.GroupBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            panel_connector = new System.Windows.Forms.Panel();
            panel_settings = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            RichTextBox_Logs = new System.Windows.Forms.RichTextBox();
            groupBox_veritabanituru.SuspendLayout();
            groupBox_veritabanibaglanti.SuspendLayout();
            panel_connector.SuspendLayout();
            panel_settings.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label_arkaplan
            // 
            label_arkaplan.BackColor = System.Drawing.SystemColors.ControlLight;
            label_arkaplan.Location = new System.Drawing.Point(0, 0);
            label_arkaplan.Name = "label_arkaplan";
            label_arkaplan.Size = new System.Drawing.Size(1054, 73);
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
            label_altbaslik.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label_altbaslik.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_altbaslik.Location = new System.Drawing.Point(8, 36);
            label_altbaslik.Name = "label_altbaslik";
            label_altbaslik.Size = new System.Drawing.Size(328, 20);
            label_altbaslik.TabIndex = 12;
            label_altbaslik.Text = "Database Connection Checker Application\r\n";
            // 
            // button_hakkinda
            // 
            button_hakkinda.ImageIndex = 0;
            button_hakkinda.ImageList = ımageList1;
            button_hakkinda.Location = new System.Drawing.Point(999, 16);
            button_hakkinda.Name = "button_hakkinda";
            button_hakkinda.Size = new System.Drawing.Size(40, 40);
            button_hakkinda.TabIndex = 9;
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
            groupBox_veritabanituru.Size = new System.Drawing.Size(502, 69);
            groupBox_veritabanituru.TabIndex = 6;
            groupBox_veritabanituru.TabStop = false;
            // 
            // comboBox1_veritabanituru
            // 
            comboBox1_veritabanituru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1_veritabanituru.FormattingEnabled = true;
            comboBox1_veritabanituru.Location = new System.Drawing.Point(157, 24);
            comboBox1_veritabanituru.Name = "comboBox1_veritabanituru";
            comboBox1_veritabanituru.Size = new System.Drawing.Size(329, 29);
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
            groupBox_veritabanibaglanti.Controls.Add(linkLabel1);
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
            groupBox_veritabanibaglanti.Size = new System.Drawing.Size(502, 300);
            groupBox_veritabanibaglanti.TabIndex = 7;
            groupBox_veritabanibaglanti.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            linkLabel1.LinkColor = System.Drawing.Color.Gray;
            linkLabel1.Location = new System.Drawing.Point(369, 273);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(126, 17);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "yazilimturkiye.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // button_baglantibaslat
            // 
            button_baglantibaslat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            button_baglantibaslat.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button_baglantibaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button_baglantibaslat.ImageIndex = 1;
            button_baglantibaslat.ImageList = ımageList1;
            button_baglantibaslat.Location = new System.Drawing.Point(157, 211);
            button_baglantibaslat.Name = "button_baglantibaslat";
            button_baglantibaslat.Size = new System.Drawing.Size(329, 52);
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
            textBox_sifre.Size = new System.Drawing.Size(329, 31);
            textBox_sifre.TabIndex = 5;
            // 
            // textBox_port
            // 
            textBox_port.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_port.Location = new System.Drawing.Point(405, 95);
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
            textBox_sunucu.Size = new System.Drawing.Size(242, 31);
            textBox_sunucu.TabIndex = 3;
            // 
            // textBox_kullaniciadi
            // 
            textBox_kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_kullaniciadi.Location = new System.Drawing.Point(157, 58);
            textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            textBox_kullaniciadi.Size = new System.Drawing.Size(329, 31);
            textBox_kullaniciadi.TabIndex = 2;
            // 
            // textBox_veritabaniadi
            // 
            textBox_veritabaniadi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox_veritabaniadi.Location = new System.Drawing.Point(157, 21);
            textBox_veritabaniadi.Name = "textBox_veritabaniadi";
            textBox_veritabaniadi.Size = new System.Drawing.Size(329, 31);
            textBox_veritabaniadi.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label5.Location = new System.Drawing.Point(10, 136);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 21);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label4.Location = new System.Drawing.Point(10, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 21);
            label4.TabIndex = 4;
            label4.Text = "Server / Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label3.Location = new System.Drawing.Point(10, 62);
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
            // panel_connector
            // 
            panel_connector.Controls.Add(groupBox_veritabanituru);
            panel_connector.Controls.Add(groupBox_veritabanibaglanti);
            panel_connector.Location = new System.Drawing.Point(1, 73);
            panel_connector.Name = "panel_connector";
            panel_connector.Size = new System.Drawing.Size(526, 385);
            panel_connector.TabIndex = 14;
            // 
            // panel_settings
            // 
            panel_settings.Controls.Add(groupBox1);
            panel_settings.Location = new System.Drawing.Point(528, 73);
            panel_settings.Name = "panel_settings";
            panel_settings.Size = new System.Drawing.Size(526, 385);
            panel_settings.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(RichTextBox_Logs);
            groupBox1.Location = new System.Drawing.Point(14, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(497, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label6.Location = new System.Drawing.Point(160, 26);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(185, 21);
            label6.TabIndex = 9;
            label6.Text = "Connection Result Log";
            // 
            // RichTextBox_Logs
            // 
            RichTextBox_Logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            RichTextBox_Logs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            RichTextBox_Logs.Location = new System.Drawing.Point(17, 68);
            RichTextBox_Logs.Name = "RichTextBox_Logs";
            RichTextBox_Logs.Size = new System.Drawing.Size(467, 283);
            RichTextBox_Logs.TabIndex = 8;
            RichTextBox_Logs.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1055, 458);
            Controls.Add(button_hakkinda);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_arkaplan;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.Label label_altbaslik;
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
        private System.Windows.Forms.Panel panel_connector;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox RichTextBox_Logs;
        private System.Windows.Forms.Label label6;
    }
}

