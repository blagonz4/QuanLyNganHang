namespace QuanLyNganHang.GUI_QLNN
{
    partial class frm_QuanLyHopDong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDanhsachhopdong = new System.Windows.Forms.Button();
            this.btndanhsachycvv = new System.Windows.Forms.Button();
            this.btnDanhsachkh = new System.Windows.Forms.Button();
            this.btnBaocaogiamsat = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btnDanhsachhopdong);
            this.panel1.Controls.Add(this.btndanhsachycvv);
            this.panel1.Controls.Add(this.btnDanhsachkh);
            this.panel1.Controls.Add(this.btnBaocaogiamsat);
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 623);
            this.panel1.TabIndex = 1;
            // 
            // btnDanhsachhopdong
            // 
            this.btnDanhsachhopdong.BackColor = System.Drawing.Color.White;
            this.btnDanhsachhopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsachhopdong.ForeColor = System.Drawing.Color.Black;
            this.btnDanhsachhopdong.Location = new System.Drawing.Point(12, 302);
            this.btnDanhsachhopdong.Name = "btnDanhsachhopdong";
            this.btnDanhsachhopdong.Size = new System.Drawing.Size(245, 78);
            this.btnDanhsachhopdong.TabIndex = 30;
            this.btnDanhsachhopdong.Text = "Danh sách hợp đồng";
            this.btnDanhsachhopdong.UseVisualStyleBackColor = false;
            this.btnDanhsachhopdong.Click += new System.EventHandler(this.btnDanhsachhopdong_Click);
            // 
            // btndanhsachycvv
            // 
            this.btndanhsachycvv.BackColor = System.Drawing.Color.White;
            this.btndanhsachycvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndanhsachycvv.ForeColor = System.Drawing.Color.Black;
            this.btndanhsachycvv.Location = new System.Drawing.Point(12, 202);
            this.btndanhsachycvv.Name = "btndanhsachycvv";
            this.btndanhsachycvv.Size = new System.Drawing.Size(245, 78);
            this.btndanhsachycvv.TabIndex = 30;
            this.btndanhsachycvv.Text = "Danh sách yêu cầu vay vốn";
            this.btndanhsachycvv.UseVisualStyleBackColor = false;
            this.btndanhsachycvv.Click += new System.EventHandler(this.btndanhsachycvv_Click);
            // 
            // btnDanhsachkh
            // 
            this.btnDanhsachkh.BackColor = System.Drawing.Color.White;
            this.btnDanhsachkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsachkh.ForeColor = System.Drawing.Color.Black;
            this.btnDanhsachkh.Location = new System.Drawing.Point(12, 100);
            this.btnDanhsachkh.Name = "btnDanhsachkh";
            this.btnDanhsachkh.Size = new System.Drawing.Size(245, 78);
            this.btnDanhsachkh.TabIndex = 2;
            this.btnDanhsachkh.Text = "Danh sách khách hàng";
            this.btnDanhsachkh.UseVisualStyleBackColor = false;
            this.btnDanhsachkh.Click += new System.EventHandler(this.btnDanhsachkh_Click);
            // 
            // btnBaocaogiamsat
            // 
            this.btnBaocaogiamsat.BackColor = System.Drawing.Color.White;
            this.btnBaocaogiamsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocaogiamsat.ForeColor = System.Drawing.Color.Black;
            this.btnBaocaogiamsat.Location = new System.Drawing.Point(12, 0);
            this.btnBaocaogiamsat.Name = "btnBaocaogiamsat";
            this.btnBaocaogiamsat.Size = new System.Drawing.Size(245, 78);
            this.btnBaocaogiamsat.TabIndex = 1;
            this.btnBaocaogiamsat.Text = "Báo cáo giám sát";
            this.btnBaocaogiamsat.UseVisualStyleBackColor = false;
            this.btnBaocaogiamsat.Click += new System.EventHandler(this.btnBaocaogiamsat_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(272, 94);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(998, 647);
            this.pnlMain.TabIndex = 31;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::QuanLyNganHang.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1282, 86);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 32;
            this.pbLogo.TabStop = false;
            // 
            // frm_QuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1282, 754);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí hợp đồng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnDanhsachhopdong;
        public System.Windows.Forms.Button btndanhsachycvv;
        public System.Windows.Forms.Button btnDanhsachkh;
        public System.Windows.Forms.Button btnBaocaogiamsat;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Panel pnlMain;
    }
}