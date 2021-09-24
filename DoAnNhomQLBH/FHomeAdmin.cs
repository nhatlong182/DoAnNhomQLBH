using DoAnNhomQLBH.BUS;
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
        private int maNV;
        FormDangNhap f;
        BUS_HomeAdmin buH = new BUS_HomeAdmin();
        public FHomeAdmin()
        {
            
            f = new FormDangNhap();
            InitializeComponent();
        }
        public FHomeAdmin(int manv)
        {
            
            InitializeComponent();
            this.maNV = manv;
        }


        private void btQLSP_Click(object sender, EventArgs e)
        {
            FSanPham kh = new FSanPham();
            kh.MdiParent = this;
            kh.StartPosition = FormStartPosition.CenterScreen;
            kh.Show();
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            FKhachHang kh = new FKhachHang();
            kh.MdiParent = this;
            kh.StartPosition = FormStartPosition.CenterScreen;
            kh.Show();
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            FNhanVien kh = new FNhanVien();
            kh.MdiParent = this;
            kh.StartPosition = FormStartPosition.CenterScreen;
            kh.Show();
        }

        private void btQLDH_Click(object sender, EventArgs e)
        {
            FDonHang kh = new FDonHang();
            kh.MdiParent = this;
            kh.StartPosition = FormStartPosition.CenterScreen;
            kh.Show();
        }

        private void FHomeAdmin_Load(object sender, EventArgs e)
        {
            int manv = maNV;
            //MessageBox.Show("a =" + manv);
            if (buH.GetAdmin(manv))
            {
                btQLNV.Enabled = true;
            }
            else
            {
                btQLNV.Enabled = false;
            }
        }
    }
}
