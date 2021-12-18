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
    public partial class Regstration : Form
    {
        public Regstration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LoginPanle().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string gender = cbGender.Text.ToString();
            var date = dtpBirthDate.Value.Date;
            string username = tbUserName.Text;
            string pass = tbPass.Text;
            // Exceptions
            
            if (name == string.Empty)
            {
                MessageBox.Show("Name Required", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (email == string.Empty)
            {
                MessageBox.Show("Email Required", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (gender == string.Empty)
            {
                MessageBox.Show("Gender Required", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (username == string.Empty)
            {
                MessageBox.Show("Username Required", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (pass == string.Empty)
            {
                MessageBox.Show("Password Required", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    
                    string checkuser = "SELECT * FROM [user] where username='" + username + "'";
                    SqlCommand cmd2 = new SqlCommand(checkuser, conn);
                    cmd2.Parameters.AddWithValue("Username", username);
                    var result = cmd2.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("User Already Exists");
                    }
                    else
                    {
                        string query = string.Format("insert into [user] values ('{0}','{1}','{2}','{3}','{4}','{5}')", name, email, gender, date, username, pass);
                        try
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            int r = cmd.ExecuteNonQuery();
                            if (r > 0)
                            {
                                MessageBox.Show("Registration Successfull");
                                this.Hide();
                                new LoginPanle().Show();

                            }
                            else
                            {
                                MessageBox.Show("Failed to Register");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
            
            conn.Close();
            }
      
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPanle().Show();
        }

        private void Regstration_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
