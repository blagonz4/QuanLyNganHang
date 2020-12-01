using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNganHang.GUI_QLNN.User_Control;

namespace QuanLyNganHang.GUI_QLNN
{
    public partial class frm_QuanLyHopDong : Form
    {
        public frm_QuanLyHopDong()
        {
            InitializeComponent();
        }

        private void btnBaocaogiamsat_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(us_BaoCaoGiamSat.Instance))
            {
                pnlMain.Controls.Add(us_BaoCaoGiamSat.Instance);
                us_BaoCaoGiamSat.Instance.Dock = DockStyle.Fill;
                us_BaoCaoGiamSat.Instance.BringToFront();
            }
            else
                us_BaoCaoGiamSat.Instance.BringToFront();
        }

        private void btnDanhsachkh_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(us_DanhSachKhachHang.Instance))
            {
                pnlMain.Controls.Add(us_DanhSachKhachHang.Instance);
                us_DanhSachKhachHang.Instance.Dock = DockStyle.Fill;
                us_DanhSachKhachHang.Instance.BringToFront();
            }
            else
                us_DanhSachKhachHang.Instance.BringToFront();
        }

        private void btnDanhsachhopdong_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(us_DanhSachHopDong.Instance))
            {
                pnlMain.Controls.Add(us_DanhSachHopDong.Instance);
                us_DanhSachHopDong.Instance.Dock = DockStyle.Fill;
                us_DanhSachHopDong.Instance.BringToFront();
            }
            else
                us_DanhSachHopDong.Instance.BringToFront();
        }

        private void btndanhsachycvv_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(us_DanhSachYeuCauVayVon.Instance))
            {
                pnlMain.Controls.Add(us_DanhSachYeuCauVayVon.Instance);
                us_DanhSachYeuCauVayVon.Instance.Dock = DockStyle.Fill;
                us_DanhSachYeuCauVayVon.Instance.BringToFront();
            }
            else
                us_DanhSachYeuCauVayVon.Instance.BringToFront();
        }
    }
}
