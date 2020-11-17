namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class us_DanhSachKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_DanhSachKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatThuThongBao = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.PictureBox();
            this.tbCmnd = new System.Windows.Forms.TextBox();
            this.dgvDanhSachKH = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXuatThuThongBao);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.tbCmnd);
            this.groupBox1.Controls.Add(this.dgvDanhSachKH);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 784);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // btnXuatThuThongBao
            // 
            this.btnXuatThuThongBao.BackColor = System.Drawing.Color.DarkRed;
            this.btnXuatThuThongBao.ForeColor = System.Drawing.Color.White;
            this.btnXuatThuThongBao.Location = new System.Drawing.Point(943, 731);
            this.btnXuatThuThongBao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatThuThongBao.Name = "btnXuatThuThongBao";
            this.btnXuatThuThongBao.Size = new System.Drawing.Size(170, 46);
            this.btnXuatThuThongBao.TabIndex = 35;
            this.btnXuatThuThongBao.Text = "Xuất thư thông báo";
            this.btnXuatThuThongBao.UseVisualStyleBackColor = false;
            this.btnXuatThuThongBao.Click += new System.EventHandler(this.btnXuatThuThongBao_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(164, 26);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 32);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFind.TabIndex = 3;
            this.btnFind.TabStop = false;
            // 
            // tbCmnd
            // 
            this.tbCmnd.ForeColor = System.Drawing.Color.Gray;
            this.tbCmnd.Location = new System.Drawing.Point(8, 31);
            this.tbCmnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCmnd.Name = "tbCmnd";
            this.tbCmnd.Size = new System.Drawing.Size(149, 26);
            this.tbCmnd.TabIndex = 2;
            this.tbCmnd.Text = "Nhập CMND";
            // 
            // dgvDanhSachKH
            // 
            this.dgvDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKH.Location = new System.Drawing.Point(7, 74);
            this.dgvDanhSachKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachKH.Name = "dgvDanhSachKH";
            this.dgvDanhSachKH.RowHeadersWidth = 62;
            this.dgvDanhSachKH.RowTemplate.Height = 24;
            this.dgvDanhSachKH.Size = new System.Drawing.Size(1106, 649);
            this.dgvDanhSachKH.TabIndex = 1;
            // 
            // us_DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "us_DanhSachKhachHang";
            this.Size = new System.Drawing.Size(1123, 788);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnXuatThuThongBao;
        private System.Windows.Forms.PictureBox btnFind;
        public System.Windows.Forms.TextBox tbCmnd;
        public System.Windows.Forms.DataGridView dgvDanhSachKH;
    }
}
