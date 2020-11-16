namespace QuanLyNganHang.GUI_QLNN.User_Control
{
    partial class us_LapHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_LapHopDong));
            this.gbLapHopDong = new System.Windows.Forms.GroupBox();
            this.tbCmnd = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.PictureBox();
            this.dgvDanhSachycvv = new System.Windows.Forms.DataGridView();
            this.btnLapHopDong = new System.Windows.Forms.Button();
            this.HopDong = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.gbLapHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachycvv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLapHopDong
            // 
            this.gbLapHopDong.Controls.Add(this.btnLapHopDong);
            this.gbLapHopDong.Controls.Add(this.dgvDanhSachycvv);
            this.gbLapHopDong.Controls.Add(this.btnFind);
            this.gbLapHopDong.Controls.Add(this.tbCmnd);
            this.gbLapHopDong.Location = new System.Drawing.Point(3, 3);
            this.gbLapHopDong.Name = "gbLapHopDong";
            this.gbLapHopDong.Size = new System.Drawing.Size(992, 641);
            this.gbLapHopDong.TabIndex = 2;
            this.gbLapHopDong.TabStop = false;
            this.gbLapHopDong.Text = "Lập hợp đồng";
            // 
            // tbCmnd
            // 
            this.tbCmnd.ForeColor = System.Drawing.Color.Gray;
            this.tbCmnd.Location = new System.Drawing.Point(377, 25);
            this.tbCmnd.Name = "tbCmnd";
            this.tbCmnd.Size = new System.Drawing.Size(133, 22);
            this.tbCmnd.TabIndex = 0;
            this.tbCmnd.Text = "Nhập CMND";
            this.tbCmnd.Click += new System.EventHandler(this.tbCmnd_Click);
            this.tbCmnd.TextChanged += new System.EventHandler(this.tbCmnd_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(516, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(25, 26);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFind.TabIndex = 1;
            this.btnFind.TabStop = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvDanhSachycvv
            // 
            this.dgvDanhSachycvv.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachycvv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachycvv.Location = new System.Drawing.Point(6, 71);
            this.dgvDanhSachycvv.Name = "dgvDanhSachycvv";
            this.dgvDanhSachycvv.RowTemplate.Height = 24;
            this.dgvDanhSachycvv.Size = new System.Drawing.Size(980, 509);
            this.dgvDanhSachycvv.TabIndex = 2;
            this.dgvDanhSachycvv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachycvv_CellClick);
            this.dgvDanhSachycvv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachycvv_CellContentClick);
            // 
            // btnLapHopDong
            // 
            this.btnLapHopDong.BackColor = System.Drawing.Color.DarkRed;
            this.btnLapHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHopDong.ForeColor = System.Drawing.Color.White;
            this.btnLapHopDong.Location = new System.Drawing.Point(221, 586);
            this.btnLapHopDong.Name = "btnLapHopDong";
            this.btnLapHopDong.Size = new System.Drawing.Size(598, 49);
            this.btnLapHopDong.TabIndex = 3;
            this.btnLapHopDong.Text = "Lập hợp đồng";
            this.btnLapHopDong.UseVisualStyleBackColor = false;
            this.btnLapHopDong.Click += new System.EventHandler(this.btnLapHopDong_Click);
            this.btnLapHopDong.MouseLeave += new System.EventHandler(this.btnLapHopDong_MouseLeave);
            this.btnLapHopDong.MouseHover += new System.EventHandler(this.btnLapHopDong_MouseHover);
            // 
            // HopDong
            // 
            this.HopDong.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.HopDong_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // us_LapHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLapHopDong);
            this.Name = "us_LapHopDong";
            this.Size = new System.Drawing.Size(998, 647);
            this.gbLapHopDong.ResumeLayout(false);
            this.gbLapHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachycvv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gbLapHopDong;
        private System.Windows.Forms.PictureBox btnFind;
        public System.Windows.Forms.TextBox tbCmnd;
        private System.Windows.Forms.DataGridView dgvDanhSachycvv;
        public System.Windows.Forms.Button btnLapHopDong;
        public System.Drawing.Printing.PrintDocument HopDong;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}
