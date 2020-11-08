using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.DAL_QLNN
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien _instance;
        public static DAL_NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_NhanVien();
                return _instance;
            }
        }
    }
}
