using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNganHang.DAL_QLNN
{
    class DAL_BaoCaoGiamSat
    {
        private static DAL_BaoCaoGiamSat _instance;
        public static DAL_BaoCaoGiamSat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_BaoCaoGiamSat();
                return _instance;
            }
        }
        public DataTable getDanhSach()
        {
            try
            {
                DataTable dt = new DataTable();

                string LoadQuery = "select maBaoCaoGiamSat,cmnd,linkFileBaoCao from BaoCaoGiamSat";
                dt = HandleDB.Instance.ExecuteQuery(LoadQuery, null);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable getDanhSach(int cmnd)
        {
            try
            {
                DataTable dt = new DataTable();
                
                Dictionary<string, string> param = new Dictionary<string, string>();

                string LoadQuery = "select maBaoCaoGiamSat,cmnd,linkFileBaoCao from BaoCaoGiamSat where cmnd = @cmnd";
                param.Add("@cmnd", cmnd.ToString());

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
