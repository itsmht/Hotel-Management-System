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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainManu().Show();
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {

            
            var conn = Database.ConnectDB();

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int id = Int32.Parse(tbSearchID.Text);
            string query = "select * from [guest] where id =  " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            CCustomerDetails c = new CCustomerDetails();
            while(reader.Read())
            {
                
                c.Name = reader.GetString(reader.GetOrdinal("Name"));
                
                c.RoomNo = reader.GetString(reader.GetOrdinal("RoomNo"));
                
            }
            tbSearchedName.Text = c.Name;
            tbSearchedRoomNo.Text = c.RoomNo;
            conn.Close();
            




        }

      

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //int id = Int32.Parse(tbSearchID.Text);
            //string query = "delete * from guest where id =  " + id;
            string query = "DELETE FROM guest WHERE id = '"+tbSearchID.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Checkout Success!!");
            conn.Close();
            var cCustomerDetails = GetAllCustomer();
            dtGuestCheckOut.DataSource = cCustomerDetails;

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            var cCustomerDetails = GetAllCustomer();
            dtGuestCheckOut.DataSource = cCustomerDetails;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        List<CCustomerDetails> GetAllCustomer()
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
                    cd.DOB = reader.GetString(reader.GetOrdinal("DateOfBirth"));
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
            return cCustomerDetails;
        }
    }
}
