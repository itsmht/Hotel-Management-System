﻿using System;
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
            new Regstration().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmployeeDetails().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EmployeeDelete ().Show();
        }
    }
}
