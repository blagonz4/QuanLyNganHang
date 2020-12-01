namespace QuanLyNganHang.GUI_QLNN
{
    partial class us_DanhSachHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_DanhSachHopDong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.PictureBox();
            this.tbCmnd = new System.Windows.Forms.TextBox();
            this.dgvDanhSachHD = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.tbCmnd);
            this.groupBox1.Controls.Add(this.dgvDanhSachHD);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 785);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkRed;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(983, 731);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 46);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.MouseLeave += new System.EventHandler(this.btnSua_MouseLeave);
            this.btnSua.MouseHover += new System.EventHandler(this.btnSua_MouseHover);
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
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.tbCmnd.Click += new System.EventHandler(this.tbCmnd_Click);
            // 
            // dgvDanhSachHD
            // 
            this.dgvDanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHD.Location = new System.Drawing.Point(7, 74);
            this.dgvDanhSachHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachHD.MultiSelect = false;
            this.dgvDanhSachHD.Name = "dgvDanhSachHD";
            this.dgvDanhSachHD.ReadOnly = true;
            this.dgvDanhSachHD.RowHeadersWidth = 62;
            this.dgvDanhSachHD.RowTemplate.Height = 24;
            this.dgvDanhSachHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvDanhSachHD.Size = new System.Drawing.Size(1106, 649);
            this.dgvDanhSachHD.TabIndex = 1;
            this.dgvDanhSachHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHD_CellClick);
            this.dgvDanhSachHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHD_CellContentClick);
            // 
            // us_DanhSachHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "us_DanhSachHopDong";
            this.Size = new System.Drawing.Size(1123, 793);
            this.Load += new System.EventHandler(this.us_DanhSachHopDong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvDanhSachHD;
        private System.Windows.Forms.PictureBox btnFind;
        public System.Windows.Forms.TextBox tbCmnd;
        public System.Windows.Forms.Button btnSua;
    }
}
