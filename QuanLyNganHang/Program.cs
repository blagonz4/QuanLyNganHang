using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNganHang.GUI_QLNN;

namespace QuanLyNganHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_DangNhap());
            //Application.Run(new frm_BoPhanTaiChinh());
            Application.Run(new frm_BoPhanXetDuyet());
            //Application.Run(new frm_NhanVienTinDung());
            //Application.Run(new frm_QuanLyHopDong());
        }
    }
}
