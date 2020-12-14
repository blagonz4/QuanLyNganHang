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
    public partial class us_DanhSachYeuCauVayVon : UserControl
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

        private void btnsuaYeuCau_Click(object sender, EventArgs e)
        {

            frm_SuaYeuCauVayVon frm = new frm_SuaYeuCauVayVon();
            frm.tbKiHan.Text = KiHan;
            frm.tbLaiSuat.Text = LaiSuat;
            frm.tbMucDich.Text = MucDich;
            frm.tbNgayBatDau.Text = NgayBatDau;
            frm.tbSoTien.Text = SoTien;
            frm.tbThoiHan.Text = ThoiHan; 
            frm.tbTrangThai.Text = TrangThai;
            frm.tbCmnd.Text = cmnd;
            frm.tbMaYeuCau.Text = MaYeuCau;
            frm.Show();

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
                TrangThai = dgvDanhSachYCVV.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
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
