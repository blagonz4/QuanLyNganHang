using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyNganHang.DTO_QLNN;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNganHang.DAL_QLNN
{
    public class DAL_YeuCauVayVon 
    {
        private static DAL_YeuCauVayVon _instance;
        public static DAL_YeuCauVayVon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_YeuCauVayVon ();
                return _instance;
            }
        }
        public void themYeuCau(DTO_YeuCauVayVon yc)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();

            string AddQuery = String.Empty;
            AddQuery += "INSERT INTO YeuCauVayVon ( cmnd,mucDichVayVon, thoiHanVay, soTienVay, kiHan, ngayBatDauVay, laiSuat,trangThai) ";
            AddQuery += "VALUES (@cmnd,@mucDichVayVon,@thoiHanVay,@soTienVay,@kiHan,@ngayBatDauVay,@laiSuat,@trangThai)";

            //param.Add("@maYeuCauVayVon", yc.YCVV_maYeuCau.ToString());
            param.Add("@cmnd", yc.YCVV_cmnd);
            param.Add("@mucDichVayVon", yc.YCVV_mucdich);
            param.Add("@thoiHanVay", yc.YCVV_thoiHanVay.ToString());
            param.Add("@soTienVay", yc.YCVV_soTienVay.ToString());
            param.Add("@kiHan", yc.YCVV_kiHan.ToString());
            param.Add("@ngayBatDauVay", yc.YCVV_ngayBatDauVay.ToString());
            param.Add("@laiSuat", yc.YCVV_laisuat.ToString());
            param.Add("@trangThai", yc.YCVV_trangThai.ToString());

            int result = HandleDB.Instance.ExecuteNonQuery(AddQuery, param);
            if (result > 0)
            {
                Console.WriteLine("Thêm YCVV thành công");
            }
        }
        public DataTable getDanhSach()
        {
            DataTable dt = new DataTable();
               
            string LoadQuery = "SELECT * FROM YeuCauVayVon";
            dt = HandleDB.Instance.ExecuteQuery(LoadQuery, null);
            return dt;
        }
    }
}
