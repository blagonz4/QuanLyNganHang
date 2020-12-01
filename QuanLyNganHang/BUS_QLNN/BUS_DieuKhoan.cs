using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNganHang.DAL_QLNN;
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.BUS_QLNN
{
    class BUS_DieuKhoan
    {
        private static BUS_DieuKhoan _instance;
        public static BUS_DieuKhoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_DieuKhoan();
                return _instance;
            }
        }
        public DataTable getDanhSach(int MaHopDong)
        {
            try
            {
                return DAL_DieuKhoan.Instance.getDanhSach(MaHopDong);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Boolean suaDieuKhoan(DTO_DieuKhoan dk)
        {
            bool themDK = DAL_DieuKhoan.Instance.themDieuKhoan(dk);
            bool themDCHD = DAL_DieuChinhHopDong.Instance.themDieuChinhHopDong(dk);
            return (themDK && themDCHD);
        }
    }
}
