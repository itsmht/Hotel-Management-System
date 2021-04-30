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
    public partial class Customer_Service : Form
    {
        public Customer_Service()
        {
            InitializeComponent();
        }

      public void setComboBox(ComboBox combo)
        {
            string bed = cbBed.Text.ToString();
            string RoomType = cbRoomType.Text.ToString();
           var conn = Database.ConnectDB(); 
           try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           string query = String.Format("SELECT RoomNumber FROM room WHERE BedType='{0}' and RoomType='{1}' ", bed, RoomType);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   for(int i=0;i<reader.FieldCount;i++)
                   {
                       combo.Items.Add(reader.GetString(i));
                   }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
           
        }
      
      private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
      {
          cbRoomNo.Items.Clear();
          setComboBox(cbRoomNo);
          
      }

      protected override void OnFormClosing(FormClosingEventArgs e)
      {
          base.OnFormClosing(e);
          if (e.CloseReason != CloseReason.WindowsShutDown)
              Application.Exit();
      }

      private void cbBed_SelectedIndexChanged(object sender, EventArgs e)
      {
          cbRoomType.SelectedIndex = -1;
          cbRoomNo.Items.Clear();
      }

      private void cbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
      {
          string RoomNo = cbRoomNo.Text.ToString();
          
        
          var conn = Database.ConnectDB();
          try
          {
              conn.Open();
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
          string query = String.Format("SELECT Price FROM room WHERE RoomNumber='{0}' ", RoomNo);
          try
          {
              SqlCommand cmd = new SqlCommand(query, conn);
              SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
              {
                  Room r = new Room();
                  r.Price = reader.GetString(reader.GetOrdinal("Price"));
                  tbPrice.Text = r.Price;
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
          conn.Close();

          //cbRoomNo.Items.Clear();
      }

      private void btnSubmit_Click(object sender, EventArgs e)
      {
          string name = tbName.Text;
          string address = rtbAddress.Text.ToString();
          string contactNo = tbContactNo.Text;
          string gender = CbGender.Text.ToString();
          string dob = dtpDOB.Text.ToString();
          string email = tbEmail.Text;
          string bed = cbBed.Text.ToString();
          string roomType = cbRoomType.Text.ToString();
          string roomNumber = cbRoomNo.Text.ToString();
          string checkIn = dtpCheckIn.Text.ToString();
          string price = tbPrice.Text;
          //exception
          if (name == string.Empty || address == string.Empty || contactNo == string.Empty || gender == string.Empty || dob == string.Empty || email == string.Empty || roomNumber == string.Empty || roomType == string.Empty || bed == string.Empty || price == string.Empty ||checkIn == string.Empty )
          {
              MessageBox.Show("Please fill up the required fields!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
              //database
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
              string query = string.Format("insert into guest values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", name, address, contactNo, gender, dob, email, bed, roomType, roomNumber, checkIn,price);
              try
              {
                  SqlCommand cmd = new SqlCommand(query, conn);
                  int r = cmd.ExecuteNonQuery();
                  if (r > 0)
                  {
                      MessageBox.Show("Room Allocated Succesfully");
                      
                  }
                  else
                  {
                      MessageBox.Show("Failed to Allocate Room");
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
        /*  protected override void OnFormClosing(FormClosingEventArgs e)
        {
             base.OnFormClosing(e);
             if (e.CloseReason != CloseReason.WindowsShutDown)
                 Application.Exit();
         }*/

      
     }

  }

