using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.DAL_QLNN
{
    class DAL_DieuChinhHopDong
    {
        private static DAL_DieuChinhHopDong _instance;
        public static DAL_DieuChinhHopDong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_DieuChinhHopDong();
                return _instance;
            }
        }
        public int getNextID()
        {
            int nextID = 1;

            string Query = String.Empty;
            Query += "SELECT TOP 1 maDieuChinhHopDong FROM MaDieuChinhHopDong ";
            Query += "ORDER BY maDieuChinhHopDong DESC";

            DataTable dt = HandleDB.Instance.ExecuteQuery(Query, null);
            if (dt.Rows.Count > 0)
            {
                Int32.TryParse(dt.Rows[0]["maDieuChinhHopDong"].ToString(), out nextID);
                ++nextID;
            }

            return nextID;
        }
        public bool themDieuChinhHopDong(DTO_DieuKhoan dk)
        {
            int madchd = getNextID();
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string AddQuery = String.Empty;
                AddQuery += "SET IDENTITY_INSERT DieuChinhHopDong ON ";
                AddQuery += "INSERT INTO DieuChinhHopDong (maDieuChinhHopDong,maHopDong,maDieuKhoan) ";
                AddQuery += "VALUES (@madchd,@mahd,@madk) ";
                AddQuery += "SET IDENTITY_INSERT DieuChinhHopDong OFF";

                param.Add("@madk", madchd.ToString());
                param.Add("@mahd", dk.DieuKhoan_maHopDong.ToString());
                param.Add("@nddk", dk.DieuKhoan_maDieuKhoan.ToString());


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
