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
    public partial class us_DanhSachYeuCauVayVon : UserControl
    {
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

        private void btnTaoYeuCau_Click(object sender, EventArgs e)
        {
            int KH_cmnd;
            Int32.TryParse(tbCmnd_KhachHang.ToString(),out KH_cmnd);
            if (cbKhachHang.Checked == true)
            {
                int YCVV_maYeuCau;
                Int32.TryParse(tbMaYeuCau.ToString(), out YCVV_maYeuCau);                
                string YCVV_mucdich = tbMucDich.ToString();
                int YCVV_thoiHanVay;
                Int32.TryParse(tbThoiHan.ToString(), out YCVV_thoiHanVay);
                int YCVV_soTienVay;
                Int32.TryParse(tbSoTien.ToString(), out YCVV_soTienVay);
                int YCVV_kiHan;
                Int32.TryParse(tbKiHan.ToString(), out YCVV_kiHan);
                string YCVV_ngayBatDauVay = tbNgayBatDau.ToString();
                int YCVV_laisuat_int;
                Int32.TryParse(tbLaiSuat.ToString(), out (YCVV_laisuat_int));
                float YCVV_laisuat = YCVV_laisuat_int / 1024;
                int YCVV_trangThai;
                Int32.TryParse(tbTrangThai.ToString(), out YCVV_trangThai);
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
            else
            {
                string KH_hoTen = tbHoTen.ToString();
                string KH_diaChi = tbDiaChi.ToString();
                int KH_sdt;
                Int32.TryParse(tbLaiSuat.ToString(), out (KH_sdt));
                DTO_KhachHang kh = new DTO_KhachHang(KH_cmnd,
                                                     KH_hoTen,
                                                     KH_diaChi,
                                                     KH_sdt);
                BUS_KhachHang.Instance.themKhachHang(kh);
            }
            
        }
    }
}
