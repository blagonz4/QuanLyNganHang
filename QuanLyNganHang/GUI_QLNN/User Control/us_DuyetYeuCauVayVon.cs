using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNganHang.DTO_QLNN;
using QuanLyNganHang.BUS_QLNN;

namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class us_DuyetYeuCauVayVon : UserControl
    {
        public static string MaYeuCau;
        public static string KiHan;
        public static string LaiSuat;
        public static string MucDich;
        public static string NgayBatDau;
        public static string SoTien;
        public static string ThoiHan;
        public static string TrangThai;
        public static string cmnd;


        private static us_DuyetYeuCauVayVon _instance;
        public static us_DuyetYeuCauVayVon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_DuyetYeuCauVayVon();
                return _instance;
            }
        }

        public us_DuyetYeuCauVayVon()
        {
            InitializeComponent();
        }

        private void btnXem_click(object sender, EventArgs e)
        {
            if (cmnd == null)
            {
                MessageBox.Show("Chưa chọn yêu cầu.");
                return;
            }

            frm_ChiTietVayVon frm = new frm_ChiTietVayVon();

            DTO_KhachHang kh = BUS_KhachHang.Instance.findOne(int.Parse(cmnd));

            //frm.lblLaiSuat.Text = "Lãi suất: " + LaiSuat;
            //frm.lblMucDichVay.Text = "Mục đích vay vốn: " + MucDich;
            //frm.lblNgayBatDau.Text = "Ngày bắt đầu vay vốn: " + NgayBatDau;
            //frm.lblSoTienVay.Text = "Số tiền vay: " + SoTien;
            //frm.lblThoiHanVay.Text = "Thời hạn vay: " + ThoiHan;
            //frm.lblKiHan.Text = "Kì hạn: " + KiHan;

            //frm.lblTenKhachHang.Text = "Tên khách hàng: " + kh.KhachHang_name;
            //frm.lblSoDienThoai.Text = "Số điện thoại: " + kh.KhachHang_phone;
            //frm.lblDiaChi.Text = "Địa chỉ: " + kh.KhachHang_diachi;
            //frm.lblCMND.Text = "CMND: " + cmnd;

            frm.MaYeuCau = MaYeuCau;
            frm.KiHan = KiHan;
            frm.LaiSuat = LaiSuat;
            frm.MucDich = MucDich;
            frm.NgayBatDau = NgayBatDau;
            frm.SoTien = SoTien;
            frm.ThoiHan = ThoiHan;
            frm.TrangThai = TrangThai;
            frm.cmnd = cmnd;
            frm.Ten = kh.KhachHang_name;
            frm.SoDienThoai = kh.KhachHang_phone.ToString();
            frm.DiaChi = kh.KhachHang_diachi;

            //frm.dgvDanhSachHoSoVay.DataSource = BUS_HoSoVayNo.Instance.getDanhSach(int.Parse(MaYeuCau));

            frm.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(tbCmnd.Text != "")
                us_DuyetYeuCauVayVon.Instance.dgvDanhSachYCVV.DataSource = BUS_QLNN.BUS_YeuCauVayVon.Instance.findOne(tbCmnd.Text);
            else
                us_DuyetYeuCauVayVon.Instance.dgvDanhSachYCVV.DataSource = BUS_QLNN.BUS_YeuCauVayVon.Instance.getDanhSach();
        }

        private void dgvDanhSachYCVV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //  System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
                cmnd = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                KiHan = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["kiHan"].Value.ToString();
                LaiSuat = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["laiSuat"].Value.ToString();
                MucDich = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["mucDichVayVon"].Value.ToString();
                NgayBatDau = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["ngayBatDauVay"].Value.ToString();
                SoTien = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["soTienVay"].Value.ToString();
                ThoiHan = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["thoiHanVay"].Value.ToString();
                //TrangThai = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
                MaYeuCau = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["maYeuCauVayVon"].Value.ToString();
            }

        }

        private void dgvDanhSachYCVV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //  System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
                cmnd = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                MaYeuCau = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["maYeuCauVayVon"].Value.ToString();
                KiHan = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["kiHan"].Value.ToString();
                LaiSuat = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["laiSuat"].Value.ToString();
                MucDich = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["mucDichVayVon"].Value.ToString();
                NgayBatDau = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["ngayBatDauVay"].Value.ToString();
                SoTien = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["soTienVay"].Value.ToString();
                ThoiHan = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["thoiHanVay"].Value.ToString();
                //TrangThai = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
            }
        }
    }
}
