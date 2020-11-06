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
    public partial class us_BaoCaoGiamSat : UserControl
    {
        private static us_BaoCaoGiamSat _instance;
        public static us_BaoCaoGiamSat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_BaoCaoGiamSat();
                return _instance;
            }
        }

        public us_BaoCaoGiamSat()
        {
            InitializeComponent();
        }
    }
}
