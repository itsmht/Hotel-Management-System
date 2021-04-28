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
    public partial class Add_Room : Form
    {
        public Add_Room()
        {
            InitializeComponent();
        }

        
        
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = tbRoomNumber.Text;
            string roomType = cbRoomType.Text.ToString();
            string bedType = cbBedType.Text.ToString();
            string price = tbPrice.Text;
            //Exceptrions

            if (roomNumber == string.Empty && roomType == string.Empty && bedType == string.Empty && price == string.Empty)
            {
                MessageBox.Show("Please fill up the required fields!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            //Database
            else
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
                string query = string.Format("insert into [room] values ('{0}','{1}','{2}','{3}')", roomNumber, roomType, bedType, price);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Room Added");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add Room");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();


                


            }
        }
      
        private void btnBBM_Click(object sender, EventArgs e)
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Room> room = new List<Room>();
            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from room";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room r = new Room();
                    r.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    r.RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber"));
                    r.RoomType = reader.GetString(reader.GetOrdinal("RoomType"));
                    r.BedType = reader.GetString(reader.GetOrdinal("BedType"));
                    r.Price = reader.GetString(reader.GetOrdinal("Price"));

                    room.Add(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            dtAddRoom.DataSource = room;
        }
    }
}
