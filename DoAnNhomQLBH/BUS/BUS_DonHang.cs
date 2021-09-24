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
    class BUS_DonHang
    {
        DAO_DonHang daDH;
        public BUS_DonHang()
        {
            daDH = new DAO_DonHang();
        }
        public void LayDSDonHang(DataGridView dg)
        {
            dg.DataSource = daDH.LayDSDH();
        }
        public void LayDSKH(ComboBox cb)
        {
            cb.DataSource = daDH.LayDSKH();
            cb.DisplayMember = "TenKH";
            cb.ValueMember = "MaKH";
        }
        public void LayDSNV(ComboBox cb)
        {
            cb.DataSource = daDH.LayDSNV();
            cb.DisplayMember = "HoTenNV";
            cb.ValueMember = "MaNV";
        }
        public void HienThiDSDonHang(DataGridView dg)
        {
            dg.DataSource = daDH.LayDSDonHang();
        }
        public bool ThemDonHang(DonHang d)
        {
            try
            {
                daDH.ThemDH(d);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaDonHang(DonHang d)
        {
            try
            {
                daDH.SuaDH(d);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool xoaDonHang(DonHang d)
        {
            if (daDH.KiemTraDonHang(d))
            {
                try
                {
                    daDH.XoaDH(d);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
    }
}
