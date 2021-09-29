using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DoAnNhomQLBH.BUS
{
   
    class BUS_DatHang
    {
        DAO_DatHang bDatHang;
        public BUS_DatHang()
        {
            bDatHang = new DAO_DatHang();

        }
        public bool ThemChiTietDonHang(int maDH, DataTable dtDonHang)
        {
            bool result = false;

            using (var tran = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in dtDonHang.Rows)
                    {
                        CTDH d = new CTDH();
                        d.MaDH = maDH;
                        d.MaSP = item[0].ToString();
                        d.ThanhTien = Int32.Parse(item[1].ToString());
                        d.Soluong = Int32.Parse(item[2].ToString());
                        d.Giamgia = Int32.Parse(item[3].ToString());
                        if (bDatHang.KiemTraSPDH(d))
                        {
                            
                            bDatHang.ThemCTDH(d);
                        }
                        else
                        {
                            throw new Exception("Sản Phẩm Đã tồn tại " + d.MaSP);
                        }

                    }
                    tran.Complete();
                    result = true;
                }
                catch (Exception)
                {
                    result = false; // chưa xử lý giao tác 
                    MessageBox.Show("Sản phẩm đã tồn tại");
                }
            }
            return result;
        }
    }
}
