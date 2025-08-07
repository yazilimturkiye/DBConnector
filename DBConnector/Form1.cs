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
using MySqlConnector; // MySQL Connection
using System.Diagnostics;

namespace DBConnector // 06.11.2023 yazilimturkiye.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Oracle_Connection_Metot()
        {
            RichTextBox_Logs.Clear();
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString_Oracle =
                $"Connection Timeout=10;Max Pool Size=150;" +
                $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={sunucu})(PORT={port}))(CONNECT_DATA=(SERVICE_NAME={veritabaniadi})));User ID={kullaniciadi};Password={sifre};";

            using (OracleConnection connection = new OracleConnection(connectionString_Oracle))
            {
                Stopwatch sw = Stopwatch.StartNew();
                bool success = false;
                string errorMessage = "";

                try
                {
                    connection.Open();
                    success = true;
                    MessageBox.Show("Database Connection Successful!", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    success = false;
                    errorMessage = ex.Message;
                    MessageBox.Show("Database Connection Failed!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Stop();
                    connection.Close();
                    ShowConnectionResult(
                        success,
                        "Oracle",
                        sw.Elapsed.TotalSeconds,
                        errorMessage,
                        sunucu,
                        port,
                        veritabaniadi,
                        kullaniciadi
                    );
                    groupBox_veritabanibaglanti.Enabled = true;
                    groupBox_veritabanituru.Enabled = true;
                }
            }
        }
        public void Postgre_Connection_Metot()
        {
            RichTextBox_Logs.Clear();
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString = $"Host={sunucu};Port={port};Username={kullaniciadi};Password={sifre};Database={veritabaniadi};";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                Stopwatch sw = Stopwatch.StartNew();
                bool success = false;
                string errorMessage = "";

                try
                {
                    connection.Open();
                    success = true;
                    MessageBox.Show("Database Connection Successful!", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    success = false;
                    errorMessage = ex.Message;
                    MessageBox.Show("Database Connection Failed!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Stop();
                    connection.Close();
                    ShowConnectionResult(
                        success,
                        "PostgreSQL",
                        sw.Elapsed.TotalSeconds,
                        errorMessage,
                        sunucu,
                        port,
                        veritabaniadi,
                        kullaniciadi
                    );
                    groupBox_veritabanibaglanti.Enabled = true;
                    groupBox_veritabanituru.Enabled = true;
                }
            }
        }
        public void MicrosoftSQLServer_Connection_Metot()
        {
            RichTextBox_Logs.Clear();
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString = $"Data Source={sunucu},{port};Initial Catalog={veritabaniadi};User Id={kullaniciadi};Password={sifre};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Stopwatch sw = Stopwatch.StartNew();
                bool success = false;
                string errorMessage = "";

                try
                {
                    connection.Open();
                    success = true;
                    MessageBox.Show("Database Connection Successful!", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    success = false;
                    errorMessage = ex.Message;
                    MessageBox.Show("Database Connection Failed!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Stop();
                    // connection.Close(); // using bloğu otomatik kapatıyor, gerek yok
                    ShowConnectionResult(
                        success,
                        "Microsoft SQL Server",
                        sw.Elapsed.TotalSeconds,
                        errorMessage,
                        sunucu,
                        port,
                        veritabaniadi,
                        kullaniciadi
                    );
                    groupBox_veritabanibaglanti.Enabled = true;
                    groupBox_veritabanituru.Enabled = true;
                }
            }
        }
        public void MySQL_Connection_Metot()
        {
            RichTextBox_Logs.Clear();
            string veritabaniadi = textBox_veritabaniadi.Text;
            string kullaniciadi = textBox_kullaniciadi.Text;
            string sunucu = textBox_sunucu.Text;
            string port = textBox_port.Text;
            string sifre = textBox_sifre.Text;

            string connectionString = $"Server={sunucu};Port={port};Database={veritabaniadi};User ID={kullaniciadi};Password={sifre};";

            using (var connection = new MySqlConnector.MySqlConnection(connectionString))
            {
                Stopwatch sw = Stopwatch.StartNew();
                bool success = false;
                string errorMessage = "";

                try
                {
                    connection.Open();
                    success = true;
                    MessageBox.Show("Database Connection Successful!", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    success = false;
                    errorMessage = ex.Message;
                    MessageBox.Show("Database Connection Failed!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Stop();
                    ShowConnectionResult(
                        success,
                        "MySQL",
                        sw.Elapsed.TotalSeconds,
                        errorMessage,
                        sunucu,
                        port,
                        veritabaniadi,
                        kullaniciadi
                    );
                    groupBox_veritabanibaglanti.Enabled = true;
                    groupBox_veritabanituru.Enabled = true;
                }
            }
        }
        void ShowConnectionResult(bool success, string dbType, double durationSec, string errorMessage = "", string serverIp = "", string port = "", string dbName = "", string username = "")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Timestamp\t\t: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"Database Type\t: {dbType}");
            sb.AppendLine($"Database Name\t: {(!string.IsNullOrWhiteSpace(dbName) ? dbName : "N/A")}");
            sb.AppendLine($"Server / Port\t: {(string.IsNullOrWhiteSpace(serverIp) ? "N/A" : serverIp)}:{(string.IsNullOrWhiteSpace(port) ? "N/A" : port)}");
            sb.AppendLine($"User Name\t\t: {(string.IsNullOrWhiteSpace(username) ? "N/A" : username)}");
            sb.AppendLine($"Connection Time\t: {durationSec:F3} seconds");

            if (success)
                sb.AppendLine("Status\t\t: Connection Successful");
            else
            {
                sb.AppendLine("Status\t\t: Connection Failed");
                sb.AppendLine($"Error Message\t: {errorMessage}");
            }

            if (RichTextBox_Logs.InvokeRequired)
            {
                RichTextBox_Logs.Invoke(new Action(() =>
                {
                    RichTextBox_Logs.AppendText(sb.ToString() + Environment.NewLine);
                }));
            }
            else
            {
                RichTextBox_Logs.AppendText(sb.ToString() + Environment.NewLine);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1_veritabanituru.Items.Add("Select...");           // SelectedIndex = 0
            comboBox1_veritabanituru.Items.Add("Oracle Database");      // SelectedIndex = 1
            comboBox1_veritabanituru.Items.Add("Microsoft SQL Server"); // SelectedIndex = 2
            comboBox1_veritabanituru.Items.Add("PostgreSQL");           // SelectedIndex = 3
            comboBox1_veritabanituru.Items.Add("MySQL");                // SelectedIndex = 4
            comboBox1_veritabanituru.SelectedIndex = 0;
        }

        private void comboBox1_veritabanituru_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox_veritabanibaglanti.Enabled = comboBox1_veritabanituru.SelectedIndex != 0;

            switch (comboBox1_veritabanituru.SelectedIndex)
            {
                case 0: // "Seçiniz"
                    textBox_port.Clear();
                    textBox_port.Tag = null;
                    break;
                case 1: // Oracle
                    textBox_port.Text = "1521";
                    textBox_port.Tag = "auto";
                    break;
                case 2: // MSSQL
                    textBox_port.Text = "1433";
                    textBox_port.Tag = "auto";
                    break;
                case 3: // PostgreSQL
                    textBox_port.Text = "5432";
                    textBox_port.Tag = "auto";
                    break;
                case 4: // MySQL
                    textBox_port.Text = "3306";
                    textBox_port.Tag = "auto";
                    break;
            }
        }

        private void button_baglantibaslat_Click(object sender, EventArgs e)
        {
            // Eğer herhangi bir textbox boşsa veya port otomatik ve kullanıcı değiştirmemişse engelle
            if (string.IsNullOrWhiteSpace(textBox_veritabaniadi.Text) ||
                string.IsNullOrWhiteSpace(textBox_kullaniciadi.Text) ||
                string.IsNullOrWhiteSpace(textBox_sunucu.Text) ||
                string.IsNullOrWhiteSpace(textBox_port.Text) ||
                string.IsNullOrWhiteSpace(textBox_sifre.Text))
            {
                MessageBox.Show("Please fill all blank spaces!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // bağlantı metodu çağrılmaz, çıkılır
            }

            button_baglantibaslat.Text = "Please Wait...";
            groupBox_veritabanibaglanti.Enabled = false;
            groupBox_veritabanituru.Enabled = false;

            if (comboBox1_veritabanituru.SelectedIndex == 1) // Oracle Connection
            {
                Oracle_Connection_Metot();
            }
            else if (comboBox1_veritabanituru.SelectedIndex == 2) // Microsoft SQL Server Connection
            {
                MicrosoftSQLServer_Connection_Metot();
            }
            else if (comboBox1_veritabanituru.SelectedIndex == 3) // PostgreSQL Connection
            {
                Postgre_Connection_Metot();
            }
            else if (comboBox1_veritabanituru.SelectedIndex == 4) // MySQL Connection
            {
                MySQL_Connection_Metot();
            }
            else
            {
                MessageBox.Show("Please select a database type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBox_veritabanibaglanti.Enabled = true;
                groupBox_veritabanituru.Enabled = true;
                button_baglantibaslat.Text = "Connect Database";
                return;
            }

            button_baglantibaslat.Text = "Connect Database";
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
            MessageBox.Show(
                "DBConnector is a free and open-source tool for connecting databases.\n\n" +
                "Built on the .NET platform, it helps users for control and connect our databases.\n\n" +
                "© 2021 yazilimturkiye.com – All rights reserved.\n\n" +
                "Visit our website for updates and support.\n\n" +
                "Version: 3.0",
                "About DBConnector",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process sayfa_ac = new Process();
            sayfa_ac.StartInfo.UseShellExecute = true;
            sayfa_ac.StartInfo.FileName = "https://www.yazilimturkiye.com/";
            sayfa_ac.Start();
        }
    }
}
