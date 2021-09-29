using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomQLBH.BUS
{
    class BUS_SanPham
    {
        DAO_SanPham daSP;
        public BUS_SanPham()
        {
            daSP = new DAO_SanPham();
        }
        public void LayDSMLSP(ComboBox cb)
        {
            cb.DataSource = daSP.LayDSMLSP();
            cb.DisplayMember = "TenLoaiSP";
            cb.ValueMember = "MaLoaiSP";
        }
        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = daSP.LayDSSP();
        }
        public void search(DataGridView dg,string tenSP)
        {
            dg.DataSource = daSP.search(tenSP);
        }
        public List<SanPham> LayDSSanPham()
        {
            return daSP.LayDSSPReport();
        }
        public void HienThiDSSP(ComboBox cb)
        {
            cb.DataSource = daSP.LayDSSP();
            cb.DisplayMember = "TenSP";
            cb.ValueMember = "MaSP";
        }
        public SanPham LayThongTinSP(string maSP)
        {
            // check if maSP is existed

            return daSP.LayThongTinSP(maSP);
        }
        public bool themSanPham(SanPham s)
        {
            try
            {
                daSP.themSP(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaSanPham(SanPham d)
        {
            try
            {
                daSP.suaSP(d);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool xoaSanPham(string masp)
        {
            try
            {
                daSP.xoaSP(masp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
