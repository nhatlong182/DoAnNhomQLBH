using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{
    
    class DAO_DangNhap
    {
        quanlybanhangEntities db;
        public DAO_DangNhap()
        {
            db = new quanlybanhangEntities();
        }
        public bool dangNhap(string email, string password)
        {
            int? trangThai;
            trangThai = db.spLogin(email, password).SingleOrDefault();
            if(trangThai == 1)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public int getID(string email, string pw)
        {
            int id;
            int? trangThai;
            trangThai = db.spLogin(email, pw).SingleOrDefault();
           
            if (trangThai == 1)
            {
                Nhanvien nhanvien = db.Nhanviens.SingleOrDefault(s=> s.Email == email);
                id = nhanvien.MaNV;
                return id;
            }
            else
                return 0;
        }
    }
}
