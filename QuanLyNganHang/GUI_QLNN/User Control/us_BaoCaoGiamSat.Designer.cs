namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class us_BaoCaoGiamSat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_BaoCaoGiamSat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.PictureBox();
            this.tbCmnd = new System.Windows.Forms.TextBox();
            this.dgvDanhSachBCGS = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBCGS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.tbCmnd);
            this.groupBox1.Controls.Add(this.dgvDanhSachBCGS);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 787);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH BÁO CÁO GIÁM SÁT";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DarkRed;
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(983, 731);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(130, 46);
            this.btnXem.TabIndex = 35;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            this.btnXem.MouseLeave += new System.EventHandler(this.btnXem_MouseLeave);
            this.btnXem.MouseHover += new System.EventHandler(this.btnXem_MouseHover);
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
            // dgvDanhSachBCGS
            // 
            this.dgvDanhSachBCGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBCGS.Location = new System.Drawing.Point(7, 74);
            this.dgvDanhSachBCGS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachBCGS.MultiSelect = false;
            this.dgvDanhSachBCGS.Name = "dgvDanhSachBCGS";
            this.dgvDanhSachBCGS.ReadOnly = true;
            this.dgvDanhSachBCGS.RowHeadersWidth = 62;
            this.dgvDanhSachBCGS.RowTemplate.Height = 24;
            this.dgvDanhSachBCGS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBCGS.Size = new System.Drawing.Size(1106, 649);
            this.dgvDanhSachBCGS.TabIndex = 1;
            this.dgvDanhSachBCGS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBCGS_CellClick);
            // 
            // us_BaoCaoGiamSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "us_BaoCaoGiamSat";
            this.Size = new System.Drawing.Size(1123, 792);
            this.Load += new System.EventHandler(this.us_BaoCaoGiamSat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBCGS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.PictureBox btnFind;
        public System.Windows.Forms.TextBox tbCmnd;
        public System.Windows.Forms.DataGridView dgvDanhSachBCGS;
    }
}
