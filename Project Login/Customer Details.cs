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
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void Customer_Details_Load(object sender, EventArgs e)
        {
            List<CCustomerDetails> cCustomerDetails = new List<CCustomerDetails>();
            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from guest";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CCustomerDetails cd = new CCustomerDetails();
                    cd.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    cd.Name = reader.GetString(reader.GetOrdinal("Name"));
                    cd.Address = reader.GetString(reader.GetOrdinal("Address"));
                    cd.ContactNo = reader.GetString(reader.GetOrdinal("ContactNo"));
                    cd.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    //cd.DOB = reader.GetString(reader.GetOrdinal("DOB"));
                    cd.Email = reader.GetString(reader.GetOrdinal("Email"));
                    cd.Bed = reader.GetString(reader.GetOrdinal("Bed"));
                    cd.RoomType = reader.GetString(reader.GetOrdinal("RoomType"));
                    cd.RoomNo = reader.GetString(reader.GetOrdinal("RoomNo"));
                    cd.CheckIn = reader.GetString(reader.GetOrdinal("CheckIn"));
                    cd.Price = reader.GetString(reader.GetOrdinal("Price"));
                    
                    cCustomerDetails.Add(cd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            dtCustomerDetails.DataSource = cCustomerDetails;
        }
    }
}
