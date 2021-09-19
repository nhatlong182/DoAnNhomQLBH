using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhomQLBH.BUS;
namespace DoAnNhomQLBH
{
    public partial class FSanPham : Form
    {
        BUS_SanPham BusSP = new BUS_SanPham();
        public FSanPham()
        {
            InitializeComponent();
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            BusSP.HienThiDanhSachLoaiSanPham(cbMaLSP);
        }

        private void HienThiDSSanPham()
        {
            dGSP.DataSource = null;
            BusSP.LayDSSanPham(dGSP);
            dGSP.Columns[0].Width = (int)(dGSP.Width * 0.1);
            dGSP.Columns[1].Width = (int)(dGSP.Width * 0.18);
            dGSP.Columns[2].Width = (int)(dGSP.Width * 0.15);
            dGSP.Columns[3].Width = (int)(dGSP.Width * 0.15);
            dGSP.Columns[4].Width = (int)(dGSP.Width * 0.15);
            dGSP.Columns[5].Width = (int)(dGSP.Width * 0.15);
        }

        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGSP.Rows.Count - 1)
            {
                txtMaSP.Text = dGSP.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dGSP.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                txtDonGia.Text = dGSP.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = dGSP.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                cbMaLSP.Text = dGSP.Rows[e.RowIndex].Cells["TenLoaiSP"].Value.ToString();
                txtGiamGia.Text = dGSP.Rows[e.RowIndex].Cells["MaGiamGia"].Value.ToString();
            }
        }
    }
}
