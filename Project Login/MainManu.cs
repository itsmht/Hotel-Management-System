using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Login
{
    public partial class MainManu : Form
    {
        public MainManu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Customer_Service().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new EmployeeExtended().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Customer_Details().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Add_Room().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CheckOut().Show();
        }

       
    }
}
