using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings:MyStoreDB"];
        }

        SqlConnection conn = null;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new(GetConnectionString());
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new($"SELECT COUNT(*) FROM STUDENT WHERE ClassID = '{txtClassId.Text}'", conn);
            int result = (int)command.ExecuteScalar();
            txtResult.Text = result.ToString();
            conn.Close();
        }
    }
}
