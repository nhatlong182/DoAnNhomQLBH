using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomQLBH.BUS
{
    class BUS_NhanVien
    {
        DAO_NhanVien daNV;
        public BUS_NhanVien()
        {
            daNV = new DAO_NhanVien();
        }
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = daNV.LayDSNV();
        }
        public void search(DataGridView dg, string tenNV)
        {
            dg.DataSource = daNV.search(tenNV);
        }
        public bool themNhanVien(Nhanvien n)
        {
            try
            {
                daNV.themNV(n);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaNhanVien(int manv)
        {
            try
            {
                daNV.xoaNV(manv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaNhanVien(Nhanvien n)
        {
            try
            {
                daNV.suaNV(n);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
