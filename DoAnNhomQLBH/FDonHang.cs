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
    public partial class FDonHang : Form
    {
        BUS_DonHang buDH;
        public FDonHang()
        {
            buDH = new BUS_DonHang();
            InitializeComponent();
        }

        private void FDonHang_Load(object sender, EventArgs e)
        {
            HienThiDSDonHang();
            buDH.LayDSKH(comboBoxKH);
            buDH.LayDSNV(comboBoxNV);
        }

        private void HienThiDSDonHang()
        {
            gVDH.DataSource = null;
            buDH.HienThiDSDonHang(gVDH);
            gVDH.Columns[0].Width = (int)(0.08 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.14 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.14 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.14 * gVDH.Width);
            gVDH.Columns[4].Width = (int)(0.14 * gVDH.Width);
            gVDH.Columns[5].Width = (int)(0.14 * gVDH.Width);
            gVDH.Columns[6].Width = (int)(0.14 * gVDH.Width);
        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                comboBoxKH.Text = gVDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxNV.Text = gVDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayDH.Text = gVDH.Rows[e.RowIndex].Cells[3].Value.ToString();
                //dtpNgayGiao.Text = gVDH.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChiGiao.Text = gVDH.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtGhiChu.Text = gVDH.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThemDH_Click(object sender, EventArgs e)
        {
            DonHang donhang = new DonHang();
            donhang.NgayLapHD = dtpNgayDH.Value;
            donhang.MaNV = Int32.Parse(comboBoxNV.SelectedValue.ToString());
            donhang.MaKH = Int32.Parse(comboBoxKH.SelectedValue.ToString());
            donhang.NgayGiaoHang = dtpNgayGiao.Value;
            donhang.DiaChiGiaoHang = txtDiaChiGiao.Text;
            donhang.GhiChu = txtGhiChu.Text;

            if (buDH.ThemDonHang(donhang))
            {
                MessageBox.Show("Thêm đơn hàng thành công");
                buDH.HienThiDSDonHang(gVDH);
            }
            else
            {
                MessageBox.Show("Thêm đơn hàng thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DonHang donhang = new DonHang();
            donhang.MaDH = int.Parse(txtMaDH.Text.ToString());
            donhang.MaNV = Int32.Parse(comboBoxNV.SelectedValue.ToString());
            donhang.MaKH = Int32.Parse(comboBoxKH.SelectedValue.ToString());
            donhang.NgayLapHD = dtpNgayDH.Value;
            donhang.NgayGiaoHang = dtpNgayGiao.Value;
            donhang.DiaChiGiaoHang = txtDiaChiGiao.Text;
            donhang.GhiChu = txtGhiChu.Text;

            if (buDH.suaDonHang(donhang))
            {
                MessageBox.Show("Sửa Đơn Hàng Thành Công !");
                buDH.HienThiDSDonHang(gVDH);
            }
            else
            {
                MessageBox.Show("Sửa Đơn Hàng Thất bẠI !");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DonHang d = new DonHang();
            d.MaDH = int.Parse(txtMaDH.Text);
            if (buDH.xoaDonHang(d))
            {
                MessageBox.Show("Xóa Đơn Hàng Thành Công !");
                buDH.HienThiDSDonHang(gVDH);
            }
            else
                MessageBox.Show("Xóa Đơn Hàng Thất Bại !");
        }

        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
            int maDonHang;
            maDonHang = int.Parse(gVDH.CurrentRow.Cells[0].Value.ToString());
            FChiTietDonHang f = new FChiTietDonHang();
            f.maDH = maDonHang;
            f.ShowDialog();
        }

        
    }
}
