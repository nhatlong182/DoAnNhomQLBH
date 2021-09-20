﻿using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomQLBH.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang daKH;
        public BUS_KhachHang()
        {
            daKH = new DAO_KhachHang();
        }
        public void LayDSKhachHang(DataGridView dg)
        {
            dg.DataSource = daKH.LayDSKH();
        }
        public bool themKhachHang(KhachHang k)
        {
            try {
                daKH.themKH(k);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
        public bool xoaKhachHang(int makh)
        {
            try
            {
                daKH.xoaKH(makh);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaKhachHang(KhachHang kh)
        {
            try {
                daKH.suaKH(kh);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
