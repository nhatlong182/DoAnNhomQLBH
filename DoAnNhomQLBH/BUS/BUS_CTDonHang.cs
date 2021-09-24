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
    class BUS_CTDonHang
    {
        DAO_CTDonHang daCT;
        public BUS_CTDonHang()
        {
            daCT = new DAO_CTDonHang();
        }
        public void LayDSCTDH(DataGridView dg, int maDH)
        {
            dg.DataSource = daCT.LayDSCTDonHang(maDH);
        }
        public void HienThiDSCTDH(DataGridView dg)
        {
            dg.DataSource = daCT.LayDSCTDH();
        }
        public void LayDSSP(ComboBox cb)
        {
            cb.DataSource = daCT.LayDSSP();
            cb.DisplayMember = "TenSP";
            cb.ValueMember = "MaSP";
        }

        public bool xoaCTDH(CTDH d)
        {
            if (daCT.KiemTraCTDH(d))
            {
                try
                {
                    daCT.XoaCTDH(d);
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
        public bool suaCTDH(CTDH d)
        {
            try
            {
                daCT.SuaChiTietDH(d);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
