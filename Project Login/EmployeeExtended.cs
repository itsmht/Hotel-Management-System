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
    public partial class EmployeeExtended : Form
    {
        public EmployeeExtended()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Regstration().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeDetails().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeDelete ().Show();
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

        private void EmployeeExtended_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
