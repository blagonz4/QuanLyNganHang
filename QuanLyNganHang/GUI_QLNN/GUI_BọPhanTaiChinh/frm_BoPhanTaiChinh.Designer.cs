namespace QuanLyNganHang.GUI_QLNN
{
    partial class frm_BoPhanTaiChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTinhnoKH = new System.Windows.Forms.Button();
            this.btnTinhlaiKH = new System.Windows.Forms.Button();
            this.btnDanhsachkhachhang = new System.Windows.Forms.Button();
            this.pnlMainBPTC = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btnTinhnoKH);
            this.panel1.Controls.Add(this.btnTinhlaiKH);
            this.panel1.Controls.Add(this.btnDanhsachkhachhang);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 623);
            this.panel1.TabIndex = 31;
            // 
            // btnTinhnoKH
            // 
            this.btnTinhnoKH.BackColor = System.Drawing.Color.White;
            this.btnTinhnoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhnoKH.ForeColor = System.Drawing.Color.Black;
            this.btnTinhnoKH.Location = new System.Drawing.Point(12, 203);
            this.btnTinhnoKH.Name = "btnTinhnoKH";
            this.btnTinhnoKH.Size = new System.Drawing.Size(245, 78);
            this.btnTinhnoKH.TabIndex = 30;
            this.btnTinhnoKH.Text = "Tính nợ KH";
            this.btnTinhnoKH.UseVisualStyleBackColor = false;
            // 
            // btnTinhlaiKH
            // 
            this.btnTinhlaiKH.BackColor = System.Drawing.Color.White;
            this.btnTinhlaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhlaiKH.ForeColor = System.Drawing.Color.Black;
            this.btnTinhlaiKH.Location = new System.Drawing.Point(12, 101);
            this.btnTinhlaiKH.Name = "btnTinhlaiKH";
            this.btnTinhlaiKH.Size = new System.Drawing.Size(245, 78);
            this.btnTinhlaiKH.TabIndex = 30;
            this.btnTinhlaiKH.Text = "Tính lãi KH";
            this.btnTinhlaiKH.UseVisualStyleBackColor = false;
            // 
            // btnDanhsachkhachhang
            // 
            this.btnDanhsachkhachhang.BackColor = System.Drawing.Color.White;
            this.btnDanhsachkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsachkhachhang.ForeColor = System.Drawing.Color.Black;
            this.btnDanhsachkhachhang.Location = new System.Drawing.Point(12, 0);
            this.btnDanhsachkhachhang.Name = "btnDanhsachkhachhang";
            this.btnDanhsachkhachhang.Size = new System.Drawing.Size(245, 78);
            this.btnDanhsachkhachhang.TabIndex = 1;
            this.btnDanhsachkhachhang.Text = "Danh sách khách hàng";
            this.btnDanhsachkhachhang.UseVisualStyleBackColor = false;
            this.btnDanhsachkhachhang.Click += new System.EventHandler(this.btnDanhsachkhachhang_Click);
            // 
            // pnlMainBPTC
            // 
            this.pnlMainBPTC.BackColor = System.Drawing.Color.White;
            this.pnlMainBPTC.Location = new System.Drawing.Point(272, 92);
            this.pnlMainBPTC.Name = "pnlMainBPTC";
            this.pnlMainBPTC.Size = new System.Drawing.Size(998, 649);
            this.pnlMainBPTC.TabIndex = 32;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.White;
            this.pnLogo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Image = global::QuanLyNganHang.Properties.Resources.logo;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(1282, 86);
            this.pnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnLogo.TabIndex = 30;
            this.pnLogo.TabStop = false;
            // 
            // frm_BoPhanTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.pnlMainBPTC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLogo);
            this.Name = "frm_BoPhanTaiChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ phận tài chính";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pnLogo;
        public System.Windows.Forms.Button btnTinhnoKH;
        public System.Windows.Forms.Button btnTinhlaiKH;
        public System.Windows.Forms.Button btnDanhsachkhachhang;
        public System.Windows.Forms.Panel pnlMainBPTC;
        public System.Windows.Forms.Panel panel1;
    }
}