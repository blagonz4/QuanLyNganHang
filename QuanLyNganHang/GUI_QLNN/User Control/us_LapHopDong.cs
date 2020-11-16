using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyNganHang.BUS_QLNN;
using QuanLyNganHang.DTO_QLNN;
using System.Drawing.Printing;
using System.IO;
using SautinSoft.Document;
using System.Linq;




namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    public partial class us_LapHopDong : UserControl
    {
        private static string cmnd;
        private static string name;
        private static string diachi;
        private static string phone;
        private static string mayc;
        private static string sotien;
        private static string ngaybd;
        private static string thoihan;
        private static string laisuat;
        private static string mucdich;

        private static us_LapHopDong _instance;
        public static us_LapHopDong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new us_LapHopDong();
                return _instance;
            }
        }
        public us_LapHopDong()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            us_LapHopDong.Instance.dgvDanhSachycvv.DataSource = BUS_QLNN.BUS_YeuCauVayVon.Instance.findOne(tbCmnd.Text);
        }

        private void tbCmnd_TextChanged(object sender, EventArgs e)
        {


        }

        private void tbCmnd_Click(object sender, EventArgs e)
        {
            tbCmnd.Clear();
            tbCmnd.ForeColor = System.Drawing.Color.Black;
        }

        private void btnLapHopDong_MouseHover(object sender, EventArgs e)
        {
            btnLapHopDong.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void btnLapHopDong_MouseLeave(object sender, EventArgs e)
        {
            btnLapHopDong.BackColor = System.Drawing.Color.DarkRed;
        }

        private void btnLapHopDong_Click(object sender, EventArgs e)
        {
            //var resultDialog = MessageBox.Show("Có chắc muốn lập hợp đôngf?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //if (resultDialog == DialogResult.OK)
            //{
            //    bool result = PrintHopDong();

            //    if (result)
            //    {
            //        MessageBox.Show("Lập hợp đồng thành công");
            //        //ObjPkbBLL.Instance.Add();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thử lại");
            //    }
            //}
            Test();
        }
        private bool PrintHopDong()
        {
            HopDong.DefaultPageSettings.Landscape = true;
            HopDong.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;

            var resultDialog = printDialog.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                try
                {
                    HopDong.Print();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return false;
        }
        private void dgvDanhSachycvv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //  System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
                cmnd = dgvDanhSachycvv.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                name = dgvDanhSachycvv.Rows[e.RowIndex].Cells["name"].Value.ToString();
                diachi = dgvDanhSachycvv.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                phone = dgvDanhSachycvv.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                ngaybd = dgvDanhSachycvv.Rows[e.RowIndex].Cells["ngayBatDauVay"].Value.ToString();
                sotien = dgvDanhSachycvv.Rows[e.RowIndex].Cells["soTienVay"].Value.ToString();
                thoihan = dgvDanhSachycvv.Rows[e.RowIndex].Cells["thoiHan"].Value.ToString();
                laisuat = dgvDanhSachycvv.Rows[e.RowIndex].Cells["laiSuat"].Value.ToString();
                mayc = dgvDanhSachycvv.Rows[e.RowIndex].Cells["maYeuCauVayVon"].Value.ToString();
                mucdich = dgvDanhSachycvv.Rows[e.RowIndex].Cells["mucDichVayVon"].Value.ToString();
                
            }
        }
        public void Test()
        {
            string filePath = @"E:\Nam3\Phát triển bảo trì phần mềm\QuanLyNganHang\HopDong\HopDongMau.pdf";
            string fileResult = @"HopDong.pdf";
            DocumentCore dc = DocumentCore.Load(filePath);
            string searchText = "<>";
            foreach (ContentRange cr in dc.Content.Find(searchText).Reverse())
            {
                cr.Replace(name);
                searchText = name;
                cr.Replace(diachi);
                searchText = diachi;
                cr.Replace(phone);
                searchText = phone;
            }
            // Find a position to insert text. Before this text: "> in this position".
            //for (int i = 1; i <= dc.Content.Find(">").Count(); i++)
            //{
            //    ContentRange cr = dc.Content.Find(">");
            //// Insert new text.
            //    if (cr != null)
            //        cr.Start.Insert(name.ToString());
            //}


            dc.Save(fileResult);
            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(fileResult) { UseShellExecute = true });
        }
        private void HopDong_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.ScaleTransform(1.5f, 1.5f);
            //Font font = new Font("Time New Roman", 13);
            //Brush brush = new SolidBrush(System.Drawing.Color.Black);
            //float fontHeight = font.GetHeight();
            //int startX = 10; int startY = 10;
            //Graphics graphic = e.Graphics;
            //graphic.DrawString("Hợp đồng vay vốn", new Font("Time New Roman", 15, FontStyle.Bold ), new SolidBrush(System.Drawing.Color.Black), startX, 0);

            //graphic.DrawString(cmnd, font, brush, startX, startY + 20);
            //graphic.DrawString(name, font, brush, startX, startY + 40);
            //graphic.DrawString(diachi, font, brush, startX, startY + 60);
            //graphic.DrawString(phone, font, brush, startX, startY + 80);
            //graphic.DrawString(ngaybd, font, brush, startX, startY + 100);
            //graphic.DrawString("--------------------------------", font, brush, startX, 120);
            //graphic.DrawString(sotien, font, brush, startX, startY + 140);
            //graphic.DrawString(thoihan, font, brush, startX, startY + 160);
            //graphic.DrawString("--------------------------------", font, brush, startX, 180);
            ////graphic.DrawString(String.Format("In ngày: {0}", DateTime.Now.ToString()), font, brush, startX, startY + 200);
            //graphic.DrawString(laisuat, font, brush, startX, startY + 220);
            //graphic.DrawString(mayc, font, brush, startX, startY + 220);
            //graphic.DrawString(mucdich, font, brush, startX, startY + 220);


            //string oldFile = "oldFile.pdf";
            //string newFile = "newFile.pdf";

            //// open the reader
            //PdfReader reader = new PdfReader(oldFile);
            //Rectangle size = reader.GetPageSizeWithRotation(1);
            //Document document = new Document(size);

            //// open the writer
            //FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            //PdfWriter writer = PdfWriter.GetInstance(document, fs);
            //document.Open();

            //// the pdf content
            //PdfContentByte cb = writer.DirectContent;

            //// select the font properties
            //Font bf = new Font("Time New Roman", 13);
            //cb.SetColorFill(Color.Black);
            //cb.SetFontAndSize(bf, 8);

            //// write the text in the pdf content
            //cb.BeginText();
            //string text = "Some random blablablabla...";
            //// put the alignment and coordinates here
            //cb.ShowTextAligned(1, text, 520, 640, 0);
            //cb.EndText();
            //cb.BeginText();
            //text = "Other random blabla...";
            //// put the alignment and coordinates here
            //cb.ShowTextAligned(2, text, 100, 200, 0);
            //cb.EndText();

            //// create the new page and add it to the pdf
            //PdfImportedPage page = writer.GetImportedPage(reader, 1);
            //cb.AddTemplate(page, 0, 0);

            //// close the streams and voilá the file should be changed :)
            //document.Close();
            //fs.Close();
            //writer.Close();
            //reader.Close();


        }

        private void dgvDanhSachycvv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //  System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
                cmnd = dgvDanhSachycvv.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
                name = dgvDanhSachycvv.Rows[e.RowIndex].Cells["name"].Value.ToString();
                diachi = dgvDanhSachycvv.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                phone = dgvDanhSachycvv.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                ngaybd = dgvDanhSachycvv.Rows[e.RowIndex].Cells["ngayBatDauVay"].Value.ToString();
                sotien = dgvDanhSachycvv.Rows[e.RowIndex].Cells["soTienVay"].Value.ToString();
                thoihan = dgvDanhSachycvv.Rows[e.RowIndex].Cells["thoiHanVay"].Value.ToString();
                laisuat = dgvDanhSachycvv.Rows[e.RowIndex].Cells["laiSuat"].Value.ToString();
                mayc = dgvDanhSachycvv.Rows[e.RowIndex].Cells["maYeuCauVayVon"].Value.ToString();
                mucdich = dgvDanhSachycvv.Rows[e.RowIndex].Cells["mucDichVayVon"].Value.ToString();

            }
        }
    } 

}
