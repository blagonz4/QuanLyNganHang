using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNganHang.BUS_QLNN;
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class frm_ChiTietVayVon : Form
    {
        public string MaYeuCau;
        public string KiHan;
        public string LaiSuat;
        public string MucDich;
        public string NgayBatDau;
        public string SoTien;
        public string ThoiHan;
        public string TrangThai;
        public string cmnd;
        public string Ten, DiaChi, SoDienThoai;

        public frm_ChiTietVayVon()
        {
            InitializeComponent();
        }

        private void frm_ChiTietVayVon_Load(object sender, EventArgs e)
        {
            this.lblLaiSuat.Text = "Lãi suất: " + LaiSuat;
            this.lblMucDichVay.Text = "Mục đích vay vốn: " + MucDich;
            this.lblNgayBatDau.Text = "Ngày bắt đầu vay vốn: " + NgayBatDau;
            this.lblSoTienVay.Text = "Số tiền vay: " + SoTien;
            this.lblThoiHanVay.Text = "Thời hạn vay: " + ThoiHan;
            this.lblKiHan.Text = "Kì hạn: " + KiHan;

            this.lblTenKhachHang.Text = "Tên khách hàng: " + Ten;
            this.lblSoDienThoai.Text = "Số điện thoại: " + SoDienThoai;
            this.lblDiaChi.Text = "Địa chỉ: " + DiaChi;
            this.lblCMND.Text = "CMND: " + cmnd;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận duyệt yêu cầu vay?", "Xác nhận duyệt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Sửa lại mã trạng thái của yêu cầu
                BUS_YeuCauVayVon.Instance.suaYeuCau(new DTO_YeuCauVayVon(int.Parse(MaYeuCau), cmnd, MucDich, int.Parse(ThoiHan), int.Parse(SoTien), int.Parse(KiHan), NgayBatDau, int.Parse(LaiSuat), 2));
                us_DuyetYeuCauVayVon.Instance.dgvDanhSachYCVV.DataSource = BUS_YeuCauVayVon.Instance.getDanhSach();
            }
            this.Close();
        }

        private void btnKhongDuyet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận không duyệt yêu cầu vay?", "Xác nhận không duyệt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Sửa lại mã trạng thái của yêu cầu
                BUS_YeuCauVayVon.Instance.suaYeuCau(new DTO_YeuCauVayVon(int.Parse(MaYeuCau), cmnd, MucDich, int.Parse(ThoiHan), int.Parse(SoTien), int.Parse(KiHan), NgayBatDau, int.Parse(LaiSuat), 5));
                us_DuyetYeuCauVayVon.Instance.dgvDanhSachYCVV.DataSource = BUS_YeuCauVayVon.Instance.getDanhSach();
            }
            this.Close();
        }
    }
}
