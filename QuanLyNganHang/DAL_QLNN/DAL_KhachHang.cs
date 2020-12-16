using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNganHang.DTO_QLNN;
using QuanLyNganHang.BUS_QLNN;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNganHang.DAL_QLNN
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang _instance;
        public static DAL_KhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_KhachHang();
                return _instance;
            }
        }
        public bool themKhachHang(DTO_KhachHang kh)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();

            string AddQuery = String.Empty;
            AddQuery += "INSERT INTO KhachHang ( cmnd,name, diachi, phone) ";
            AddQuery += "VALUES (@cmnd,@name,@diachi,@phone)";


            param.Add("@cmnd", kh.KhachHang_cmnd.ToString());
            param.Add("@name", kh.KhachHang_name);
            param.Add("@diachi", kh.KhachHang_diachi);
            param.Add("@phone", kh.KhachHang_phone);


            int result = HandleDB.Instance.ExecuteNonQuery(AddQuery, param);
            if (result > 0)
            {
                Console.WriteLine("Thêm khách hàng thành công");
                return true;
            }
            return false;
        }
        public DataTable getDanhSach()
        {
            try
            {
                DataTable dt = new DataTable();

                string LoadQuery = "select KhachHang.cmnd,name,phone,diachi,maHopDong,ngayBatDauVay,kiHan,soTienVay,laiSuat"+
                                    " from KhachHang,YeuCauVayVon,HopDong"+
                                    " where KhachHang.cmnd = YeuCauVayVon.cmnd and" +
                                           " YeuCauVayVon.maYeuCauVayVon = HopDong.maYeuCauVayVon;" ;
                dt = HandleDB.Instance.ExecuteQuery(LoadQuery, null);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public DTO_KhachHang findOne(string cmnd)
        {
            try
            {
            DataTable dt = new DataTable();

            Dictionary<string, string> param = new Dictionary<string, string>();

            string FindQuery = "select cmnd,name,diachi,phone from KhachHang where cmnd = @cmnd";
            param.Add("@cmnd", cmnd);

            dt = HandleDB.Instance.ExecuteQuery(FindQuery, param);

            DataRow firstrow = dt.Rows.Cast<DataRow>().FirstOrDefault();
            DTO_KhachHang result = new DTO_KhachHang(firstrow["cmnd"].ToString(), firstrow["name"].ToString(), firstrow["diachi"].ToString(),firstrow["phone"].ToString());
            
            return result;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }



    }
}
