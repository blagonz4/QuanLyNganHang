using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNganHang.GUI_QLNN.User_Control;
using QuanLyNganHang.BUS_QLNN;

namespace QuanLyNganHang.GUI_QLNN
{
    public partial class frm_BoPhanXetDuyet : Form
    {
        public frm_BoPhanXetDuyet()
        {
            InitializeComponent();
        }

        private void frm_BoPhanXetDuyet_Load(object sender, EventArgs e)
        {
            us_DuyetYeuCauVayVon.Instance.dgvDanhSachYCVV.DataSource = BUS_KhachHang.Instance.getDanhSach();

            if (!pnlMainBPXD.Controls.Contains(us_DuyetYeuCauVayVon.Instance))
            {
                pnlMainBPXD.Controls.Add(us_DuyetYeuCauVayVon.Instance);
                us_DuyetYeuCauVayVon.Instance.Dock = DockStyle.Fill;
                us_DuyetYeuCauVayVon.Instance.BringToFront();
            }
            else
                us_DuyetYeuCauVayVon.Instance.BringToFront();
            this.Size = new Size(pnlMainBPXD.Location.X + pnlMainBPXD.Width + 25, pnlMainBPXD.Location.Y + pnlMainBPXD.Height + 50);
        }
    }
}
