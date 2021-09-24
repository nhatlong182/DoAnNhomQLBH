﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    class DAO_NhanVien
    {
        quanlybanhangEntities db;
        public DAO_NhanVien()
        {
            db = new quanlybanhangEntities();
        }
        public dynamic LayDSNV()
        {
            var ds = db.Nhanviens.Select(s => new {
                s.MaNV,
                s.HoTenNV,
                s.Diachi,
                s.GioiTinh,
                s.NgaySinh,
                s.Dienthoai,
                s.Email,
                s.Admin
            }).ToList();
            return ds;
        }
        public void themNV(Nhanvien n)
        {
            db.Nhanviens.Add(n);
            db.SaveChanges();
        }
        public void xoaNV(int maNV)
        {
            Nhanvien k = db.Nhanviens.Find(maNV);
            db.Nhanviens.Remove(k);
            db.SaveChanges();
        }
        public void suaNV(Nhanvien nv)
        {
            Nhanvien nhanvien = db.Nhanviens.Find(nv.MaNV);
            nhanvien.HoTenNV = nv.HoTenNV;
            nhanvien.Diachi = nv.Diachi;
            nhanvien.GioiTinh = nv.GioiTinh;
            nhanvien.NgaySinh = nv.NgaySinh;
            nhanvien.Dienthoai = nv.Dienthoai;
            nhanvien.Email = nv.Email;
            nhanvien.NgaySinh = nv.NgaySinh;
            nhanvien.Admin = nv.Admin;
            db.SaveChanges();
        }
    }
}