using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.BUS
{
    class BUS_DangNhap
    {
        DAO_DangNhap daDN;
        public BUS_DangNhap()
        {
            daDN = new DAO_DangNhap();

        }
        public bool dangNhap(string email, string matKhau)
        {
            if (daDN.dangNhap(email, matKhau) == true)
            {
                return true;
            }
            else
                return false;
        }
        public int GetID(string email,string pw)
        {
             int id = daDN.getID(email, pw);
            if(daDN.getID(email, pw) == 0)
            {
                return 0;
            }else
            {
                return id;
            }
            
        }
    }
}
