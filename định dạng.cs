﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamPhucThinh_30_ThiCSharp
{
    public partial class định_dạng : Form
    {
        public định_dạng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void định_dạng_Load(object sender, EventArgs e)
        {
            radred.Checked = true;
            radred.ForeColor = Color.Red;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Black;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Blue;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Green;
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Red;
        }

        private void chkblod_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Underline);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radred.Checked = true;
            radred.ForeColor = Color.Red;
        }
    }
}
