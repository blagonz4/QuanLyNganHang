using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNganHang.DAL_QLNN;
using System.Data;

namespace QuanLyNganHang.BUS_QLNN
{
    public class BUS_HoSoVayNo
    {
        private static BUS_HoSoVayNo _instance;
        public static BUS_HoSoVayNo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_HoSoVayNo();
                return _instance;
            }
        }
        public DataTable getDanhSach(int maYeuCauVayVon)
        {
            try
            {
                return DAL_HoSoVayNo.Instance.getDanhSach(maYeuCauVayVon);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
