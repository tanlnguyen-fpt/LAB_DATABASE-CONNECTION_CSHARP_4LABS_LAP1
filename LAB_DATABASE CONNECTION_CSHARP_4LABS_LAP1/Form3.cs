using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings:MyStoreDB"];
        }

        SqlConnection conn = null;
        private void btnViewListOfStudent_Click(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new($"SELECT * FROM Student WHERE ClassID='{txtEnterClassID.Text}'", conn);
            
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem item = new(studentID);

                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lsvStudents.Items.Add(item);
            }
            conn.Close();
        }

        private void btnViewInDetail_Click(object sender, EventArgs e)
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            txtYear.Text = "";

            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new($"SELECT * FROM Class WHERE ClassID='{txtEnterClassID.Text}'", conn);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                txtClassID.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();
            }
            conn.Close();
        }
    }
}
