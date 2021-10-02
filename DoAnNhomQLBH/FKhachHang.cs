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
    public partial class FKhachHang : Form
    {
        BUS_KhachHang buKH;
        public FKhachHang()
        {
            buKH = new BUS_KhachHang();
            InitializeComponent();
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKH();
        }
        private void HienThiDSKH()
        {
            dGKhachHang.DataSource = null;
            buKH.LayDSKhachHang(dGKhachHang);
            dGKhachHang.Columns[0].Width = (int)(dGKhachHang.Width * 0.1);
            dGKhachHang.Columns[1].Width = (int)(dGKhachHang.Width * 0.18);
            dGKhachHang.Columns[2].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[3].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[4].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[5].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[6].Width = (int)(dGKhachHang.Width * 0.15);
        }


        private void dGKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dGKhachHang.Rows.Count)
            {
                txtTenKH.Text = dGKhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                txtGioiTinh.Text = dGKhachHang.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = dGKhachHang.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtSdt.Text = dGKhachHang.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = dGKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtEmail.Text = dGKhachHang.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtFax.Text = dGKhachHang.Rows[e.RowIndex].Cells["Fax"].Value.ToString();
                string method = txtGioiTinh.Text.ToString();
                switch (method.Trim())
                {
                    case "Nam":
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile("../../Resources/avtnam.png");
                        break;
                    case "Nữ":
                        pictureBox1.Image = null;
                        pictureBox1.Image = Image.FromFile("../../Resources/avtnu.jpg");
                        break;
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int MaKH;
            MaKH = Convert.ToInt32(dGKhachHang.Rows[dGKhachHang.CurrentRow.Index].Cells[0].Value.ToString());
            if (buKH.xoaKhachHang(MaKH))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                buKH.LayDSKhachHang(dGKhachHang);
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại !");
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.TenKH = txtTenKH.Text;
            kh.GioiTinh = txtGioiTinh.Text;
            kh.NgaySinh = dtpNgaySinh.Value;
            kh.DienThoai = txtSdt.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.Email = txtEmail.Text;
            kh.Fax = txtFax.Text;
            if (buKH.themKhachHang(kh))
            {
                if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if (string.IsNullOrWhiteSpace(txtSdt.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số diện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtGioiTinh.Text))
                {
                    MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtFax.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Fax", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    MessageBox.Show("Thêm khách hàng thành công");
                    buKH.LayDSKhachHang(dGKhachHang);
                }
                
            }else
            {
                MessageBox.Show("Thêm khách hàng thất bại !");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = Convert.ToInt32(dGKhachHang.Rows[dGKhachHang.CurrentRow.Index].Cells[0].Value.ToString());
            kh.TenKH = txtTenKH.Text;
            kh.GioiTinh = txtGioiTinh.Text;
            kh.NgaySinh = dtpNgaySinh.Value;
            kh.DienThoai = txtSdt.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.Fax = txtFax.Text;
            if (buKH.suaKhachHang(kh))
            {
                if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtSdt.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số diện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtGioiTinh.Text))
                {
                    MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtFax.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Fax", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Sửa khách hàng thành công");
                    buKH.LayDSKhachHang(dGKhachHang);
                }

            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại !");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string tenKH = txtSearch.Text;
            buKH.search(dGKhachHang, tenKH);
        }
    }
}
