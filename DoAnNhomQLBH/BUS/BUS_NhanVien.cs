using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomQLBH.BUS
{
    class BUS_NhanVien
    {
        DAO_NhanVien daNV;
        public BUS_NhanVien()
        {
            daNV = new DAO_NhanVien();
        }
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = daNV.LayDSNV();
        }
        public void search(DataGridView dg, string tenNV)
        {
            dg.DataSource = daNV.search(tenNV);
        }

        public bool themNhanVien(Nhanvien n)
        {
            try
            {
                if (daNV.themNV(n))
                {
                    return true;
                }
                else
                    return false;
                
            }
            catch (Exception)
            {
                
                return false;
            }
        }
        public bool xoaNhanVien(int manv)
        {
            try
            {
                daNV.xoaNV(manv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaNhanVien(Nhanvien n)
        {
            try
            {
                daNV.suaNV(n);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
