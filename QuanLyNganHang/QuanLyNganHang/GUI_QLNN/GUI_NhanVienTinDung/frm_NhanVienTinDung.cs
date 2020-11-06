using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyNganHang.GUI_QLNN.User_Control;

namespace QuanLyNganHang.GUI_QLNN
{
    public partial class frm_NhanVienTinDung : Form
    {
        public frm_NhanVienTinDung()
        {
            InitializeComponent();
        }

        private void btnTaoyeucauvayvon_Click(object sender, EventArgs e)
        {

        }

        private void btnLaphopdong_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhsachycbihuy_Click(object sender, EventArgs e)
        {

        }

        private void btnLapbaocaogiamsat_Click(object sender, EventArgs e)
        {
            if (!pnlMainNVTD.Controls.Contains(us_BaoCaoGiamSat.Instance))
            {
                pnlMainNVTD.Controls.Add(us_BaoCaoGiamSat.Instance);
                us_BaoCaoGiamSat.Instance.Dock = DockStyle.Fill;
                us_BaoCaoGiamSat.Instance.BringToFront();
            }
            else
                us_BaoCaoGiamSat.Instance.BringToFront();
        }
    }
}
