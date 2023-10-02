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
    public partial class gioithieu : Form
    {
        public gioithieu()
        {
            InitializeComponent();
        }

        private void gioithieu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chương Trình Tiện Ích", "Thông Tin");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
