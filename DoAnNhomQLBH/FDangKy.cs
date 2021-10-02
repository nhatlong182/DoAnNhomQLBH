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
    public partial class FDangKy : Form
    {
        BUS_DangKy buDK;
        public FDangKy()
        {
            buDK = new BUS_DangKy();
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
           
            FormDangNhap f = new FormDangNhap();
           
            this.Hide();
            f.ShowDialog();
            
        }

        private void btdangKy_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.HoTenNV = txtTen.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.Dienthoai = txtDienThoai.Text;
            nv.Diachi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.Password = txtPw.Text;
            nv.Admin = false;
            if (buDK.isEmail(txtEmail.Text) == true)
            {
                if (buDK.themNhanVien(nv))
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text))
                {
                    MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
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
                else if (string.IsNullOrWhiteSpace(txtPw.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Tạo tài khoản thành công");
                    clear();
                }

            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại !");
            }
        }else
            {
                MessageBox.Show("Email không hợp lệ !");
            }
}
        public void clear()
        {
            txtTen.Clear();
            txtGioiTinh.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtPw.Clear();
            txtDienThoai.Clear();
        }
    }
}
