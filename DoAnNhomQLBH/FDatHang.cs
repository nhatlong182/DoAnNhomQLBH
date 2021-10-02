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
    public partial class FDatHang : Form
    {
        public int maDH;
        BUS_SanPham buSP;
        BUS_CTDonHang buCT;
        BUS_DatHang bDatHang;
        bool flag = false;
        DataTable dtDonHang;
        public FDatHang()
        {
            InitializeComponent();
            buSP = new BUS_SanPham();
            bDatHang = new BUS_DatHang(); ;
        }

        private void FDatHang_Load(object sender, EventArgs e)
        {
            buSP.HienThiDSSP(cbSP);
            flag = true;
            // hien thi ma don hang 
            txtMaDH.Text = maDH.ToString();
            // hien thi tren datagridview productid , unitprice , quantity ,discount
            dtDonHang = new DataTable();
            dtDonHang.Columns.Add("MaSP");
            dtDonHang.Columns.Add("DonGia");
            dtDonHang.Columns.Add("SoLuong");
            dtDonHang.Columns.Add("MaGiamGia");
            dGSP.DataSource = dtDonHang;
            // Dinh Dang 4 cot cho view 
            dGSP.Columns[0].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[1].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[2].Width = (int)(0.25 * dGSP.Width);
            dGSP.Columns[3].Width = (int)(0.25 * dGSP.Width);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dựa vào mã láy thông tin sản phẩm 
            SanPham p;
            if (flag)
            {
                string maSP = cbSP.SelectedValue.ToString();
                p = buSP.LayThongTinSP(maSP);
                // hien thi 
                txtLoaiSP.Text = p.LoaiSP.TenLoaiSP.ToString();
                txtDonGia.Text = p.DonGia.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataRow dataRow;
            bool checkSP = true;
            // Kiem tra SP co trong dataTable hay chua 
            foreach (DataRow item in dtDonHang.Rows)
            {
                if (cbSP.SelectedValue.ToString() == item[0].ToString())
                {
                    // Cap nhat so luong 
                    item[2] = int.Parse(item[2].ToString()) + numSoLuong.Value;
                    checkSP = false;
                    break;
                }

            }
            if (checkSP == true)
            {
                if (string.IsNullOrWhiteSpace(txtLoaiSP.Text))
                {
                    MessageBox.Show("Chưa có loại sản phẩm, vui lòng click chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtDonGia.Text))
                {
                    MessageBox.Show("Chưa có đơn giá, vui lòng click chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtGiamGia.Text))
                {
                    MessageBox.Show("Chưa có giảm giá, vui lòng click chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(cbSP.Text))
                {
                    MessageBox.Show("vui lòng click chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataRow = dtDonHang.NewRow();
                    txtMaDH.Enabled = false;
                    txtMaDH.Text = maDH.ToString();
                    dataRow[0] = cbSP.SelectedValue.ToString();
                    dataRow[1] = Int32.Parse(txtDonGia.Text.Replace(".", "")) * Convert.ToInt32(numSoLuong.Value);
                    dataRow[2] = Convert.ToInt32(numSoLuong.Value);
                    dataRow[3] = float.Parse(txtGiamGia.Text);
                    dtDonHang.Rows.Add(dataRow);
                }
                
            }
        }

        private void btTaoDonHang_Click(object sender, EventArgs e)
        {
            buCT = new BUS_CTDonHang();
            if (bDatHang.ThemChiTietDonHang(maDH, dtDonHang))
            {
                MessageBox.Show("Đặt hàng thành công ");
                Close();
            }
            else
                MessageBox.Show("Đặt Hàng thất bại !");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            dGSP.DataSource = null;
            // hien thi tren datagridview productid , unitprice , quantity ,discount
            dtDonHang = new DataTable();
            dtDonHang.Columns.Add("MaSP");
            dtDonHang.Columns.Add("DonGia");
            dtDonHang.Columns.Add("SoLuong");
            dtDonHang.Columns.Add("MaGiamGia");
            dGSP.DataSource = dtDonHang;
            // Dinh Dang 4 cot cho view 
            dGSP.Columns[0].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[1].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[2].Width = (int)(0.25 * dGSP.Width);
            dGSP.Columns[3].Width = (int)(0.25 * dGSP.Width);
        }
    }
}
