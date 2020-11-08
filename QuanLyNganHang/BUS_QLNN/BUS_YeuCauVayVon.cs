using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNganHang.DAL_QLNN;
using QuanLyNganHang.DTO_QLNN;
namespace QuanLyNganHang.BUS_QLNN
{
    class BUS_YeuCauVayVon
    {
        private static BUS_YeuCauVayVon _instance;
        public static BUS_YeuCauVayVon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_YeuCauVayVon();
                return _instance;
            }
        }
        //DAL_QLNN.DAL_YeuCauVayVon YeuCau = new DAL_QLNN.DAL_YeuCauVayVon();
        public void themYeuCau(DTO_YeuCauVayVon yc)
        {
            DAL_YeuCauVayVon.Instance.themYeuCau(yc);
        }
    }
}
