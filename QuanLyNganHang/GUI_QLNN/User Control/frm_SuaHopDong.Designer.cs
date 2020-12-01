
namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class frm_SuaHopDong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTrangThaiHopDong = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblMaHopDong = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDieuKhoan = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhLy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDieuKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTrangThaiHopDong);
            this.groupBox1.Controls.Add(this.lblCMND);
            this.groupBox1.Controls.Add(this.lblTenKhachHang);
            this.groupBox1.Controls.Add(this.lblMaHopDong);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng";
            // 
            // lblTrangThaiHopDong
            // 
            this.lblTrangThaiHopDong.AutoSize = true;
            this.lblTrangThaiHopDong.Location = new System.Drawing.Point(427, 56);
            this.lblTrangThaiHopDong.Name = "lblTrangThaiHopDong";
            this.lblTrangThaiHopDong.Size = new System.Drawing.Size(189, 20);
            this.lblTrangThaiHopDong.TabIndex = 4;
            this.lblTrangThaiHopDong.Text = "Trạng thái của hợp đồng: ";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(427, 26);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(88, 20);
            this.lblCMND.TabIndex = 3;
            this.lblCMND.Text = "Số CMND: ";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(7, 26);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(131, 20);
            this.lblTenKhachHang.TabIndex = 2;
            this.lblTenKhachHang.Text = "Tên khách hàng: ";
            // 
            // lblMaHopDong
            // 
            this.lblMaHopDong.AutoSize = true;
            this.lblMaHopDong.Location = new System.Drawing.Point(7, 56);
            this.lblMaHopDong.Name = "lblMaHopDong";
            this.lblMaHopDong.Size = new System.Drawing.Size(110, 20);
            this.lblMaHopDong.TabIndex = 1;
            this.lblMaHopDong.Text = "Mã hợp đồng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachDieuKhoan);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách điều khoản";
            // 
            // dgvDanhSachDieuKhoan
            // 
            this.dgvDanhSachDieuKhoan.AllowUserToDeleteRows = false;
            this.dgvDanhSachDieuKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDieuKhoan.Location = new System.Drawing.Point(11, 25);
            this.dgvDanhSachDieuKhoan.Name = "dgvDanhSachDieuKhoan";
            this.dgvDanhSachDieuKhoan.RowHeadersWidth = 62;
            this.dgvDanhSachDieuKhoan.RowTemplate.Height = 28;
            this.dgvDanhSachDieuKhoan.Size = new System.Drawing.Size(697, 226);
            this.dgvDanhSachDieuKhoan.TabIndex = 0;
            this.dgvDanhSachDieuKhoan.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDieuKhoan_CellEndEdit);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkRed;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(460, 373);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 46);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkRed;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(596, 373);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(130, 46);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Huỷ bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.BackColor = System.Drawing.Color.DarkRed;
            this.btnThanhLy.ForeColor = System.Drawing.Color.White;
            this.btnThanhLy.Location = new System.Drawing.Point(12, 373);
            this.btnThanhLy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(162, 46);
            this.btnThanhLy.TabIndex = 37;
            this.btnThanhLy.Text = "Thanh lý hợp đồng";
            this.btnThanhLy.UseVisualStyleBackColor = false;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // frm_SuaHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 425);
            this.Controls.Add(this.btnThanhLy);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SuaHopDong";
            this.Text = "frm_SuaHopDong";
            this.Load += new System.EventHandler(this.frm_SuaHopDong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDieuKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblMaHopDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTrangThaiHopDong;
        private System.Windows.Forms.DataGridView dgvDanhSachDieuKhoan;
        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.Button btnThanhLy;
    }
}