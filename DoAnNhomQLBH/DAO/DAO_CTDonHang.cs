using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    class DAO_CTDonHang
    {
        quanlybanhangEntities db;
        public DAO_CTDonHang()
        {
            db = new quanlybanhangEntities();
        }
        public dynamic LayDSCTDonHang(int maDH)
        {
            var ds = db.CTDHs.Where(s => s.MaDH == maDH)
                    .Select(s => new
                    {
                        s.MaDH,
                        s.SanPham.TenSP,
                        s.Soluong,
                        s.ThanhTien

                    }).ToList();
            return ds;
        }
        public dynamic LayDSCTDH()
        {
            return db.DonHangs.Select(s => new
            {
                s.MaDH,
                s.NgayLapHD,
                s.KhachHang.TenKH,
                s.Nhanvien.HoTenNV

            }).ToList();
        }
        public dynamic LayDSSP()
        {
            var ds = db.SanPhams.Select(s => new {
                s.MaSP,
                s.TenSP
            }).ToList();
            return ds;
        }
        public Boolean KiemTraCTDH(CTDH d)
        {
            CTDH 
            o = db.CTDHs.FirstOrDefault(s => s.MaSP == d.MaSP);

            if (o != null)
            {
                return true;
            }
            else
                return false;

        }
        //public void XoaCTDH(CTDH d)
        //{

        //    CTDH ct = db.CTDHs.Where(x => x.MaDH == d.MaDH && x.MaSP == d.MaSP).SingleOrDefault();
        //    //ct.MaSP = null;
        //    db.CTDHs.Remove(ct);
        //    db.SaveChanges();

        //}
        public bool xoaCTDH(int MaDH, string MaSP)
        {
            bool tinhTrang = false;
            CTDH ct = db.CTDHs.Where(s => s.MaDH == MaDH && s.MaSP == MaSP).SingleOrDefault();

            if (ct != null)
            {
                db.CTDHs.Remove(ct);
                db.SaveChanges();
                tinhTrang = true;
            }
            else
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }
        public bool SuaChiTietDH(CTDH donHang)
        {

            CTDH d = db.CTDHs.Where(s => s.MaDH == donHang.MaDH && s.MaSP == donHang.MaSP).SingleOrDefault();

            if(d != null)
            {
                d.MaSP = donHang.MaSP;
                SanPham sp = db.SanPhams.Find(d.MaSP);

                d.ThanhTien = donHang.Soluong * sp.DonGia;
                d.Soluong = donHang.Soluong;
                d.Size = donHang.Size;
                db.SaveChanges();
                return true;
            }
            

            return false;

        }
    }
}
