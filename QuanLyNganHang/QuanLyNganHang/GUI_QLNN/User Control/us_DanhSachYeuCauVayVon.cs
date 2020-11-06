using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganHang.GUI_QLNN.GUI_NhanVienTinDung
{
    public partial class us_DanhSachYeuCauVayVon : UserControl
    {
        private static us_DanhSachYeuCauVayVon _instance;
        public static us_DanhSachYeuCauVayVon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_DanhSachYeuCauVayVon();
                return _instance;
            }
        }
        public us_DanhSachYeuCauVayVon()
        {
            InitializeComponent();
        }
    }
}
