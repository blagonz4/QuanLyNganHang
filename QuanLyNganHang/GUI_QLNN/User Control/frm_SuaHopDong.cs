using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class frm_SuaHopDong : Form
    {
        public string MaHopDong;
        public string TrangThai;
        public string cmnd;
        public string Ten;
        public frm_SuaHopDong()
        {
            InitializeComponent();
        }

        private void frm_SuaHopDong_Load(object sender, EventArgs e)
        {
            lblMaHopDong.Text = "Mã hợp đồng: " + MaHopDong;
            lblTrangThaiHopDong.Text = "Trạng thái hợp đồng: " + TrangThai;
            lblCMND.Text = "CMND: " + cmnd;
            lblTenKhachHang.Text = "Tên khách hàng: " + Ten;
        }
    }
}
