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
        public Boolean suaYeuCau(DTO_YeuCauVayVon yc)
        {
            try
            {
            string UpdateQuery = "";
            UpdateQuery += "UPDATE YeuCauVayVon SET ";
            UpdateQuery += "mucDichVayVon = @MucDichVayVon, ";
            UpdateQuery += "thoiHanVay = @ThoiHanVay, ";
            UpdateQuery += "soTienVay = @SoTien, ";
            UpdateQuery += "kiHan = @KiHan,";
            UpdateQuery += "ngayBatDauVay = @Ngay, ";
            UpdateQuery += "laiSuat = @LaiSuat,";
            UpdateQuery += "trangThai = @TrangThai ";
            UpdateQuery += "WHERE maYeuCauVayVon = @MaYC ";
            //DataTable dt = ObjThuocBLL.Instance.GetInfoByName(((frmMain)main).tb_tenThuoc.Text);

            Dictionary<String, String> param = new Dictionary<string, string>();
            param.Add("@MucDichVayVon",yc.YCVV_mucdich);
            param.Add("@ThoiHanVay", yc.YCVV_thoiHanVay.ToString());
            param.Add("@SoTien", yc.YCVV_soTienVay.ToString());
            param.Add("@KiHan", yc.YCVV_kiHan.ToString());
            param.Add("@Ngay", yc.YCVV_ngayBatDauVay);
            param.Add("@LaiSuat", yc.YCVV_laisuat.ToString());
            param.Add("@TrangThai", yc.YCVV_trangThai.ToString());
            param.Add("@MaYC", yc.YCVV_maYeuCau.ToString());

            int result = HandleDB.Instance.ExecuteNonQuery(UpdateQuery, param);
            if (result > 0)
            {
                MessageBox.Show("Sửa yêu cầu thành công");
            }
            }
            catch(Exception err)
            {
                return false;
            }
            return true;
        }
    }
}
