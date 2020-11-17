using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class us_DanhSachKhachHang : UserControl
    {
        int 
        private static us_DanhSachKhachHang _instance;
        public static us_DanhSachKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_DanhSachKhachHang();
                return _instance;
            }
        }

        public us_DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void btnXuatThuThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
