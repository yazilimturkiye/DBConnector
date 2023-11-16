using Oracle.ManagedDataAccess.Client; // Oracle Connection
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Npgsql; // PostgreSQL Connection
using Microsoft.Data.SqlClient; // Microsoft SQL Server Connection
using MySql.Data.MySqlClient; // MySQL Connection

namespace DBConnector // 06.11.2023 yazilimturkiye.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Oracle_Connection_Metot() // Oracle Connection
        {
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString_Oracle = $"User Id={kullaniciadi};Password={sifre};Data Source={veritabaniadi};";
            OracleConnection connection = new OracleConnection(connectionString_Oracle);

            try
            {
                connection.Open();
                MessageBox.Show("Veritabanýna Baðlantý Baþarýyla Saðlandý!", "Baðlantý Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanýndan Gelen Hata detayý : " + ex.Message, "Baðlantý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Postgre_Connection_Metot()  // Postgre Connection
        {
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString = $"Host={sunucu};Port={port};Username={kullaniciadi};Password={sifre};Database={veritabaniadi};";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Veritabanýna Baðlantý Baþarýyla Saðlandý!", "Baðlantý Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanýndan Gelen Hata detayý : " + ex.Message, "Baðlantý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public void MicrosoftSQLServer_Connection_Metot() // MicrosoftSQL Connection
        {
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString = $"Data Source={sunucu};Initial Catalog={veritabaniadi};User Id={kullaniciadi};Password={sifre};";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Veritabanýna Baðlantý Baþarýyla Saðlandý!", "Baðlantý Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanýndan Gelen Hata detayý : " + ex.Message, "Baðlantý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public void MySQL_Connection_Metot()
        {
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString = $"Server={sunucu};Database={veritabaniadi};User ID={kullaniciadi};Password={sifre};";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Veritabanýna Baðlantý Baþarýyla Saðlandý!", "Baðlantý Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanýndan Gelen Hata detayý : " + ex.Message, "Baðlantý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1_veritabanituru.Items.Add("Seçiniz...");           // SelectedIndex = 0
            comboBox1_veritabanituru.Items.Add("Oracle Database");      // SelectedIndex = 1
            comboBox1_veritabanituru.Items.Add("Microsoft SQL Server"); // SelectedIndex = 2
            comboBox1_veritabanituru.Items.Add("PostgreSQL");           // SelectedIndex = 3
            comboBox1_veritabanituru.Items.Add("MySQL");                // SelectedIndex = 4
            comboBox1_veritabanituru.SelectedIndex = 0;

            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            timer_sayac.Stop();
        }

        private void comboBox1_veritabanituru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_veritabanituru.SelectedIndex == 0) // Eðer "seçiniz" seçili ise groupbox'u kilitle
            {
                groupBox_veritabanibaglanti.Enabled = false;
            }
            else // deðilse aç
            {
                groupBox_veritabanibaglanti.Enabled = true;
            }
        }

        private void button_baglantibaslat_Click(object sender, EventArgs e)
        {
            progressBar_durum.Value = 0;
            if (comboBox1_veritabanituru.SelectedIndex == 1) // Oracle Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
                button_baglantibaslat.Text = "Lütfen Bekleyiniz...";
                timer_sayac.Start();
                Oracle_Connection_Metot();
            }
            if (comboBox1_veritabanituru.SelectedIndex == 2) // Microsoft SQL Server Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
                button_baglantibaslat.Text = "Lütfen Bekleyiniz...";
                timer_sayac.Start();
                MicrosoftSQLServer_Connection_Metot();
            }
            if (comboBox1_veritabanituru.SelectedIndex == 3) // PostgreSQL Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
                button_baglantibaslat.Text = "Lütfen Bekleyiniz...";
                timer_sayac.Start();
                Postgre_Connection_Metot();
            }
            if (comboBox1_veritabanituru.SelectedIndex == 4) // MySQL Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
                button_baglantibaslat.Text = "Lütfen Bekleyiniz...";
                timer_sayac.Start();
                MySQL_Connection_Metot();
            }
        }

        private void timer_sayac_Tick(object sender, EventArgs e)
        {
            if (progressBar_durum.Value == 100)
            {
                timer_sayac.Stop();
                groupBox_veritabanituru.Enabled = true;
                groupBox_veritabanibaglanti.Enabled = true;
                button_baglantibaslat.Text = "Baðlantý Kur";
            }
            else
            {
                progressBar_durum.Value++;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process sayfa_ac = new Process();
            sayfa_ac.StartInfo.UseShellExecute = true;
            sayfa_ac.StartInfo.FileName = "https://www.yazilimturkiye.com/";
            sayfa_ac.Start();
        }

        private void checkBox_sifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sifregoster.Checked == false)  // checkBox iþaretli ise
            {
                textBox_sifre.PasswordChar = '*';
            }
            else   //deðilse karakterlerin yerine * koy
            {
                textBox_sifre.PasswordChar = '\0';
            }
        }

        private void textBox_port_KeyPress(object sender, KeyPressEventArgs e) // textBox_port sadece sayý giriþi yapma
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}