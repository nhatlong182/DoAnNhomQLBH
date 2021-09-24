using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.DAO
{

    class DAO_HomeAdmin
    {
        quanlybanhangEntities db;
        public DAO_HomeAdmin()
        {
            db = new quanlybanhangEntities();
        }
        public bool getAdmin(int maNV)
        {
            Nhanvien n = db.Nhanviens.Find(maNV);
            if (n.Admin == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
