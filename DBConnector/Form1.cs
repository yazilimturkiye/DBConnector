using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; // Oracle Connection
using Npgsql; // PostgreSQL Connection
using Microsoft.Data.SqlClient; // Microsoft SQL Server Connection
using MySql.Data.MySqlClient;
using System.Diagnostics; // MySQL Connection

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

            //string connectionString_Oracle = @"DATA SOURCE = 10.1.5.19:1521/ORCL; USER ID = TMAGNKUR_AHMET; PASSWORD=Test12345";
            //string connectionString_Oracle = $"Data Source={sunucu};User Id={kullaniciadi};Password={sifre};";
            //string connectionString_Oracle = $"Data Source={sunucu};User Id={kullaniciadi};Password={sifre};Integrated Security=no;";
            string connectionString_Oracle = $"Connection Timeout = 10; Max Pool Size = 150;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={sunucu})(PORT={port}))(CONNECT_DATA=(SERVICE_NAME={veritabaniadi})));User ID={kullaniciadi};Password={sifre};";
            //string connectionString_Oracle = $"user id = {kullaniciadi}; password = {sifre}; Connection Timeout = 10; Max Pool Size = 150; data source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = {sunucu})(PORT = {port}))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = {veritabaniadi})))";
            //string connectionString_Oracle = $"Data Source=(DESCRIPTION =" + $"(ADDRESS = (PROTOCOL = TCP)(HOST = {sunucu})(PORT = {port}))" + $"(CONNECT_DATA =" + $"(SERVER = DEDICATED)" + $"(SERVICE_NAME = {veritabaniadi})));" + $"User Id={kullaniciadi};Password={sifre};";
            //string connectionString_Oracle = $"User Id={kullaniciadi};Password={sifre};Data Source={veritabaniadi};";
            OracleConnection connection = new OracleConnection(connectionString_Oracle);
            try
            {
                connection.Open();
                MessageBox.Show("Veritabanı Bağlantısı Başarıyla Sağlandı!", "Bağlantı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından Gelen Hata Detayı : " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Veritabanı Bağlantısı Başarıyla Sağlandı!", "Bağlantı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından Gelen Hata Detayı : " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string connectionString = $"Data Source={sunucu},{port};Initial Catalog={veritabaniadi};User Id={kullaniciadi};Password={sifre};";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Veritabanı Bağlantısı Başarıyla Sağlandı!", "Bağlantı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından Gelen Hata Detayı : " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string connectionString = $"Server={sunucu};Port={port};Database={veritabaniadi};User ID={kullaniciadi};Password={sifre};";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Veritabanı Bağlantısı Başarıyla Sağlandı!", "Bağlantı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından Gelen Hata Detayı : " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            timer_sayac.Stop();
        }

        private void comboBox1_veritabanituru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_veritabanituru.SelectedIndex == 0) // Eğer "seciniz" secili ise groupbox'u kilitle
            {
                groupBox_veritabanibaglanti.Enabled = false;
            }
            else // degilse ac
            {
                groupBox_veritabanibaglanti.Enabled = true;
            }
        }

        private void button_baglantibaslat_Click(object sender, EventArgs e)
        {
            progressBar_durum.Value = 0;
            button_baglantibaslat.Text = "Lütfen Bekleyiniz...";
            if (comboBox1_veritabanituru.SelectedIndex == 1) // Oracle Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
                timer_sayac.Start();
                Oracle_Connection_Metot();
            }
            if (comboBox1_veritabanituru.SelectedIndex == 2) // Microsoft SQL Server Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
                timer_sayac.Start();
                MicrosoftSQLServer_Connection_Metot();
            }
            if (comboBox1_veritabanituru.SelectedIndex == 3) // PostgreSQL Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
                timer_sayac.Start();
                Postgre_Connection_Metot();
            }
            if (comboBox1_veritabanituru.SelectedIndex == 4) // MySQL Connection
            {
                groupBox_veritabanibaglanti.Enabled = false;
                groupBox_veritabanituru.Enabled = false;
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
                button_baglantibaslat.Text = "Bağlantı Kur";
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
            if (checkBox_sifregoster.Checked == false)  // checkBox isaretli ise
            {
                textBox_sifre.PasswordChar = '*';
            }
            else   //degilse karakterlerin yerine * koy
            {
                textBox_sifre.PasswordChar = '\0';
            }
        }

        private void textBox_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_hakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DBConnector Veritabanı bağlantı kontrolcüsü, Windows işletim sistemleri üzerinden uygulama içerisinde ekle olan veritabanlarına bağlantı kontroü yapmanıza olanak sağlayan .NET ortamında geliştirilmiş açık kaynak bir yazılımdır. Destek ve daha fazla bilgi saihibi olmak için web sitemizi ziyaret edebilirsiniz. www.yazilimturkiye.com", "DBConnector Ücretsiz Sürümü Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
