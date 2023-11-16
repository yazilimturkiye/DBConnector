namespace DBConnector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label_arkaplan = new Label();
            label_baslik = new Label();
            label_altbaslik = new Label();
            label_versiyon = new Label();
            progressBar_durum = new ProgressBar();
            button_hakkinda = new Button();
            groupBox_veritabanituru = new GroupBox();
            comboBox1_veritabanituru = new ComboBox();
            label1 = new Label();
            groupBox_veritabanibaglanti = new GroupBox();
            checkBox_sifregoster = new CheckBox();
            textBox_sifre = new TextBox();
            textBox_port = new TextBox();
            textBox_sunucu = new TextBox();
            textBox_kullaniciadi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox_veritabaniadi = new TextBox();
            label2 = new Label();
            button_baglantibaslat = new Button();
            timer_sayac = new System.Windows.Forms.Timer(components);
            linkLabel1 = new LinkLabel();
            groupBox_veritabanituru.SuspendLayout();
            groupBox_veritabanibaglanti.SuspendLayout();
            SuspendLayout();
            // 
            // label_arkaplan
            // 
            label_arkaplan.BackColor = Color.White;
            label_arkaplan.Location = new Point(0, 1);
            label_arkaplan.Name = "label_arkaplan";
            label_arkaplan.Size = new Size(485, 137);
            label_arkaplan.TabIndex = 0;
            // 
            // label_baslik
            // 
            label_baslik.AutoSize = true;
            label_baslik.BackColor = Color.White;
            label_baslik.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_baslik.ForeColor = Color.SeaGreen;
            label_baslik.Location = new Point(14, 9);
            label_baslik.Name = "label_baslik";
            label_baslik.Size = new Size(282, 28);
            label_baslik.TabIndex = 1;
            label_baslik.Text = "VT Bağlantı Kontrolcüsü";
            // 
            // label_altbaslik
            // 
            label_altbaslik.AutoSize = true;
            label_altbaslik.BackColor = Color.White;
            label_altbaslik.Location = new Point(15, 42);
            label_altbaslik.Name = "label_altbaslik";
            label_altbaslik.Size = new Size(274, 21);
            label_altbaslik.TabIndex = 2;
            label_altbaslik.Text = "Veritabanı Bağlantısı Kontrol Aracı";
            // 
            // label_versiyon
            // 
            label_versiyon.AutoSize = true;
            label_versiyon.BackColor = Color.White;
            label_versiyon.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_versiyon.Location = new Point(291, 16);
            label_versiyon.Name = "label_versiyon";
            label_versiyon.Size = new Size(39, 20);
            label_versiyon.TabIndex = 3;
            label_versiyon.Text = "v1.0";
            // 
            // progressBar_durum
            // 
            progressBar_durum.Location = new Point(0, 138);
            progressBar_durum.Name = "progressBar_durum";
            progressBar_durum.Size = new Size(484, 8);
            progressBar_durum.TabIndex = 4;
            // 
            // button_hakkinda
            // 
            button_hakkinda.Location = new Point(19, 74);
            button_hakkinda.Name = "button_hakkinda";
            button_hakkinda.Size = new Size(50, 50);
            button_hakkinda.TabIndex = 5;
            button_hakkinda.UseVisualStyleBackColor = true;
            // 
            // groupBox_veritabanituru
            // 
            groupBox_veritabanituru.Controls.Add(comboBox1_veritabanituru);
            groupBox_veritabanituru.Controls.Add(label1);
            groupBox_veritabanituru.Location = new Point(12, 148);
            groupBox_veritabanituru.Name = "groupBox_veritabanituru";
            groupBox_veritabanituru.Size = new Size(460, 89);
            groupBox_veritabanituru.TabIndex = 9;
            groupBox_veritabanituru.TabStop = false;
            // 
            // comboBox1_veritabanituru
            // 
            comboBox1_veritabanituru.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_veritabanituru.FormattingEnabled = true;
            comboBox1_veritabanituru.Location = new Point(141, 34);
            comboBox1_veritabanituru.Name = "comboBox1_veritabanituru";
            comboBox1_veritabanituru.Size = new Size(303, 29);
            comboBox1_veritabanituru.TabIndex = 12;
            comboBox1_veritabanituru.SelectedIndexChanged += comboBox1_veritabanituru_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(7, 37);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 11;
            label1.Text = "Veritabanı Türü";
            // 
            // groupBox_veritabanibaglanti
            // 
            groupBox_veritabanibaglanti.Controls.Add(checkBox_sifregoster);
            groupBox_veritabanibaglanti.Controls.Add(textBox_sifre);
            groupBox_veritabanibaglanti.Controls.Add(textBox_port);
            groupBox_veritabanibaglanti.Controls.Add(textBox_sunucu);
            groupBox_veritabanibaglanti.Controls.Add(textBox_kullaniciadi);
            groupBox_veritabanibaglanti.Controls.Add(label5);
            groupBox_veritabanibaglanti.Controls.Add(label4);
            groupBox_veritabanibaglanti.Controls.Add(label3);
            groupBox_veritabanibaglanti.Controls.Add(textBox_veritabaniadi);
            groupBox_veritabanibaglanti.Controls.Add(label2);
            groupBox_veritabanibaglanti.Controls.Add(button_baglantibaslat);
            groupBox_veritabanibaglanti.Enabled = false;
            groupBox_veritabanibaglanti.Location = new Point(12, 236);
            groupBox_veritabanibaglanti.Name = "groupBox_veritabanibaglanti";
            groupBox_veritabanibaglanti.Size = new Size(460, 345);
            groupBox_veritabanibaglanti.TabIndex = 10;
            groupBox_veritabanibaglanti.TabStop = false;
            // 
            // checkBox_sifregoster
            // 
            checkBox_sifregoster.AutoSize = true;
            checkBox_sifregoster.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_sifregoster.Location = new Point(141, 227);
            checkBox_sifregoster.Name = "checkBox_sifregoster";
            checkBox_sifregoster.Size = new Size(122, 24);
            checkBox_sifregoster.TabIndex = 22;
            checkBox_sifregoster.Text = "Şifreyi Göster";
            checkBox_sifregoster.UseVisualStyleBackColor = true;
            checkBox_sifregoster.CheckedChanged += checkBox_sifregoster_CheckedChanged;
            // 
            // textBox_sifre
            // 
            textBox_sifre.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_sifre.Location = new Point(141, 190);
            textBox_sifre.Name = "textBox_sifre";
            textBox_sifre.PasswordChar = '*';
            textBox_sifre.Size = new Size(303, 31);
            textBox_sifre.TabIndex = 21;
            // 
            // textBox_port
            // 
            textBox_port.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_port.Location = new Point(363, 135);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(81, 31);
            textBox_port.TabIndex = 20;
            textBox_port.KeyPress += textBox_port_KeyPress;
            // 
            // textBox_sunucu
            // 
            textBox_sunucu.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_sunucu.Location = new Point(141, 135);
            textBox_sunucu.Name = "textBox_sunucu";
            textBox_sunucu.Size = new Size(216, 31);
            textBox_sunucu.TabIndex = 19;
            // 
            // textBox_kullaniciadi
            // 
            textBox_kullaniciadi.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_kullaniciadi.Location = new Point(141, 83);
            textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            textBox_kullaniciadi.Size = new Size(303, 31);
            textBox_kullaniciadi.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(94, 190);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 17;
            label5.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(21, 135);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 16;
            label4.Text = "Sunucu / Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(32, 83);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 15;
            label3.Text = "Kullanıcı Adı";
            // 
            // textBox_veritabaniadi
            // 
            textBox_veritabaniadi.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_veritabaniadi.Location = new Point(141, 31);
            textBox_veritabaniadi.Name = "textBox_veritabaniadi";
            textBox_veritabaniadi.Size = new Size(303, 31);
            textBox_veritabaniadi.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 13;
            label2.Text = "Veritabanı Adı";
            // 
            // button_baglantibaslat
            // 
            button_baglantibaslat.Location = new Point(16, 269);
            button_baglantibaslat.Name = "button_baglantibaslat";
            button_baglantibaslat.Size = new Size(428, 60);
            button_baglantibaslat.TabIndex = 11;
            button_baglantibaslat.Text = "Bağlantı Kur";
            button_baglantibaslat.UseVisualStyleBackColor = true;
            button_baglantibaslat.Click += button_baglantibaslat_Click;
            // 
            // timer_sayac
            // 
            timer_sayac.Enabled = true;
            timer_sayac.Interval = 20;
            timer_sayac.Tick += timer_sayac_Tick;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.SeaGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(322, 584);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(150, 21);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "yazilimturkiye.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 611);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox_veritabanibaglanti);
            Controls.Add(groupBox_veritabanituru);
            Controls.Add(button_hakkinda);
            Controls.Add(progressBar_durum);
            Controls.Add(label_versiyon);
            Controls.Add(label_altbaslik);
            Controls.Add(label_baslik);
            Controls.Add(label_arkaplan);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DBConnector";
            Load += Form1_Load;
            groupBox_veritabanituru.ResumeLayout(false);
            groupBox_veritabanituru.PerformLayout();
            groupBox_veritabanibaglanti.ResumeLayout(false);
            groupBox_veritabanibaglanti.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_arkaplan;
        private Label label_baslik;
        private Label label_altbaslik;
        private Label label_versiyon;
        private ProgressBar progressBar_durum;
        private Button button_hakkinda;
        private GroupBox groupBox_veritabanituru;
        private GroupBox groupBox_veritabanibaglanti;
        private Button button_baglantibaslat;
        private ComboBox comboBox1_veritabanituru;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox textBox_veritabaniadi;
        private Label label2;
        private CheckBox checkBox_sifregoster;
        private TextBox textBox_sifre;
        private TextBox textBox_port;
        private TextBox textBox_sunucu;
        private TextBox textBox_kullaniciadi;
        private Label label5;
        private System.Windows.Forms.Timer timer_sayac;
        private LinkLabel linkLabel1;
    }
}