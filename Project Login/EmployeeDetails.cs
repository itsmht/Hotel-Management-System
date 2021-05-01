using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Project_Login
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainManu().Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            var cEmployeeDetails = GetAllEmployee();
            dtEmployeeDetails.DataSource = cEmployeeDetails;
        }
        List<CEmployeeDetails> GetAllEmployee()
        {
            List<CEmployeeDetails> cEmployeeDetails = new List<CEmployeeDetails>();
            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from [user]";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CEmployeeDetails emp = new CEmployeeDetails();
                    emp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    emp.Name = reader.GetString(reader.GetOrdinal("Name"));
                    emp.Email = reader.GetString(reader.GetOrdinal("Email"));
                    emp.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    emp.DOB = reader.GetString(reader.GetOrdinal("DateOfBirth"));
                    emp.Username = reader.GetString(reader.GetOrdinal("Username"));
                    emp.Password = reader.GetString(reader.GetOrdinal("Password"));

                    cEmployeeDetails.Add(emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return cEmployeeDetails;
        }
    }
}
