using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomQLBH
{
    public partial class FHomeAdmin : Form
    {
        public FHomeAdmin()
        {
            InitializeComponent();
        }


        private void btQLSP_Click(object sender, EventArgs e)
        {

        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            FKhachHang kh = new FKhachHang();
            kh.MdiParent = this;
            kh.StartPosition = FormStartPosition.CenterScreen;
            kh.Show();
        }
    }
}
