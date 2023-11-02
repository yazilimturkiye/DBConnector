using System; //yazilimturkiye.com 02.11.2023
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnector
{
    public partial class DBConnector : Form
    {
        public DBConnector()
        {
            InitializeComponent();
        }

        private void DBConnector_Load(object sender, EventArgs e)
        {
            comboBox_veritabanituru.Items.Add("Oracle");
            comboBox_veritabanituru.Items.Add("PostgreSQL");
            comboBox_veritabanituru.Items.Add("Microsoft SQL Server");
            comboBox_veritabanituru.Items.Add("MySQL");
            comboBox_veritabanituru.SelectedIndex = 0;
        }
    }
}
