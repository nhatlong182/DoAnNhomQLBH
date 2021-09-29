using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    class DAO_SanPham
    {
        quanlybanhangEntities db;
        public DAO_SanPham()
        {
            db = new quanlybanhangEntities();
        }
        public dynamic LayDSSP()
        {
            var ds = db.SanPhams.Select(s => new {
                s.MaSP,
                s.TenSP,
                s.DonGia,
                s.LoaiSP.TenLoaiSP,
                s.HinhSP,
                s.SoLuong
            }).ToList();
            return ds;
        }
        public List<SanPham> LayDSSPReport()
        {
            var ds = db.SanPhams.Select(s => s).ToList();
            return ds;
        }
        public dynamic LayDSMLSP()
        {
            var ds = db.LoaiSPs.Select(s => new {
                s.MaLoaiSP,
                s.TenLoaiSP
            }).ToList();
            return ds;
        }
        public SanPham LayThongTinSP(string maSP)
        {
            SanPham p = db.SanPhams.Where(s => s.MaSP == maSP).FirstOrDefault();
            return p;
        }
        public void themSP(SanPham s)
        {
            db.SanPhams.Add(s);
            db.SaveChanges();
        }
        public void suaSP(SanPham s)
        {
            SanPham sp = db.SanPhams.Find(s.MaSP);
           
            sp.TenSP = s.TenSP;
            sp.DonGia = s.DonGia;
            sp.MaLoaiSP = s.MaLoaiSP;
            sp.HinhSP = s.HinhSP;
            sp.SoLuong = s.SoLuong;
            db.SaveChanges();
        }
        public void xoaSP(string masp)
        {
            SanPham k = db.SanPhams.Find(masp);
            var ct = db.CTDHs.Where(x => x.MaSP == masp).ToList();
            foreach(CTDH ctdh in ct)
            {
                db.CTDHs.Remove(ctdh);
            }
            db.SanPhams.Remove(k);
            db.SaveChanges();
        }
    }
}
