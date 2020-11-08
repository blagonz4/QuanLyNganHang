using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNganHang.DTO_QLNN;

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
        public void themKhachHang(DTO_KhachHang kh)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();

            string AddQuery = String.Empty;
            AddQuery += "INSERT INTO KhachHang ( cmnd,name, diachi, phone) ";
            AddQuery += "VALUES (@cmnd,@name,@diachi,@phone)";


            param.Add("@cmnd", kh.KhachHang_cmnd.ToString());
            param.Add("@name", kh.KhachHang_name);
            param.Add("@diachi", kh.KhachHang_diachi);
            param.Add("@phone", kh.KhachHang_phone.ToString());


            int result = HandleDB.Instance.ExecuteNonQuery(AddQuery, param);
            if (result > 0)
            {
                Console.WriteLine("Thêm khách hàng thành công");
            }
        }
    }
}
