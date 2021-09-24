using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    
    class DAO_DonHang
    {
        quanlybanhangEntities db;
        public DAO_DonHang()
        {
            db = new quanlybanhangEntities();
        }
        public dynamic LayDSKH()
        {
            var ds = db.KhachHangs.Select(s => new {
                s.MaKH,
                s.TenKH
            }).ToList();
            return ds;
        }
        public dynamic LayDSNV()
        {
            var ds = db.Nhanviens.Select(s => new { s.MaNV, s.HoTenNV }).ToList();
            return ds;
        }
        public dynamic LayDSDH()
        {
            var ds = db.DonHangs.Select(s => new {
                s.MaDH,
                s.KhachHang.TenKH,
                s.Nhanvien.HoTenNV,
                s.NgayLapHD,
                s.NgayGiaoHang,
                s.DiaChiGiaoHang,
                s.GhiChu
            }).ToList();
            return ds;
        }
        public dynamic LayDSDonHang()
        {
            return db.DonHangs.Select(s => new
            {
                s.MaDH,
                s.KhachHang.TenKH,
                s.Nhanvien.HoTenNV,
                s.NgayLapHD,
                s.NgayGiaoHang,
                s.DiaChiGiaoHang,
                s.GhiChu
            }).ToList();
        }
        public Boolean KiemTraDonHang(DonHang d)
        {
            DonHang o = db.DonHangs.Find(d.MaDH);
            if (o != null)
            {
                return true;
            }
            else
                return false;

        }
        public void ThemDH(DonHang d)
        {
            db.DonHangs.Add(d);
            db.SaveChanges();
        }
        
        public void SuaDH(DonHang donHang)
        {

            DonHang d = db.DonHangs.Find(donHang.MaDH);
            d.MaNV = donHang.MaNV;
            d.MaKH = donHang.MaKH;
            d.NgayLapHD = donHang.NgayLapHD;
            d.NgayGiaoHang = donHang.NgayGiaoHang;
            d.DiaChiGiaoHang = donHang.DiaChiGiaoHang;
            d.GhiChu = donHang.GhiChu;
            db.SaveChanges();

        }
        public void XoaDH(DonHang d)
        {
            var od = db.CTDHs.Where(m => m.MaDH == d.MaDH).ToList();
            for (int i = 0; i < od.Count; i++)
            {
                db.CTDHs.Remove(od[i]);
            }
            DonHang o = db.DonHangs.Find(d.MaDH);
            db.DonHangs.Remove(o);
            db.SaveChanges();

        }
    }
}
