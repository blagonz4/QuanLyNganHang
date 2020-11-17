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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDskh = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDskh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDskh);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dgvDskh
            // 
            this.dgvDskh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDskh.Location = new System.Drawing.Point(0, 21);
            this.dgvDskh.Name = "dgvDskh";
            this.dgvDskh.RowTemplate.Height = 24;
            this.dgvDskh.Size = new System.Drawing.Size(992, 563);
            this.dgvDskh.TabIndex = 0;
            // 
            // us_DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "us_DanhSachKhachHang";
            this.Size = new System.Drawing.Size(998, 647);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDskh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvDskh;
    }
}
