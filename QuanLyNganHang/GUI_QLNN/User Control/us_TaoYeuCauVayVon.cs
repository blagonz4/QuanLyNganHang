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
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class us_TaoYeuCauVayVon : UserControl
    {
        private static us_TaoYeuCauVayVon _instance;
        public static us_TaoYeuCauVayVon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_TaoYeuCauVayVon();
                return _instance;
            }
        }
        public us_TaoYeuCauVayVon()
        {
            InitializeComponent();
        }
        public void event_themYeuCau()
        {
            int KH_cmnd;
            Int32.TryParse(tbCmnd_KhachHang.Text, out KH_cmnd);
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
            BUS_YeuCauVayVon.Instance.themYeuCau(yc);
        }
        private void btnTaoYeuCau_Click(object sender, EventArgs e)
        {
            
            if (cbKhachHang.Checked == true)
            {
                event_themYeuCau();
            }
            else
            {
                string KH_cmnd = tbCmnd_KhachHang.Text;
                string KH_hoTen = tbHoTen.Text;
                string KH_diaChi = tbDiaChi.Text;
                string KH_sdt = tbSdt.Text;
                DTO_KhachHang kh = new DTO_KhachHang(KH_cmnd,
                                                     KH_hoTen,
                                                     KH_diaChi,
                                                     KH_sdt);
                BUS_KhachHang.Instance.themKhachHang(kh);                
                event_themYeuCau();
            }
            

        }
    }
}
