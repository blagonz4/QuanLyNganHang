using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.DAL_QLNN
{
    class DAL_DieuKhoan
    {
        private static DAL_DieuKhoan _instance;
        public static DAL_DieuKhoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_DieuKhoan();
                return _instance;
            }
        }
        public DataTable getDanhSach(int MaHopDong)
        {
            try
            {
                DataTable dt = new DataTable();

                Dictionary<string, string> param = new Dictionary<string, string>();

                string LoadQuery = "select maDieuKhoan, noiDungDieuKhoan " +
                                    "from DieuKhoan " +
                                    "where DieuKhoan.maHopDong = @maHopDong";

                param.Add("@maHopDong", MaHopDong.ToString());

                dt = HandleDB.Instance.ExecuteQuery(LoadQuery, param);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Boolean themDieuKhoan(DTO_DieuKhoan dk)
        {
            
        }
    }
}
