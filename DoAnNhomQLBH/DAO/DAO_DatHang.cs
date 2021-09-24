using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    class DAO_DatHang
    {
        quanlybanhangEntities db;
        public DAO_DatHang()
        {
            db = new quanlybanhangEntities();
        }
        public bool KiemTraSPDH(CTDH d)
        {
            int? sl;
            sl = db.sp_KiemTraSanPhamDonHang(d.MaDH, d.MaSP).FirstOrDefault();
            if (sl != 0)
                return false;
            else
                return true;

        }
        
        public void ThemCTDH(CTDH d)
        {
            

            db.CTDHs.Add(d);
            db.SaveChanges();
            SanPham sp = db.SanPhams.Find(d.MaSP);
            CTDH s = db.CTDHs.Find(d.MaSP);
            if (sp.SoLuong < 0)
            {
                sp.SoLuong = 0;     
            }
            db.SaveChanges();
        }
    }
}
