using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganHang.BUS_QLNN
{
    public class BUS_NhanVien
    {
        private static BUS_NhanVien _instance;
        public static BUS_NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_NhanVien();
                return _instance;
            }
        }

    }
}
