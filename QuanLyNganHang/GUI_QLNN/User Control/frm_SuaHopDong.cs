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
    public partial class frm_SuaHopDong : Form
    {
        public string MaHopDong;
        public string TrangThai;
        public string cmnd;
        public string Ten;
        private List<DTO_DieuKhoan> dksua = new List<DTO_DieuKhoan>();
        public frm_SuaHopDong()
        {
            InitializeComponent();
        }

        private void frm_SuaHopDong_Load(object sender, EventArgs e)
        {
            lblMaHopDong.Text = "Mã hợp đồng: " + MaHopDong;
            lblTrangThaiHopDong.Text = "Trạng thái hợp đồng: " + TrangThai;
            lblCMND.Text = "CMND: " + cmnd;
            lblTenKhachHang.Text = "Tên khách hàng: " + Ten;
            dgvDanhSachDieuKhoan.DataSource = BUS_DieuKhoan.Instance.getDanhSach(Convert.ToInt32(MaHopDong));
            dgvDanhSachDieuKhoan.Columns["maDieuKhoan"].ReadOnly = true;
            dksua.Clear();
        }

        private void dgvDanhSachDieuKhoan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int madk = Convert.ToInt32(dgvDanhSachDieuKhoan.Rows[e.RowIndex].Cells["maDieuKhoan"].Value.ToString());
            string noidung = dgvDanhSachDieuKhoan.Rows[e.RowIndex].Cells["noiDungDieuKhoan"].ToString();
            DTO_DieuKhoan dk = new DTO_DieuKhoan(madk, Convert.ToInt32(MaHopDong), noidung);
            dksua.Add(dk);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach(DTO_DieuKhoan dk in dksua)
            {
                BUS_DieuKhoan.Instance.suaDieuKhoan(dk);
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            BUS_HopDong.Instance.thanhLyHopDong(Convert.ToInt32(MaHopDong));
        }
    }
}
