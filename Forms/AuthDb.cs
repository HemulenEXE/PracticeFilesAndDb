using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImportExpornInDB;
using ImportExpornInDB.DBLogic;
using Npgsql;

namespace PracticeFilesAndDB.Forms
{
    public partial class AuthDb : Form
    {
        public AuthDb()
        {
            InitializeComponent();
            boxConnect.Text = ConnectionSettingsManager.GetStringConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectString = boxConnect.Text;
                NpgsqlConnection conn = new NpgsqlConnection(connectString);
                conn.Open();
                ConnectionSettingsManager.SetUserConnections(connectString, connectString);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Стороняя ошибка: " + ex.ToString());
            }
        }

        private void AuthDb_Load(object sender, EventArgs e)
        {

        }
    }
}
