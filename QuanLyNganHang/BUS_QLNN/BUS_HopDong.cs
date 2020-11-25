using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNganHang.DAL_QLNN;
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.BUS_QLNN
{
    public  class BUS_HopDong
    {
        private static BUS_HopDong _instance;
        public static BUS_HopDong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_HopDong();
                return _instance;
            }
        }
        public static Boolean themHopDong(int idhd, int mayc)
        {
            return DAL_HopDong.themHopDong(idhd, mayc);
        }
        public int getNextID()
        {
            return DAL_HopDong.Instance.getNextID();
        }
        public Boolean suaHopDong(DTO_HopDong hd)
        {
            return DAL_HopDong.Instance.suaHopDong(hd);
        }
    }
    
}
