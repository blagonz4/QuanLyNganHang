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
                                    "where DieuKhoan.maHopDong = @maHopDong" +
                                    "and maDieuKhoan NOT IN (SELECT maDieuKhoan FROM DieuChinhHopDong)";

                param.Add("@maHopDong", MaHopDong.ToString());

                dt = HandleDB.Instance.ExecuteQuery(LoadQuery, param);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int getNextID()
        {
            int nextID = 1;

            string Query = String.Empty;
            Query += "SELECT TOP 1 maDieuKhoan FROM MaDieuKhoan ";
            Query += "ORDER BY maDieuKhoan DESC";

            DataTable dt = HandleDB.Instance.ExecuteQuery(Query, null);
            if (dt.Rows.Count > 0)
            {
                Int32.TryParse(dt.Rows[0]["maDieuKhoan"].ToString(), out nextID);
                ++nextID;
            }

            return nextID;
        }
        public Boolean themDieuKhoan(DTO_DieuKhoan dk)
        {
            int madk = getNextID();
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string AddQuery = String.Empty;
                AddQuery += "SET IDENTITY_INSERT DieuKhoan ON ";
                AddQuery += "INSERT INTO DieuKhoan (maDieuKhoan,maHopDong,noiDungDieuKhoan) ";
                AddQuery += "VALUES (@madk,@mahd,@nddk) ";
                AddQuery += "SET IDENTITY_INSERT DieuKhoan OFF";

                param.Add("@madk", madk.ToString());
                param.Add("@mahd", dk.DieuKhoan_maHopDong.ToString());
                param.Add("@nddk", dk.DieuKhoan_noiDungDieuKhoan);


                int result = HandleDB.Instance.ExecuteNonQuery(AddQuery, param);
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }
    }
}
