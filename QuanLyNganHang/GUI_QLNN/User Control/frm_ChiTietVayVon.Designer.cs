
namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class frm_ChiTietVayVon
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
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSoTienVay = new System.Windows.Forms.Label();
            this.lblThoiHanVay = new System.Windows.Forms.Label();
            this.lblKiHan = new System.Windows.Forms.Label();
            this.lblMucDichVay = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHoSoVay = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnKhongDuyet = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoSoVay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoDienThoai);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblCMND);
            this.groupBox1.Controls.Add(this.lblTenKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(7, 26);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(131, 20);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng: ";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(397, 26);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(68, 20);
            this.lblCMND.TabIndex = 1;
            this.lblCMND.Text = "CMND:  ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(7, 56);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(65, 20);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ: ";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(7, 86);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(110, 20);
            this.lblSoDienThoai.TabIndex = 3;
            this.lblSoDienThoai.Text = "Số điện thoại: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNgayBatDau);
            this.groupBox2.Controls.Add(this.lblSoTienVay);
            this.groupBox2.Controls.Add(this.lblThoiHanVay);
            this.groupBox2.Controls.Add(this.lblKiHan);
            this.groupBox2.Controls.Add(this.lblMucDichVay);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vay vốn ";
            // 
            // lblSoTienVay
            // 
            this.lblSoTienVay.AutoSize = true;
            this.lblSoTienVay.Location = new System.Drawing.Point(7, 86);
            this.lblSoTienVay.Name = "lblSoTienVay";
            this.lblSoTienVay.Size = new System.Drawing.Size(94, 20);
            this.lblSoTienVay.TabIndex = 3;
            this.lblSoTienVay.Text = "Số tiền vay: ";
            // 
            // lblThoiHanVay
            // 
            this.lblThoiHanVay.AutoSize = true;
            this.lblThoiHanVay.Location = new System.Drawing.Point(7, 56);
            this.lblThoiHanVay.Name = "lblThoiHanVay";
            this.lblThoiHanVay.Size = new System.Drawing.Size(105, 20);
            this.lblThoiHanVay.TabIndex = 2;
            this.lblThoiHanVay.Text = "Thời hạn vay: ";
            // 
            // lblKiHan
            // 
            this.lblKiHan.AutoSize = true;
            this.lblKiHan.Location = new System.Drawing.Point(240, 56);
            this.lblKiHan.Name = "lblKiHan";
            this.lblKiHan.Size = new System.Drawing.Size(65, 20);
            this.lblKiHan.TabIndex = 1;
            this.lblKiHan.Text = "Kì hạn:  ";
            // 
            // lblMucDichVay
            // 
            this.lblMucDichVay.AutoSize = true;
            this.lblMucDichVay.Location = new System.Drawing.Point(7, 26);
            this.lblMucDichVay.Name = "lblMucDichVay";
            this.lblMucDichVay.Size = new System.Drawing.Size(136, 20);
            this.lblMucDichVay.TabIndex = 0;
            this.lblMucDichVay.Text = "Mục đích vay vốn: ";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(397, 56);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(138, 20);
            this.lblNgayBatDau.TabIndex = 4;
            this.lblNgayBatDau.Text = "Ngày bắt đầu vay: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSachHoSoVay);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(980, 253);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hồ sơ vay";
            // 
            // dgvDanhSachHoSoVay
            // 
            this.dgvDanhSachHoSoVay.AllowUserToAddRows = false;
            this.dgvDanhSachHoSoVay.AllowUserToDeleteRows = false;
            this.dgvDanhSachHoSoVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoSoVay.Location = new System.Drawing.Point(11, 26);
            this.dgvDanhSachHoSoVay.MultiSelect = false;
            this.dgvDanhSachHoSoVay.Name = "dgvDanhSachHoSoVay";
            this.dgvDanhSachHoSoVay.ReadOnly = true;
            this.dgvDanhSachHoSoVay.RowHeadersWidth = 62;
            this.dgvDanhSachHoSoVay.RowTemplate.Height = 28;
            this.dgvDanhSachHoSoVay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHoSoVay.Size = new System.Drawing.Size(963, 221);
            this.dgvDanhSachHoSoVay.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkRed;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(862, 519);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(130, 46);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Huỷ bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnKhongDuyet
            // 
            this.btnKhongDuyet.BackColor = System.Drawing.Color.DarkRed;
            this.btnKhongDuyet.ForeColor = System.Drawing.Color.White;
            this.btnKhongDuyet.Location = new System.Drawing.Point(726, 519);
            this.btnKhongDuyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKhongDuyet.Name = "btnKhongDuyet";
            this.btnKhongDuyet.Size = new System.Drawing.Size(130, 46);
            this.btnKhongDuyet.TabIndex = 37;
            this.btnKhongDuyet.Text = "Không duyệt";
            this.btnKhongDuyet.UseVisualStyleBackColor = false;
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.DarkRed;
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(590, 519);
            this.btnDuyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(130, 46);
            this.btnDuyet.TabIndex = 39;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = false;
            // 
            // frm_ChiTietVayVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 572);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnKhongDuyet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ChiTietVayVon";
            this.Text = "frm_ChiTietVayVon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoSoVay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblSoTienVay;
        private System.Windows.Forms.Label lblThoiHanVay;
        private System.Windows.Forms.Label lblKiHan;
        private System.Windows.Forms.Label lblMucDichVay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDanhSachHoSoVay;
        public System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.Button btnKhongDuyet;
        public System.Windows.Forms.Button btnDuyet;
    }
}