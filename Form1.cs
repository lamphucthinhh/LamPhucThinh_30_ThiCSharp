using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String hovaten = "Lâm Phúc Thịnh";
            String mssv = "1223360209";
            String monthi = "lập trình windowrs 2 -c#";


            lblinfo.Text = "HỌ VÀ TÊN:" + hovaten;
            lblinfo.Text += "\nMSSV: " + mssv;
            lblinfo.Text += "\nNgay thi: " + System.DateTime.Now.ToString();
            lblinfo.Text += "\nMon thi: " + monthi;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            định_dạng dd = new định_dạng();
            dd.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gioithieu dd = new gioithieu();
            dd.Show();
        }
    }
}
