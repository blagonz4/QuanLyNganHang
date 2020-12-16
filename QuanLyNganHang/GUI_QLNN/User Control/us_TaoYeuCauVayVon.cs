using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QuanLyNganHang.BUS_QLNN;
using QuanLyNganHang.DTO_QLNN;

namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class us_TaoYeuCauVayVon : UserControl
    {
        private static us_TaoYeuCauVayVon _instance;
        private bool _validate = false;
        private bool _validateResult = true;
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
            string KH_cmnd = tbCmnd_KhachHang.Text;
            if(BUS_KhachHang.Instance.findOne(KH_cmnd) == null)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                return;
            }
            
            int YCVV_maYeuCau;
            Int32.TryParse(tbMaYeuCau.Text, out YCVV_maYeuCau);
            string YCVV_mucdich = tbMucDich.Text;
            int YCVV_thoiHanVay;
            Int32.TryParse(cbThoiHan.Text, out YCVV_thoiHanVay);
            long YCVV_soTienVay = Convert.ToInt64(nmSoTien.Value);
            int YCVV_kiHan;
            Int32.TryParse(cbKiHan.Text, out YCVV_kiHan);
            string YCVV_ngayBatDauVay = dtpNgayBatDau.Value.ToShortDateString();
            float YCVV_laisuat_float = (float)nmLaiSuat.Value;
            //float YCVV_laisuat = YCVV_laisuat_int / 1024;
            int YCVV_trangThai = 1;
            //Int32.TryParse(tbTrangThai.Text, out YCVV_trangThai);
            DTO_YeuCauVayVon yc = new DTO_YeuCauVayVon(YCVV_maYeuCau,
                                                       KH_cmnd.ToString(),
                                                       YCVV_mucdich,
                                                       YCVV_thoiHanVay,
                                                       YCVV_soTienVay,
                                                       YCVV_kiHan,
                                                       YCVV_ngayBatDauVay,
                                                       YCVV_laisuat_float,
                                                       YCVV_trangThai);
            BUS_YeuCauVayVon.Instance.themYeuCau(yc);
        }
        private void btnTaoYeuCau_Click(object sender, EventArgs e)
        {
            _validate = true;
            ValidateChildren(ValidationConstraints.Visible);
            _validate = false;
            if (!_validateResult)
            {
                MessageBox.Show("Thông tin không hợp lệ");
                _validateResult = true;
                return;
            }

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

        private void tbHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = "";
            if (String.IsNullOrWhiteSpace(tbHoTen.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (tbHoTen.Text.Length > 255)
                {
                    error = "Không được quá 255 kí tự";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(tbHoTen.Text, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"))
                {
                    error = "Tên có kí tự không hợp lệ";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }    
            }
            errorProvider1.SetError(tbHoTen, error);
        }

        private void tbCmnd_KhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(tbCmnd_KhachHang.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (!Regex.IsMatch(tbCmnd_KhachHang.Text, @"^([0-9]{9})$|^([0-9]{12})$"))
                {
                    error = "Số chứng minh nhân dân không hợp lệ";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }
            }
            errorProvider1.SetError(tbCmnd_KhachHang, error);
        }

        private void tbDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(tbDiaChi.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (tbDiaChi.Text.Length > 255)
                {
                    error = "Không được quá 255 kí tự";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }
            }
            errorProvider1.SetError(tbDiaChi, error);
        }

        private void tbSdt_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(tbSdt.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (!Regex.IsMatch(tbSdt.Text, @"^([0-9]{8})$"))
                {
                    error = "Số điện thoại không hợp lệ";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }
            }
            errorProvider1.SetError(tbSdt, error);
        }

        private void tbMucDich_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(tbMucDich.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (tbMucDich.Text.Length > 255)
                {
                    error = "Không được quá 255 kí tự";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }
            }
            errorProvider1.SetError(tbMucDich, error);
        }

        private void cbKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            lbTenKhachHang.Visible = !lbTenKhachHang.Visible;
            lbDiaChi.Visible = !lbDiaChi.Visible;
            lbSdt.Visible = !lbSdt.Visible;

            tbHoTen.Visible = !tbHoTen.Visible;
            tbDiaChi.Visible = !tbDiaChi.Visible;
            tbSdt.Visible = !tbSdt.Visible;
        }

        private void cbKiHan_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(cbKiHan.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                //e.Cancel = false;
                //return;
            }
            errorProvider1.SetError(cbKiHan, error);
        }

        private void cbThoiHan_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(cbThoiHan.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                //e.Cancel = false;
                //return;
            }
            errorProvider1.SetError(cbThoiHan, error);
        }


        private void nmSoTien_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(nmSoTien.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (nmSoTien.Value < 1000000)
                {
                    error = "Số tiền tối thiểu là 1.000.000";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else if (nmSoTien.Value > 100000000000)
                {
                    error = "Số tiền tối đa là 100.000.000.000";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }
            }
            errorProvider1.SetError(nmSoTien, error);
        }

        private void dtpNgayBatDau_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(dtpNgayBatDau.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (dtpNgayBatDau.Value < DateTime.Now)
                {
                    error = "Ngày không hợp lệ";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }
            }
            errorProvider1.SetError(dtpNgayBatDau, error);
        }

        private void nmLaiSuat_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if (String.IsNullOrWhiteSpace(nmLaiSuat.Text))
            {
                error = "Không được để trống";
                _validateResult = false;
                //e.Cancel = true;
            }
            else
            {
                if (nmLaiSuat.Value > (decimal)1.67)
                {
                    error = "Lãi suất không được quá 1.67";
                    _validateResult = false;
                    //e.Cancel = true;
                }
                else
                {
                    //e.Cancel = false;
                    //return;
                }
            }
            errorProvider1.SetError(nmLaiSuat, error);
        }
    }
}
