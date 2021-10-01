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
    public partial class FChiTietDonHang : Form
    {
        public int maDH;
        BUS_CTDonHang buCT;
        public FChiTietDonHang()
        {
            buCT = new BUS_CTDonHang();
            InitializeComponent();
        }

        private void HienThiDanhSachCTDH()
        {
            gVCTDH.DataSource = null;
            buCT.LayDSCTDH(gVCTDH, maDH);
            gVCTDH.Columns[0].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[1].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[2].Width = (int)(0.25 * gVCTDH.Width);
            gVCTDH.Columns[3].Width = (int)(0.25 * gVCTDH.Width);
        }
        private void FChiTietDonHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDH.ToString();
            buCT.LayDSSP(cbMaSP);
            HienThiDanhSachCTDH();
        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= gVCTDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                cbMaSP.Text = gVCTDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtThanhTien.Text = gVCTDH.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FDatHang f = new FDatHang();
            f.maDH = this.maDH;
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            buCT.xoaCTDH(maDH, cbMaSP.SelectedValue.ToString());
            HienThiDanhSachCTDH();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            CTDH oD = new CTDH();
            oD.MaDH = int.Parse(txtMaDH.Text.ToString());
            oD.MaSP = cbMaSP.SelectedValue.ToString();
            oD.ThanhTien = Int32.Parse(txtThanhTien.Text);
            oD.Soluong = Int32.Parse(txtSoLuong.Text);
            


            buCT.suaCTDH(oD);
            HienThiDanhSachCTDH();

        }

        private void FChiTietDonHang_Activated(object sender, EventArgs e)
        {
            HienThiDanhSachCTDH();
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
