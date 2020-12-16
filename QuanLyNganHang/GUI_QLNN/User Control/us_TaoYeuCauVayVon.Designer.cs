namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class us_TaoYeuCauVayVon
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
            this.components = new System.ComponentModel.Container();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbCmnd_KH = new System.Windows.Forms.Label();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbCmnd_KhachHang = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKhachHang = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmLaiSuat = new System.Windows.Forms.NumericUpDown();
            this.btnTaoYeuCau = new System.Windows.Forms.Button();
            this.nmSoTien = new System.Windows.Forms.NumericUpDown();
            this.cbThoiHan = new System.Windows.Forms.ComboBox();
            this.cbKiHan = new System.Windows.Forms.ComboBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lbMucdich = new System.Windows.Forms.Label();
            this.lbLaiSuat = new System.Windows.Forms.Label();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.tbMucDich = new System.Windows.Forms.TextBox();
            this.lbKiHan = new System.Windows.Forms.Label();
            this.tbMaYeuCau = new System.Windows.Forms.TextBox();
            this.lbThoihan = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbMaYeuCauVayVon = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Location = new System.Drawing.Point(44, 149);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(45, 20);
            this.lbSdt.TabIndex = 1;
            this.lbSdt.Text = "SĐT:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(44, 198);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(65, 20);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "Địa chỉ: ";
            // 
            // lbCmnd_KH
            // 
            this.lbCmnd_KH.AutoSize = true;
            this.lbCmnd_KH.Location = new System.Drawing.Point(44, 102);
            this.lbCmnd_KH.Name = "lbCmnd_KH";
            this.lbCmnd_KH.Size = new System.Drawing.Size(60, 20);
            this.lbCmnd_KH.TabIndex = 3;
            this.lbCmnd_KH.Text = "CMND:";
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Location = new System.Drawing.Point(44, 54);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(61, 20);
            this.lbTenKhachHang.TabIndex = 4;
            this.lbTenKhachHang.Text = "Họ tên:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(158, 54);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(112, 26);
            this.tbHoTen.TabIndex = 5;
            this.tbHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.tbHoTen_Validating);
            // 
            // tbCmnd_KhachHang
            // 
            this.tbCmnd_KhachHang.Location = new System.Drawing.Point(158, 96);
            this.tbCmnd_KhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCmnd_KhachHang.Name = "tbCmnd_KhachHang";
            this.tbCmnd_KhachHang.Size = new System.Drawing.Size(112, 26);
            this.tbCmnd_KhachHang.TabIndex = 6;
            this.tbCmnd_KhachHang.Validating += new System.ComponentModel.CancelEventHandler(this.tbCmnd_KhachHang_Validating);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(158, 195);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(332, 26);
            this.tbDiaChi.TabIndex = 7;
            this.tbDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.tbDiaChi_Validating);
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(158, 146);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(112, 26);
            this.tbSdt.TabIndex = 8;
            this.tbSdt.Validating += new System.ComponentModel.CancelEventHandler(this.tbSdt_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.lbTenKhachHang);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.lbSdt);
            this.groupBox1.Controls.Add(this.tbCmnd_KhachHang);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.lbCmnd_KH);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1119, 332);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.AutoSize = true;
            this.cbKhachHang.CausesValidation = false;
            this.cbKhachHang.Location = new System.Drawing.Point(636, 102);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(159, 24);
            this.cbKhachHang.TabIndex = 9;
            this.cbKhachHang.Text = "Đã là khách hàng";
            this.cbKhachHang.UseVisualStyleBackColor = true;
            this.cbKhachHang.CheckedChanged += new System.EventHandler(this.cbKhachHang_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmLaiSuat);
            this.groupBox2.Controls.Add(this.btnTaoYeuCau);
            this.groupBox2.Controls.Add(this.nmSoTien);
            this.groupBox2.Controls.Add(this.cbThoiHan);
            this.groupBox2.Controls.Add(this.cbKiHan);
            this.groupBox2.Controls.Add(this.dtpNgayBatDau);
            this.groupBox2.Controls.Add(this.lbMucdich);
            this.groupBox2.Controls.Add(this.lbLaiSuat);
            this.groupBox2.Controls.Add(this.lbNgayBatDau);
            this.groupBox2.Controls.Add(this.tbMucDich);
            this.groupBox2.Controls.Add(this.lbKiHan);
            this.groupBox2.Controls.Add(this.tbMaYeuCau);
            this.groupBox2.Controls.Add(this.lbThoihan);
            this.groupBox2.Controls.Add(this.lbSoTien);
            this.groupBox2.Controls.Add(this.lbMaYeuCauVayVon);
            this.groupBox2.Location = new System.Drawing.Point(0, 340);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1119, 465);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yêu cầu vay vốn";
            // 
            // nmLaiSuat
            // 
            this.nmLaiSuat.DecimalPlaces = 2;
            this.nmLaiSuat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmLaiSuat.Location = new System.Drawing.Point(872, 32);
            this.nmLaiSuat.Maximum = new decimal(new int[] {
            167,
            0,
            0,
            131072});
            this.nmLaiSuat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmLaiSuat.Name = "nmLaiSuat";
            this.nmLaiSuat.Size = new System.Drawing.Size(71, 26);
            this.nmLaiSuat.TabIndex = 47;
            this.nmLaiSuat.ThousandsSeparator = true;
            this.nmLaiSuat.Value = new decimal(new int[] {
            167,
            0,
            0,
            131072});
            this.nmLaiSuat.Validating += new System.ComponentModel.CancelEventHandler(this.nmLaiSuat_Validating);
            // 
            // btnTaoYeuCau
            // 
            this.btnTaoYeuCau.BackColor = System.Drawing.Color.DarkRed;
            this.btnTaoYeuCau.ForeColor = System.Drawing.Color.White;
            this.btnTaoYeuCau.Location = new System.Drawing.Point(945, 381);
            this.btnTaoYeuCau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoYeuCau.Name = "btnTaoYeuCau";
            this.btnTaoYeuCau.Size = new System.Drawing.Size(130, 46);
            this.btnTaoYeuCau.TabIndex = 34;
            this.btnTaoYeuCau.Text = "Tạo";
            this.btnTaoYeuCau.UseVisualStyleBackColor = false;
            this.btnTaoYeuCau.Click += new System.EventHandler(this.btnTaoYeuCau_Click);
            // 
            // nmSoTien
            // 
            this.nmSoTien.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmSoTien.Location = new System.Drawing.Point(546, 124);
            this.nmSoTien.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nmSoTien.Name = "nmSoTien";
            this.nmSoTien.Size = new System.Drawing.Size(112, 26);
            this.nmSoTien.TabIndex = 46;
            this.nmSoTien.ThousandsSeparator = true;
            this.nmSoTien.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmSoTien.Validating += new System.ComponentModel.CancelEventHandler(this.nmSoTien_Validating);
            // 
            // cbThoiHan
            // 
            this.cbThoiHan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbThoiHan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiHan.FormatString = "N0";
            this.cbThoiHan.FormattingEnabled = true;
            this.cbThoiHan.Items.AddRange(new object[] {
            "6",
            "12",
            "18",
            "24",
            "36",
            "60"});
            this.cbThoiHan.Location = new System.Drawing.Point(189, 130);
            this.cbThoiHan.Name = "cbThoiHan";
            this.cbThoiHan.Size = new System.Drawing.Size(112, 28);
            this.cbThoiHan.TabIndex = 45;
            this.cbThoiHan.Validating += new System.ComponentModel.CancelEventHandler(this.cbThoiHan_Validating);
            // 
            // cbKiHan
            // 
            this.cbKiHan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbKiHan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKiHan.FormatString = "N0";
            this.cbKiHan.FormattingEnabled = true;
            this.cbKiHan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "12"});
            this.cbKiHan.Location = new System.Drawing.Point(546, 30);
            this.cbKiHan.Name = "cbKiHan";
            this.cbKiHan.Size = new System.Drawing.Size(112, 28);
            this.cbKiHan.TabIndex = 44;
            this.cbKiHan.Validating += new System.ComponentModel.CancelEventHandler(this.cbKiHan_Validating);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(546, 77);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(112, 26);
            this.dtpNgayBatDau.TabIndex = 43;
            this.dtpNgayBatDau.Value = new System.DateTime(2020, 12, 15, 22, 40, 31, 0);
            this.dtpNgayBatDau.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgayBatDau_Validating);
            // 
            // lbMucdich
            // 
            this.lbMucdich.AutoSize = true;
            this.lbMucdich.Location = new System.Drawing.Point(44, 88);
            this.lbMucdich.Name = "lbMucdich";
            this.lbMucdich.Size = new System.Drawing.Size(80, 20);
            this.lbMucdich.TabIndex = 22;
            this.lbMucdich.Text = "Mục đích: ";
            // 
            // lbLaiSuat
            // 
            this.lbLaiSuat.AutoSize = true;
            this.lbLaiSuat.Location = new System.Drawing.Point(720, 34);
            this.lbLaiSuat.Name = "lbLaiSuat";
            this.lbLaiSuat.Size = new System.Drawing.Size(146, 20);
            this.lbLaiSuat.TabIndex = 19;
            this.lbLaiSuat.Text = "Lãi suất (%/tháng): ";
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.AutoSize = true;
            this.lbNgayBatDau.Location = new System.Drawing.Point(423, 81);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(111, 20);
            this.lbNgayBatDau.TabIndex = 23;
            this.lbNgayBatDau.Text = "Ngày bắt đầu: ";
            // 
            // tbMucDich
            // 
            this.tbMucDich.Location = new System.Drawing.Point(189, 84);
            this.tbMucDich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMucDich.Name = "tbMucDich";
            this.tbMucDich.Size = new System.Drawing.Size(112, 26);
            this.tbMucDich.TabIndex = 28;
            this.tbMucDich.Validating += new System.ComponentModel.CancelEventHandler(this.tbMucDich_Validating);
            // 
            // lbKiHan
            // 
            this.lbKiHan.AutoSize = true;
            this.lbKiHan.Location = new System.Drawing.Point(423, 34);
            this.lbKiHan.Name = "lbKiHan";
            this.lbKiHan.Size = new System.Drawing.Size(116, 20);
            this.lbKiHan.TabIndex = 21;
            this.lbKiHan.Text = "Kì hạn (tháng): ";
            // 
            // tbMaYeuCau
            // 
            this.tbMaYeuCau.Location = new System.Drawing.Point(189, 34);
            this.tbMaYeuCau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaYeuCau.Name = "tbMaYeuCau";
            this.tbMaYeuCau.ReadOnly = true;
            this.tbMaYeuCau.Size = new System.Drawing.Size(112, 26);
            this.tbMaYeuCau.TabIndex = 24;
            // 
            // lbThoihan
            // 
            this.lbThoihan.AutoSize = true;
            this.lbThoihan.Location = new System.Drawing.Point(44, 135);
            this.lbThoihan.Name = "lbThoihan";
            this.lbThoihan.Size = new System.Drawing.Size(133, 20);
            this.lbThoihan.TabIndex = 20;
            this.lbThoihan.Text = "Thời hạn (tháng): ";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(423, 126);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(67, 20);
            this.lbSoTien.TabIndex = 17;
            this.lbSoTien.Text = "Số tiền: ";
            // 
            // lbMaYeuCauVayVon
            // 
            this.lbMaYeuCauVayVon.AutoSize = true;
            this.lbMaYeuCauVayVon.Location = new System.Drawing.Point(40, 38);
            this.lbMaYeuCauVayVon.Name = "lbMaYeuCauVayVon";
            this.lbMaYeuCauVayVon.Size = new System.Drawing.Size(102, 20);
            this.lbMaYeuCauVayVon.TabIndex = 15;
            this.lbMaYeuCauVayVon.Text = " Mã yêu cầu: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // us_TaoYeuCauVayVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "us_TaoYeuCauVayVon";
            this.Size = new System.Drawing.Size(1123, 809);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbCmnd_KH;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbCmnd_KhachHang;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMucdich;
        private System.Windows.Forms.Label lbLaiSuat;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.Label lbKiHan;
        private System.Windows.Forms.Label lbThoihan;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbMaYeuCauVayVon;
        private System.Windows.Forms.Button btnTaoYeuCau;
        public System.Windows.Forms.TextBox tbMucDich;
        public System.Windows.Forms.TextBox tbMaYeuCau;
        public System.Windows.Forms.CheckBox cbKhachHang;
        public System.Windows.Forms.NumericUpDown nmLaiSuat;
        public System.Windows.Forms.NumericUpDown nmSoTien;
        public System.Windows.Forms.ComboBox cbThoiHan;
        public System.Windows.Forms.ComboBox cbKiHan;
        public System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
