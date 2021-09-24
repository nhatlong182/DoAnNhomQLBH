﻿using DoAnNhomQLBH.BUS;
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
    public partial class FNhanVien : Form
    {
        BUS_NhanVien buNV;
        public FNhanVien()
        {
            buNV = new BUS_NhanVien();
            InitializeComponent();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            buNV.LayDSNhanVien(dGNhanVien);
        }
        private void HienThiDSNV()
        {
            dGNhanVien.DataSource = null;
            buNV.LayDSNhanVien(dGNhanVien);
            dGNhanVien.Columns[0].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[1].Width = (int)(dGNhanVien.Width * 0.18);
            dGNhanVien.Columns[2].Width = (int)(dGNhanVien.Width * 0.15);
            dGNhanVien.Columns[3].Width = (int)(dGNhanVien.Width * 0.15);
            dGNhanVien.Columns[4].Width = (int)(dGNhanVien.Width * 0.15);
            dGNhanVien.Columns[5].Width = (int)(dGNhanVien.Width * 0.15);
            dGNhanVien.Columns[6].Width = (int)(dGNhanVien.Width * 0.15);
        }
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dGNhanVien.Rows.Count)
            {
                txtTenNV.Text = dGNhanVien.Rows[e.RowIndex].Cells["HoTenNV"].Value.ToString();
                txtGioiTinh.Text = dGNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = dGNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtSdt.Text = dGNhanVien.Rows[e.RowIndex].Cells["Dienthoai"].Value.ToString();
                txtDiaChi.Text = dGNhanVien.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
                txtEmail.Text = dGNhanVien.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                cbAdmin.Text = dGNhanVien.Rows[e.RowIndex].Cells["Admin"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.HoTenNV = txtTenNV.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.Dienthoai = txtSdt.Text;
            nv.Diachi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.Admin = false;
            if (buNV.themNhanVien(nv))
            {
                if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (string.IsNullOrWhiteSpace(cbAdmin.Text))
                {
                    MessageBox.Show("Bạn chưa nhập chức danh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Thêm khách hàng thành công");
                    buNV.LayDSNhanVien(dGNhanVien);
                }

            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại !");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.MaNV = Convert.ToInt32(dGNhanVien.Rows[dGNhanVien.CurrentRow.Index].Cells[0].Value.ToString());
            nv.HoTenNV = txtTenNV.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.Dienthoai = txtSdt.Text;
            nv.Diachi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            //nv.Admin = Convert.ToBoolean(cbAdmin.SelectedValue.ToString());
            if (buNV.suaNhanVien(nv))
            {
                if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (string.IsNullOrWhiteSpace(cbAdmin.Text))
                {
                    MessageBox.Show("Bạn chưa nhập Fax", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Sửa nhân viên thành công");
                    buNV.LayDSNhanVien(dGNhanVien);
                }

            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất thất bại !");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int MaNV;
            MaNV = Convert.ToInt32(dGNhanVien.Rows[dGNhanVien.CurrentRow.Index].Cells[0].Value.ToString());
            if (buNV.xoaNhanVien(MaNV))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                buNV.LayDSNhanVien(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại !");
            }
        }
    }
}
