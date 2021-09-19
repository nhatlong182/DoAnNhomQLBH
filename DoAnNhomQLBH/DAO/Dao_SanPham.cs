using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    
    class Dao_SanPham
    {
        quanlybanhangEntities database;
        public Dao_SanPham()
        {
            database = new quanlybanhangEntities();
        }
        public dynamic LayDSSanPham()
        {
            var ds = database.SanPhams.Select(s => new
            {
               s.MaSP , 
               s.TenSP,
               s.DonGia,
               s.SoLuong ,
               s.MaGiamGia,
               s.LoaiSP.TenLoaiSP,
            }).ToList();

            return ds;
        }

        public dynamic LayDSLoaiSP()
        {
            var ds = database.LoaiSPs.Select(s => new
            {
                s.TenLoaiSP,
                s.MaLoaiSP
            }).ToList();
            return ds;
        }
    }
    
}
