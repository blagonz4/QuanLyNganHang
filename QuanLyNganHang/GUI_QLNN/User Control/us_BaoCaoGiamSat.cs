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
    public partial class us_BaoCaoGiamSat : UserControl
    {
        string linkfileBaoCao;
        private static us_BaoCaoGiamSat _instance;
        public static us_BaoCaoGiamSat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_BaoCaoGiamSat();
                return _instance;
            }
        }

        public us_BaoCaoGiamSat()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(linkfileBaoCao))
                System.Diagnostics.Process.Start(linkfileBaoCao);
            else
                MessageBox.Show("Lỗi: File không tồn tại.");
                
        }

        private void dgvDanhSachBCGS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index > 0)
                linkfileBaoCao = dgvDanhSachBCGS.Rows[e].Cells["linkFileBaoCao"];
        }

        private void btnXem_MouseHover(object sender, EventArgs e)
        {
            btnXem.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void btnXem_MouseLeave(object sender, EventArgs e)
        {
            btnXem.BackColor = System.Drawing.Color.DarkRed;
        }

        private void tbCmnd_Click(object sender, EventArgs e)
        {
            tbCmnd.Clear();
            tbCmnd.ForeColor = System.Drawing.Color.Black;
        }
    }
}
