namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class us_DanhSachYeuCauVayVon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_DanhSachYeuCauVayVon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsuaYeuCau = new System.Windows.Forms.PictureBox();
            this.dgvDanhSachYCVV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsuaYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachYCVV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsuaYeuCau);
            this.groupBox1.Controls.Add(this.dgvDanhSachYCVV);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1119, 801);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH YÊU CẦU VAY VỐN";
            // 
            // btnsuaYeuCau
            // 
            this.btnsuaYeuCau.Image = ((System.Drawing.Image)(resources.GetObject("btnsuaYeuCau.Image")));
            this.btnsuaYeuCau.Location = new System.Drawing.Point(1067, 731);
            this.btnsuaYeuCau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsuaYeuCau.Name = "btnsuaYeuCau";
            this.btnsuaYeuCau.Size = new System.Drawing.Size(46, 41);
            this.btnsuaYeuCau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsuaYeuCau.TabIndex = 1;
            this.btnsuaYeuCau.TabStop = false;
            this.btnsuaYeuCau.Click += new System.EventHandler(this.btnsuaYeuCau_Click);
            // 
            // dgvDanhSachYCVV
            // 
            this.dgvDanhSachYCVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachYCVV.Location = new System.Drawing.Point(7, 52);
            this.dgvDanhSachYCVV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachYCVV.Name = "dgvDanhSachYCVV";
            this.dgvDanhSachYCVV.RowHeadersWidth = 62;
            this.dgvDanhSachYCVV.RowTemplate.Height = 24;
            this.dgvDanhSachYCVV.Size = new System.Drawing.Size(1106, 671);
            this.dgvDanhSachYCVV.TabIndex = 0;
            this.dgvDanhSachYCVV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachYCVV_CellClick);
            this.dgvDanhSachYCVV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachYCVV_CellContentClick);
            // 
            // us_DanhSachYeuCauVayVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "us_DanhSachYeuCauVayVon";
            this.Size = new System.Drawing.Size(1123, 809);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnsuaYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachYCVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvDanhSachYCVV;
        public System.Windows.Forms.PictureBox btnsuaYeuCau;
    }
}
