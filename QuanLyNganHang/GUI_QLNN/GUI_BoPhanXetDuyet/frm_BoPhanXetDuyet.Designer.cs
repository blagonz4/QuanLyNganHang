namespace QuanLyNganHang.GUI_QLNN
{
    partial class frm_BoPhanXetDuyet
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
            this.pnlMainBPXD = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainBPXD
            // 
            this.pnlMainBPXD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainBPXD.BackColor = System.Drawing.Color.White;
            this.pnlMainBPXD.Location = new System.Drawing.Point(14, 120);
            this.pnlMainBPXD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMainBPXD.MaximumSize = new System.Drawing.Size(1415, 806);
            this.pnlMainBPXD.Name = "pnlMainBPXD";
            this.pnlMainBPXD.Size = new System.Drawing.Size(1415, 806);
            this.pnlMainBPXD.TabIndex = 33;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::QuanLyNganHang.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1442, 108);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 32;
            this.pbLogo.TabStop = false;
            // 
            // frm_BoPhanXetDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1442, 941);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlMainBPXD);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_BoPhanXetDuyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ phận xét duyệt";
            this.Load += new System.EventHandler(this.frm_BoPhanXetDuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Panel pnlMainBPXD;
    }
}