using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP1
{
    public partial class Form1_v2 : Form
    {
        public Form1_v2()
        {
            InitializeComponent();
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings:MyStoreDB"];
        }

        SqlConnection conn = null;
        private void Form1_v2_Load(object sender, EventArgs e)
        {
            ViewListOfStudents();
        }

        private void ViewListOfStudents()
        {
            lvwStudent.Items.Clear();
            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new("SELECT * FROM Student", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malop = reader.GetString(2);
                ListViewItem item = lvwStudent.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malop);
            }
            conn.Close();
        }

        int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "INSERT INTO Student(StudentID, Name, ClassID) values(@StudentID, @Name, @ClassID)";
            SqlParameter parameter1 = new("@StudentID", txtStudentID.Text);
            SqlParameter parameter2 = new("@Name", txtFullname.Text);
            SqlParameter parameter3 = new("@ClassID", txtClassID.Text);
            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n Insert a record failed!!!");
            }

            if (result > 0)
            {
                ViewListOfStudents();
            }
        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStudent.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lvwStudent.SelectedItems[0].SubItems[0].Text;
                txtFullname.Text = lvwStudent.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lvwStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "UPDATE Student SET Name = @Name, ClassID = @ClassID WHERE StudentID=@StudentID";
            SqlParameter parameter1 = new("@StudentID", txtStudentID.Text);
            SqlParameter parameter2 = new("@Name", txtFullname.Text);
            SqlParameter parameter3 = new("@ClassID", txtClassID.Text);
            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n Update a record failed!!!");
            }

            if (result > 0)
            {
                ViewListOfStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new(GetConnectionString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "DELETE FROM Student WHERE StudentID=@StudentID";
            SqlParameter parameter1 = new("@StudentID", txtStudentID.Text);
            command.Parameters.Add(parameter1);
     
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n Delete a record failed!!!");
            }

            if (result > 0)
            {
                ViewListOfStudents();
            }
        }
    }
}
