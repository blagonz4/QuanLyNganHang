using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.DAL_QLNN
{
    class DAL_HoSoVayNo
    {
        private static DAL_HoSoVayNo _instance;
        public static DAL_HoSoVayNo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_HoSoVayNo();
                return _instance;
            }
        }
        public DataTable getDanhSach(int maYeuCauVayVon)
        {
            try
            {
                DataTable dt = new DataTable();

                Dictionary<string, string> param = new Dictionary<string, string>();

                string LoadQuery = "select maHoSoVayVon, linkFileHoSo " +
                                    "from HoSoVayVon " +
                                    "where HoSoVayVon.maYeuCauVayVon = @maYeuCauVayVon";

                param.Add("@maYeuCauVayVon", maYeuCauVayVon.ToString());

                dt = HandleDB.Instance.ExecuteQuery(LoadQuery, param);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
