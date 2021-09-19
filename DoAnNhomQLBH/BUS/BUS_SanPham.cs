using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNhomQLBH.DAO;
using System.Windows.Forms;
namespace DoAnNhomQLBH.BUS
{
    class BUS_SanPham
    {
        Dao_SanPham daoSanPham;
        public BUS_SanPham()
        {
            daoSanPham = new Dao_SanPham();
        }

        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = daoSanPham.LayDSSanPham();
        }
        public void HienThiDanhSachLoaiSanPham(ComboBox cb)
        {
            cb.DataSource = daoSanPham.LayDSLoaiSP();
            cb.DisplayMember = "TenLoaiSP";
            cb.ValueMember = "MaLoaiSP";
        }
    }
}
