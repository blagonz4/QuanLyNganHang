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
            if (!pnlMainNVTD.Controls.Contains(us_TaoYeuCauVayVon.Instance))
            {
                pnlMainNVTD.Controls.Add(us_TaoYeuCauVayVon.Instance);
                us_TaoYeuCauVayVon.Instance.Dock = DockStyle.Fill;
                us_TaoYeuCauVayVon.Instance.BringToFront();
            }
            else
                us_TaoYeuCauVayVon.Instance.BringToFront();
        }

        private void btnLaphopdong_Click(object sender, EventArgs e)
        {
            //us_LapHopDong.Instance.dgvDanhSachYCVV.DataSource = BUS_QLNN.BUS_YeuCauVayVon.Instance.getDanhSach();

            if (!pnlMainNVTD.Controls.Contains(us_LapHopDong.Instance))
            {
                pnlMainNVTD.Controls.Add(us_LapHopDong.Instance);
                us_LapHopDong.Instance.Dock = DockStyle.Fill;
                us_LapHopDong.Instance.BringToFront();
            }
            else
                us_LapHopDong.Instance.BringToFront();
        }

        private void btnDanhsachycbihuy_Click(object sender, EventArgs e)
        {
            us_DanhSachYeuCauVayVon.Instance.dgvDanhSachYCVV.DataSource = BUS_QLNN.BUS_YeuCauVayVon.Instance.getDanhSach();

            if (!pnlMainNVTD.Controls.Contains(us_DanhSachYeuCauVayVon.Instance))
            {
                pnlMainNVTD.Controls.Add(us_DanhSachYeuCauVayVon.Instance);
                us_DanhSachYeuCauVayVon.Instance.Dock = DockStyle.Fill;
                us_DanhSachYeuCauVayVon.Instance.BringToFront();
            }
            else
                us_DanhSachYeuCauVayVon.Instance.BringToFront();
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

        private void frm_NhanVienTinDung_Load(object sender, EventArgs e)
        {
            if (!pnlMainNVTD.Controls.Contains(us_TaoYeuCauVayVon.Instance))
            {
                pnlMainNVTD.Controls.Add(us_TaoYeuCauVayVon.Instance);
                us_TaoYeuCauVayVon.Instance.Dock = DockStyle.Fill;
                us_TaoYeuCauVayVon.Instance.BringToFront();
            }
            else
                us_TaoYeuCauVayVon.Instance.BringToFront();
        }
    }
}
