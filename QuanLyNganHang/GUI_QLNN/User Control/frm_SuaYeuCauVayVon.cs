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
    public partial class frm_SuaYeuCauVayVon : Form
    {
        private static frm_SuaYeuCauVayVon instance;
        public static frm_SuaYeuCauVayVon Instance
        {
            get
            {
                if (instance == null)
                    instance = new frm_SuaYeuCauVayVon();
                return instance;
            }
            set { instance = value; }
        }

        public frm_SuaYeuCauVayVon()
        {
            InitializeComponent();
        }

        private void frm_SuaYeuCauVayVon_Load(object sender, EventArgs e)
        {
            tbCmnd.ReadOnly = true;
            tbMaYeuCau.ReadOnly = true;
        }

        private void frm_SuaYeuCauVayVon_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_SuaYeuCauVayVon.Instance.Hide();
        }

        private void btnTaoYeuCau_Click(object sender, EventArgs e)
        {
            int KH_cmnd;
            Int32.TryParse(tbCmnd.Text, out KH_cmnd);
            int YCVV_maYeuCau;
            Int32.TryParse(tbMaYeuCau.Text, out YCVV_maYeuCau);
            string YCVV_mucdich = tbMucDich.Text;
            int YCVV_thoiHanVay;
            Int32.TryParse(tbThoiHan.Text, out YCVV_thoiHanVay);
            int YCVV_soTienVay;
            Int32.TryParse(tbSoTien.Text, out YCVV_soTienVay);
            int YCVV_kiHan;
            Int32.TryParse(tbKiHan.Text, out YCVV_kiHan);
            string YCVV_ngayBatDauVay = tbNgayBatDau.Text;
            int YCVV_laisuat_int;
            Int32.TryParse(tbLaiSuat.Text, out YCVV_laisuat_int);
            float YCVV_laisuat = YCVV_laisuat_int / 1024;
            int YCVV_trangThai;
            Int32.TryParse(tbTrangThai.Text, out YCVV_trangThai);
            DTO_YeuCauVayVon yc = new DTO_YeuCauVayVon(YCVV_maYeuCau,
                                                       KH_cmnd.ToString(),
                                                       YCVV_mucdich,
                                                       YCVV_thoiHanVay,
                                                       YCVV_soTienVay,
                                                       YCVV_kiHan,
                                                       YCVV_ngayBatDauVay,
                                                       YCVV_laisuat,
                                                       YCVV_trangThai);
            if (BUS_YeuCauVayVon.Instance.suaYeuCau(yc))
                MessageBox.Show("Sua yeu cau thanh cong");
        }
    }
}

