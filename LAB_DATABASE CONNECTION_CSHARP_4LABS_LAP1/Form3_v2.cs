using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP1
{
    public partial class Form3_v2 : Form
    {
        public Form3_v2()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings:MyStoreDB"];
        }

        SqlConnection conn = null;

        private void Form3_v2_Load(object sender, EventArgs e)
        {
            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new("SELECT * FROM Class", conn);

            lsbClass.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classID = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = classID + "-" + className + "-" + year.ToString();
                lsbClass.Items.Add(line);
            }
            conn.Close();
        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (lsbClass.SelectedIndex == -1) return;
            string line = lsbClass.SelectedItem.ToString();
            string[] array = line.Split("-");
            string classID = array[0];

            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new($"SELECT * FROM Student WHERE ClassID='{classID}'", conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                ListViewItem item = new(studentID);

                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lsvStudents.Items.Add(item);
            }
            conn.Close();
        }
    }
}
