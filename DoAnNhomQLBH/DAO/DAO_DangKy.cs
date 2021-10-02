using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    class DAO_DangKy
    {
        quanlybanhangEntities db;
        public DAO_DangKy()
        {
            db = new quanlybanhangEntities();
        }
        public bool dangKy(Nhanvien k)
        {
            Nhanvien mailNV = db.Nhanviens.Where(s => s.Email == k.Email).FirstOrDefault();
            if (mailNV == null)
            {
                db.Nhanviens.Add(k);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
