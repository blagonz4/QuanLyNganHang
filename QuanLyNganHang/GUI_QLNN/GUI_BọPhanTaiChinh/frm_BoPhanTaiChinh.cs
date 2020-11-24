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
using QuanLyNganHang.DTO_QLNN;
using QuanLyNganHang.BUS_QLNN;

namespace QuanLyNganHang.GUI_QLNN
{
    public partial class frm_BoPhanTaiChinh : Form
    {
        public frm_BoPhanTaiChinh()
        {
            InitializeComponent();
        }
        private static frm_BoPhanTaiChinh _instance;
        public static frm_BoPhanTaiChinh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frm_BoPhanTaiChinh();
                return _instance;
            }
        }

        private void btnDanhsachkhachhang_Click(object sender, EventArgs e)
        {
            us_DanhSachKhachHang.Instance.dgvDanhSachKH.DataSource = BUS_KhachHang.Instance.getDanhSach();

            if (!pnlMainBPTC.Controls.Contains(us_DanhSachKhachHang.Instance))
            {
                pnlMainBPTC.Controls.Add(us_DanhSachKhachHang.Instance);
                us_DanhSachKhachHang.Instance.Dock = DockStyle.Fill;
                us_DanhSachKhachHang.Instance.BringToFront();
            }
            else
                us_DanhSachKhachHang.Instance.BringToFront();
        }

        private void frm_BoPhanTaiChinh_Load(object sender, EventArgs e)
        {
            us_DanhSachKhachHang.Instance.dgvDanhSachKH.DataSource = BUS_KhachHang.Instance.getDanhSach();

            if (!pnlMainBPTC.Controls.Contains(us_DanhSachKhachHang.Instance))
            {
                pnlMainBPTC.Controls.Add(us_DanhSachKhachHang.Instance);
                us_DanhSachKhachHang.Instance.Dock = DockStyle.Fill;
                us_DanhSachKhachHang.Instance.BringToFront();
            }
            else
                us_DanhSachKhachHang.Instance.BringToFront();
        }
    }
}
