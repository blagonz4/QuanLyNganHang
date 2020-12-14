using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNganHang.DAL_QLNN;
using QuanLyNganHang.DTO_QLNN;
using System.Data;

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
        public DataTable getDanhSach()
        {
            return DAL_HopDong.Instance.getDanhSach();
        }

        public DataTable getDanhSachByID(string cmnd)
        {
            try
            {
                return DAL_HopDong.Instance.getDanhSachByID(cmnd);
            }
            catch(Exception)
            {
                return null;
            }
        }
        public bool thanhLyHopDong(int mahd)
        {
            return DAL_HopDong.Instance.thanhLyHopDong(mahd);
        }
    }
    
}
