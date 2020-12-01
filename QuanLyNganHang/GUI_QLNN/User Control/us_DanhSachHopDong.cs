using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNganHang.BUS_QLNN;
using QuanLyNganHang.GUI_QLNN.User_Control;

namespace QuanLyNganHang.GUI_QLNN
{
    public partial class us_DanhSachHopDong : UserControl
    {
        private static string tenkh;
        private static string cmnd;
        private static string mahd;
        private static string trangthai;
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

        private void us_DanhSachHopDong_Load(object sender, EventArgs e)
        {
            dgvDanhSachHD.DataSource = BUS_HopDong.Instance.getDanhSach();
        }

        private void tbCmnd_Click(object sender, EventArgs e)
        {
            tbCmnd.Clear();
            tbCmnd.ForeColor = System.Drawing.Color.Black;
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            btnSua.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = System.Drawing.Color.DarkRed;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (tbCmnd.Text != "")
                us_DanhSachHopDong.Instance.dgvDanhSachHD.DataSource = BUS_QLNN.BUS_HopDong.Instance.getDanhSach(int.Parse(tbCmnd.Text));
            else
                dgvDanhSachHD.DataSource = BUS_HopDong.Instance.getDanhSach();
        }

        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                cmnd = dgvDanhSachHD.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                tenkh = dgvDanhSachHD.Rows[e.RowIndex].Cells["name"].Value.ToString();
                mahd = dgvDanhSachHD.Rows[e.RowIndex].Cells["maHopDong"].Value.ToString();
                trangthai = dgvDanhSachHD.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
            }
        }

        private void dgvDanhSachHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                cmnd = dgvDanhSachHD.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                tenkh = dgvDanhSachHD.Rows[e.RowIndex].Cells["name"].Value.ToString();
                mahd = dgvDanhSachHD.Rows[e.RowIndex].Cells["maHopDong"].Value.ToString();
                trangthai = dgvDanhSachHD.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (mahd == null)
            {
                MessageBox.Show("Chưa chọn hợp đồng.");
                return;
            }
            frm_SuaHopDong frm = new frm_SuaHopDong();
            frm.MaHopDong = mahd;
            frm.Ten = tenkh;
            frm.cmnd = cmnd;
            frm.TrangThai = trangthai;
            frm.Show();
        }
    }
}
