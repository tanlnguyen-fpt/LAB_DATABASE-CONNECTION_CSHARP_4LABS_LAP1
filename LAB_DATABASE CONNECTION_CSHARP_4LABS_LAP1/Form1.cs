using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings:MyStoreDB"];
        }

        SqlConnection conn = null;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new(GetConnectionString());
                conn.Open();
                MessageBox.Show("Successful connection!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to connect to server \n" + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Successful Disconnection!!!");
            }
        }
    }
}
