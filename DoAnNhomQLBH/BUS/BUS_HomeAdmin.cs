using DoAnNhomQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomQLBH.BUS
{
    class BUS_HomeAdmin
    {
        DAO_HomeAdmin daH;
        public BUS_HomeAdmin()
        {
            daH = new DAO_HomeAdmin();
        }
        public bool GetAdmin(int manv)
        {
            if(daH.getAdmin(manv))
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
