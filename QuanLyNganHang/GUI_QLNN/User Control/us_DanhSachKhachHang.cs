using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using QuanLyNganHang.BUS_QLNN;

namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class us_DanhSachKhachHang : UserControl
    {
        private string cmnd = "";
        private string TenKhachHang;
        private string DiaChi;
        private string SoTienVay;
        private string ThoiHanVay;
        private string LaiSuat;
        private string MaHopDong;


        private static us_DanhSachKhachHang _instance;
        public static us_DanhSachKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_DanhSachKhachHang();
                return _instance;
            }
        }

        public us_DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void btnXuatThuThongBao_Click(object sender, EventArgs e)
        {
            if (cmnd == "")
                return;
            var words = new Dictionary<string, string>(); ;
            words.Add("<cmnd>", "12345");
            words.Add("<TenKhachHang>", "Nguyen Van A");
            try
            {
                ReplaceWord(words);
                MessageBox.Show("Thanh cong");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void ReplaceWord(Dictionary<string, string> words)
        {
            var WordApp = new Word.Application();
            WordApp.Visible = false;
            string FilePath = Application.StartupPath + @"/Mau/ThongBao/MauThongBaoNo.docx";
            Word.Document doc = WordApp.Documents.Open(FilePath);
            Word.Range range = doc.Content;
            foreach(KeyValuePair<string,string> word in words)
            {
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: word.Key, ReplaceWith: word.Value, Replace: Word.WdReplace.wdReplaceAll);
            }
            doc.ExportAsFixedFormat(Application.StartupPath + @"/Mau/ThongBao/" + words["<cmnd>"] + @"-ThongBaoNo", Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
            doc.Close(SaveChanges: Word.WdSaveOptions.wdDoNotSaveChanges);
        }

        private void us_DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            dgvDanhSachKH.DataSource = BUS_KhachHang.Instance.getDanhSach();
        }

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //  System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
                cmnd = dgvDanhSachKH.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                TenKhachHang = dgvDanhSachKH.Rows[e.RowIndex].Cells["name"].Value.ToString();
                DiaChi = dgvDanhSachKH.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                SoTienVay = dgvDanhSachKH.Rows[e.RowIndex].Cells["soTienVay"].Value.ToString();
                ThoiHanVay = dgvDanhSachKH.Rows[e.RowIndex].Cells["thoiHanVay"].Value.ToString();
                LaiSuat = dgvDanhSachKH.Rows[e.RowIndex].Cells["laiSuat"].Value.ToString();
                //MaHopDong = dgvDanhSachKH.Rows[e.RowIndex].Cells["thoiHanVay"].Value.ToString();

            }
        }

        private void tbCmnd_Click(object sender, EventArgs e)
        {
            tbCmnd.Clear();
            tbCmnd.ForeColor = System.Drawing.Color.Black;
        }

        private void btnXuatThuThongBao_MouseHover(object sender, EventArgs e)
        {
            btnXuatThuThongBao.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void btnXuatThuThongBao_MouseLeave(object sender, EventArgs e)
        {
            btnXuatThuThongBao.BackColor = System.Drawing.Color.DarkRed;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(tbCmnd.Text != "")
                us_DanhSachKhachHang.Instance.dgvDanhSachKH.DataSource = BUS_QLNN.BUS_KhachHang.Instance.findOne(int.Parse(tbCmnd.Text));
            else
                dgvDanhSachKH.DataSource = BUS_KhachHang.Instance.getDanhSach();
        }
    }
}
