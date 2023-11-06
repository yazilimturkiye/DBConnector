using Oracle.ManagedDataAccess.Client; // Oracle Connection
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Npgsql; // PostgreSQL

namespace DBConnector //06.11.2023 yazilimturkiye.com
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
                MessageBox.Show("Baðlantý baþarýyla gerçekleþtirilmiþtir.", "Baðlantý Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata detayý : " + ex.Message, "Baðlantý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (comboBox1_veritabanituru.SelectedIndex == 0)
            {
                groupBox_veritabanibaglanti.Enabled = false;
            }
            else
            {
                groupBox_veritabanibaglanti.Enabled = true;
            }
        }

        private void button_baglantibaslat_Click(object sender, EventArgs e)
        {

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

            }
            if (comboBox1_veritabanituru.SelectedIndex == 3) // PostgreSQL Connection
            {

            }
            if (comboBox1_veritabanituru.SelectedIndex == 4) // MySQL Connection
            {

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
    }
}