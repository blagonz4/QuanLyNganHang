using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganHang.GUI_QLNN.GUI_QuanLyHopDong
{
    public partial class us_DanhSachHopDong : UserControl
    {
        private static us_DanhSachHopDong _instance;
        public static us_DanhSachHopDong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_DanhSachHopDong();
                return _instance;
            }
        }

        public us_DanhSachHopDong()
        {
            InitializeComponent();
        }
    }
}
