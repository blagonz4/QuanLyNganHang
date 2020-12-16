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
        private bool _validate = false;
        private bool _validateResult = true;
        private static frm_SuaYeuCauVayVon instance;
        public int maTrangThai;
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
            _validate = true;
            ValidateChildren(ValidationConstraints.Enabled);
            _validate = false;
            if (!_validateResult)
            {
                MessageBox.Show("Thông tin không hợp lệ!");
                _validateResult = true;
                return;
            }

            int KH_cmnd;
            Int32.TryParse(tbCmnd.Text, out KH_cmnd);
            int YCVV_maYeuCau;
            Int32.TryParse(tbMaYeuCau.Text, out YCVV_maYeuCau);
            string YCVV_mucdich = tbMucDich.Text;
            int YCVV_thoiHanVay;
            Int32.TryParse(cbThoiHan.Text, out YCVV_thoiHanVay);
            long YCVV_soTienVay = Convert.ToInt64(nmSoTien.Value);
            int YCVV_kiHan;
            Int32.TryParse(cbKiHan.Text, out YCVV_kiHan);
            string YCVV_ngayBatDauVay = dtpNgayBatDau.Text;
            float YCVV_laisuat_float = (float)nmLaiSuat.Value;
            //float YCVV_laisuat = YCVV_laisuat_float / 1024;
            DTO_YeuCauVayVon yc = new DTO_YeuCauVayVon(YCVV_maYeuCau,
                                                       KH_cmnd.ToString(),
                                                       YCVV_mucdich,
                                                       YCVV_thoiHanVay,
                                                       YCVV_soTienVay,
                                                       YCVV_kiHan,
                                                       YCVV_ngayBatDauVay,
                                                       YCVV_laisuat_float,
                                                       maTrangThai);
            BUS_YeuCauVayVon.Instance.suaYeuCau(yc);
            us_DanhSachYeuCauVayVon.Instance.dgvDanhSachYCVV.DataSource = BUS_QLNN.BUS_YeuCauVayVon.Instance.getDanhSach();
            this.Hide();
        }

        private void tbMucDich_Validating(object sender, CancelEventArgs e)
        {
            if (!_validate)
                return;
            string error = null;
            if(String.IsNullOrWhiteSpace(tbMucDich.Text))
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
                if(nmSoTien.Value < 1000000)
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
                if (dtpNgayBatDau.Value < DateTime.Parse("1/1/2020"))
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

