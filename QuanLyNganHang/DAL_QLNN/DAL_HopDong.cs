using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNganHang.DAL_QLNN
{
    public class DAL_HopDong
    {
        private static DAL_HopDong _instance;
        public static DAL_HopDong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_HopDong();
                return _instance;
            }
        }

        public int getNextID()
        {
            int nextID = 1;

            string Query = String.Empty;
            Query += "SELECT TOP 1 maHopDong FROM HopDong ";
            Query += "ORDER BY maHopDong DESC";

            DataTable dt = HandleDB.Instance.ExecuteQuery(Query, null);
            if (dt.Rows.Count > 0)
            {
                Int32.TryParse(dt.Rows[0]["maHopDong"].ToString(), out nextID);
                ++nextID;
            }

            return nextID;
        }
        public static Boolean themHopDong(int idhd, int mayc)
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();

                string AddQuery = String.Empty;
                AddQuery += "SET IDENTITY_INSERT HopDong ON ";
                AddQuery += "INSERT INTO HopDong (maHopDong,maYeuCauVayVon) ";
                AddQuery += "VALUES (@mahd,@mayc) ";
                AddQuery += "SET IDENTITY_INSERT HopDong OFF";

                param.Add("@mahd", idhd.ToString());
                param.Add("@mayc", mayc.ToString());


                int result = HandleDB.Instance.ExecuteNonQuery(AddQuery, param);
                if (result > 0)
                {
                    MessageBox.Show("Lập hợp đồng thành công");
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
