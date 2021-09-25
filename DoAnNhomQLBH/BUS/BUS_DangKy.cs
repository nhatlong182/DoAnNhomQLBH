using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.BUS
{
    class BUS_DangKy
    {
        DAO_DangKy daDK;
        public BUS_DangKy()
        {
            daDK = new DAO_DangKy();
        }
        public bool themNhanVien(Nhanvien n)
        {
            try
            {
                daDK.dangKy(n);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
