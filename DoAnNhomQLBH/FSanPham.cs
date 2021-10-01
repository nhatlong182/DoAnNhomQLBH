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
using DoAnNhomQLBH.Report;
using System.IO;

namespace DoAnNhomQLBH
{
    public partial class FSanPham : Form
    {
        BUS_SanPham buSP;
        string duongDan;
        public FSanPham()
        {
            buSP = new BUS_SanPham();
            InitializeComponent();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            buSP.LayDSMLSP(cbMaLSP);
        }
        private void HienThiDSSanPham()
        {
            dGSP.DataSource = null;
            buSP.LayDSSanPham(dGSP);
            dGSP.Columns[0].Width = (int)(dGSP.Width * 0.1);
            dGSP.Columns[1].Width = (int)(dGSP.Width * 0.18);
            dGSP.Columns[2].Width = (int)(dGSP.Width * 0.15);
            dGSP.Columns[3].Width = (int)(dGSP.Width * 0.15);
            dGSP.Columns[4].Width = (int)(dGSP.Width * 0.15);
            dGSP.Columns[5].Width = (int)(dGSP.Width * 0.15);
        }

        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGSP.Rows.Count)
            {
                //txtMaSP.Enabled = false;
                txtMaSP.Text = dGSP.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dGSP.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                txtDonGia.Text = dGSP.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                cbMaLSP.Text = dGSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtHinh.Text = dGSP.Rows[e.RowIndex].Cells["HinhSP"].Value.ToString();
                txtSoLuong.Text = dGSP.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                pictureBox1.Image = Image.FromFile("../../" + dGSP.Rows[e.RowIndex].Cells["HinhSP"].Value.ToString());
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SanPham s = new SanPham();

            DateTime d = DateTime.Now;

            s.MaSP = "SP" + d.Second.ToString() + d.Millisecond.ToString();
            s.TenSP = txtTenSP.Text;
            s.DonGia = Int32.Parse(txtDonGia.Text);
            s.SoLuong = Int32.Parse(txtSoLuong.Text);
            s.MaLoaiSP = Int32.Parse(cbMaLSP.SelectedValue.ToString());
            

            if(!string.IsNullOrEmpty(duongDan))
            {
                File.Copy(duongDan, Path.Combine(@"../../images/", Path.GetFileName(duongDan)), true);
                s.HinhSP = txtHinh.Text;
            }


            if (buSP.themSanPham(s))
            {
                if (string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtDonGia.Text))
                {
                    MessageBox.Show("Bạn chưa nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(cbMaLSP.Text))
                {
                    MessageBox.Show("Bạn chưa chọn mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(duongDan))
                {
                    MessageBox.Show("Bạn chưa chọn hình sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Thêm sản phẩm thành công");
                    buSP.LayDSSanPham(dGSP);
                }

            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại !");
            }
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SanPham s = new SanPham();

            s.MaSP = txtMaSP.Text;
            s.TenSP = txtTenSP.Text;
            s.DonGia = Int32.Parse(txtDonGia.Text);
            s.SoLuong = Int32.Parse(txtSoLuong.Text);
            s.MaLoaiSP = Int32.Parse(cbMaLSP.SelectedValue.ToString());
            s.HinhSP = txtHinh.Text;

            if (openFileDialog1.Container != null)
            {
                File.Copy(duongDan, Path.Combine(@"../../images/", Path.GetFileName(duongDan)), true);
                s.HinhSP = txtHinh.Text;
            }

            if (buSP.suaSanPham(s))
            {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtDonGia.Text))
                {
                    MessageBox.Show("Bạn chưa nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(cbMaLSP.Text))
                {
                    MessageBox.Show("Bạn chưa chọn mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtHinh.Text))
                {
                    MessageBox.Show("Bạn chưa chọn hình sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Sửa sản phẩm thành công");
                    buSP.LayDSSanPham(dGSP);
                }

            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại !");
            }

            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string MaSP;
            MaSP = dGSP.Rows[dGSP.CurrentRow.Index].Cells[0].Value.ToString();
            if (buSP.xoaSanPham(MaSP))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                buSP.LayDSSanPham(dGSP);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại !");
            }
        }


        private void btReport_Click(object sender, EventArgs e)
        {
            CRSanPham r = new CRSanPham();
            FReport f = new FReport();
            r.SetDataSource(buSP.LayDSSanPham().ToList());
            f.crystalReportViewer1.ReportSource = r;

            f.Show();
        }

        private void btHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            duongDan = openFileDialog1.FileName;
            string tenHinh = Path.GetFileName(duongDan);

            
            pictureBox1.Image = Image.FromFile(duongDan);
            txtHinh.Text = "images/" + tenHinh.ToString();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string tenSP = txtSearch.Text;
            buSP.search(dGSP,tenSP);
            txtSearch.Text = "";
        }
    }
}
