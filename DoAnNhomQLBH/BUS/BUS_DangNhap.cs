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
    }
}
