namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class frm_SuaYeuCauVayVon
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmLaiSuat = new System.Windows.Forms.NumericUpDown();
            this.nmSoTien = new System.Windows.Forms.NumericUpDown();
            this.cbThoiHan = new System.Windows.Forms.ComboBox();
            this.cbKiHan = new System.Windows.Forms.ComboBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.tbCmnd = new System.Windows.Forms.TextBox();
            this.lbCmnd = new System.Windows.Forms.Label();
            this.btnTaoYeuCau = new System.Windows.Forms.Button();
            this.tbTrangThai = new System.Windows.Forms.TextBox();
            this.lbMucdich = new System.Windows.Forms.Label();
            this.lbLaiSuat = new System.Windows.Forms.Label();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.tbMucDich = new System.Windows.Forms.TextBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbKiHan = new System.Windows.Forms.Label();
            this.tbMaYeuCau = new System.Windows.Forms.TextBox();
            this.lbThoihan = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbMaYeuCauVayVon = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmLaiSuat);
            this.groupBox2.Controls.Add(this.nmSoTien);
            this.groupBox2.Controls.Add(this.cbThoiHan);
            this.groupBox2.Controls.Add(this.cbKiHan);
            this.groupBox2.Controls.Add(this.dtpNgayBatDau);
            this.groupBox2.Controls.Add(this.tbCmnd);
            this.groupBox2.Controls.Add(this.lbCmnd);
            this.groupBox2.Controls.Add(this.btnTaoYeuCau);
            this.groupBox2.Controls.Add(this.tbTrangThai);
            this.groupBox2.Controls.Add(this.lbMucdich);
            this.groupBox2.Controls.Add(this.lbLaiSuat);
            this.groupBox2.Controls.Add(this.lbNgayBatDau);
            this.groupBox2.Controls.Add(this.tbMucDich);
            this.groupBox2.Controls.Add(this.lbTrangThai);
            this.groupBox2.Controls.Add(this.lbKiHan);
            this.groupBox2.Controls.Add(this.tbMaYeuCau);
            this.groupBox2.Controls.Add(this.lbThoihan);
            this.groupBox2.Controls.Add(this.lbSoTien);
            this.groupBox2.Controls.Add(this.lbMaYeuCauVayVon);
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(951, 465);
            this.groupBox2.TabIndex = 11;
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
            this.nmLaiSuat.Location = new System.Drawing.Point(860, 32);
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
            this.nmLaiSuat.TabIndex = 42;
            this.nmLaiSuat.ThousandsSeparator = true;
            this.nmLaiSuat.Value = new decimal(new int[] {
            167,
            0,
            0,
            131072});
            this.nmLaiSuat.Validating += new System.ComponentModel.CancelEventHandler(this.nmLaiSuat_Validating);
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
            this.nmSoTien.TabIndex = 41;
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
            this.cbThoiHan.TabIndex = 39;
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
            this.cbKiHan.TabIndex = 38;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(546, 77);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(112, 26);
            this.dtpNgayBatDau.TabIndex = 37;
            this.dtpNgayBatDau.Value = new System.DateTime(2020, 12, 15, 22, 40, 31, 0);
            this.dtpNgayBatDau.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgayBatDau_Validating);
            // 
            // tbCmnd
            // 
            this.tbCmnd.Location = new System.Drawing.Point(189, 184);
            this.tbCmnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCmnd.Name = "tbCmnd";
            this.tbCmnd.ReadOnly = true;
            this.tbCmnd.Size = new System.Drawing.Size(112, 26);
            this.tbCmnd.TabIndex = 36;
            // 
            // lbCmnd
            // 
            this.lbCmnd.AutoSize = true;
            this.lbCmnd.Location = new System.Drawing.Point(56, 184);
            this.lbCmnd.Name = "lbCmnd";
            this.lbCmnd.Size = new System.Drawing.Size(64, 20);
            this.lbCmnd.TabIndex = 35;
            this.lbCmnd.Text = "CMND: ";
            // 
            // btnTaoYeuCau
            // 
            this.btnTaoYeuCau.BackColor = System.Drawing.Color.DarkRed;
            this.btnTaoYeuCau.ForeColor = System.Drawing.Color.White;
            this.btnTaoYeuCau.Location = new System.Drawing.Point(791, 300);
            this.btnTaoYeuCau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoYeuCau.Name = "btnTaoYeuCau";
            this.btnTaoYeuCau.Size = new System.Drawing.Size(130, 46);
            this.btnTaoYeuCau.TabIndex = 34;
            this.btnTaoYeuCau.Text = "Sửa";
            this.btnTaoYeuCau.UseVisualStyleBackColor = false;
            this.btnTaoYeuCau.Click += new System.EventHandler(this.btnTaoYeuCau_Click);
            // 
            // tbTrangThai
            // 
            this.tbTrangThai.Location = new System.Drawing.Point(546, 178);
            this.tbTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTrangThai.Name = "tbTrangThai";
            this.tbTrangThai.ReadOnly = true;
            this.tbTrangThai.Size = new System.Drawing.Size(112, 26);
            this.tbTrangThai.TabIndex = 27;
            // 
            // lbMucdich
            // 
            this.lbMucdich.AutoSize = true;
            this.lbMucdich.Location = new System.Drawing.Point(56, 84);
            this.lbMucdich.Name = "lbMucdich";
            this.lbMucdich.Size = new System.Drawing.Size(80, 20);
            this.lbMucdich.TabIndex = 22;
            this.lbMucdich.Text = "Mục đích: ";
            // 
            // lbLaiSuat
            // 
            this.lbLaiSuat.AutoSize = true;
            this.lbLaiSuat.Location = new System.Drawing.Point(709, 34);
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
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(423, 178);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(88, 20);
            this.lbTrangThai.TabIndex = 18;
            this.lbTrangThai.Text = "Trạng thái: ";
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
            this.lbThoihan.Location = new System.Drawing.Point(56, 132);
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
            this.lbMaYeuCauVayVon.Location = new System.Drawing.Point(48, 34);
            this.lbMaYeuCauVayVon.Name = "lbMaYeuCauVayVon";
            this.lbMaYeuCauVayVon.Size = new System.Drawing.Size(102, 20);
            this.lbMaYeuCauVayVon.TabIndex = 15;
            this.lbMaYeuCauVayVon.Text = " Mã yêu cầu: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_SuaYeuCauVayVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 461);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_SuaYeuCauVayVon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SuaYeuCauVayVon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_SuaYeuCauVayVon_FormClosed);
            this.Load += new System.EventHandler(this.frm_SuaYeuCauVayVon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox tbTrangThai;
        private System.Windows.Forms.Label lbMucdich;
        private System.Windows.Forms.Label lbLaiSuat;
        private System.Windows.Forms.Label lbNgayBatDau;
        public System.Windows.Forms.TextBox tbMucDich;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbKiHan;
        public System.Windows.Forms.TextBox tbMaYeuCau;
        private System.Windows.Forms.Label lbThoihan;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbMaYeuCauVayVon;
        public System.Windows.Forms.Button btnTaoYeuCau;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbCmnd;
        private System.Windows.Forms.Label lbCmnd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        public System.Windows.Forms.ComboBox cbThoiHan;
        public System.Windows.Forms.ComboBox cbKiHan;
        public System.Windows.Forms.NumericUpDown nmSoTien;
        public System.Windows.Forms.NumericUpDown nmLaiSuat;
    }
}