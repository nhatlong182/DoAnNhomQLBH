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
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            FNhanVien fNhanVien = new FNhanVien();
            fNhanVien.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            FSanPham fSanPham = new FSanPham();
            fSanPham.Show();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            FKhachHang fKhachHang = new FKhachHang();
            fKhachHang.Show();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            FDonHang fDonHang = new FDonHang();
            fDonHang.Show();
        }
    }
}
