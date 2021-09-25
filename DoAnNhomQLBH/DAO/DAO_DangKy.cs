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
        public void dangKy(Nhanvien k)
        {
            db.Nhanviens.Add(k);
            db.SaveChanges();
        }
    }
}
