using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    class DAO_KhachHang
    {
        quanlybanhangEntities db;
        public DAO_KhachHang()
        {
            db =  new quanlybanhangEntities();
        }
        public dynamic LayDSKH()
        {
            var ds = db.KhachHangs.Select(s => new{
                s.MaKH,
                s.TenKH,
                s.DiaChi,
                s.GioiTinh,
                s.DienThoai,
                s.Fax,
                s.Email,
                s.NgaySinh
            }).ToList();
            return ds;
        }
        public dynamic search(string tenKH)
        {

            var ds = db.KhachHangs.Where(s => s.TenKH.Contains(tenKH)).ToList();
            return ds;
        }
        public bool themKH(KhachHang k)
        {
            KhachHang mailKH = db.KhachHangs.Where(s => s.Email == k.Email).FirstOrDefault();
            if (mailKH == null)
            {
                db.KhachHangs.Add(k);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void xoaKH(int maKH)
        {
            KhachHang k = db.KhachHangs.Find(maKH);
            db.KhachHangs.Remove(k);
            db.SaveChanges();
        }
        public void suaKH(KhachHang kh)
        {
            KhachHang khachhang = db.KhachHangs.Find(kh.MaKH);
            khachhang.TenKH = kh.TenKH;
            khachhang.DiaChi = kh.DiaChi;
            khachhang.GioiTinh = kh.GioiTinh;
            khachhang.DienThoai = kh.DienThoai;
            khachhang.Fax = kh.Fax;
            khachhang.NgaySinh = kh.NgaySinh;
            db.SaveChanges();
        }
    }
}
