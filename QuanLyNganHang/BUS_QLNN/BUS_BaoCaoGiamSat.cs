using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNganHang.DAL_QLNN;

namespace QuanLyNganHang.BUS_QLNN
{
    class BUS_BaoCaoGiamSat
    {
        private static BUS_BaoCaoGiamSat _instance;
        public static BUS_BaoCaoGiamSat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_BaoCaoGiamSat();
                return _instance;
            }
        }
        public DataTable getDanhSach()
        {
            return DAL_BaoCaoGiamSat.Instance.getDanhSach();
        }
        public DataTable getDanhSach(int cmnd)
        {
            return DAL_BaoCaoGiamSat.Instance.getDanhSach(cmnd);
        }
    }
}
