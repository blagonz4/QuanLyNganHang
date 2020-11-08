namespace QuanLyNganHang.GUI_QLNN
{
    partial class frm_DangNhap
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.lbTaikhoan = new System.Windows.Forms.Label();
            this.lb_Dangnhaphethong = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(413, 197);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 34);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Đăng nhập";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatkhau.Location = new System.Drawing.Point(210, 162);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(321, 27);
            this.txtMatkhau.TabIndex = 25;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaikhoan.Location = new System.Drawing.Point(210, 127);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(321, 27);
            this.txtTaikhoan.TabIndex = 24;
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matkhau.Location = new System.Drawing.Point(110, 163);
            this.lb_Matkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(97, 24);
            this.lb_Matkhau.TabIndex = 23;
            this.lb_Matkhau.Text = "Password:";
            // 
            // lbTaikhoan
            // 
            this.lbTaikhoan.AutoSize = true;
            this.lbTaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan.Location = new System.Drawing.Point(105, 130);
            this.lbTaikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaikhoan.Name = "lbTaikhoan";
            this.lbTaikhoan.Size = new System.Drawing.Size(102, 24);
            this.lbTaikhoan.TabIndex = 22;
            this.lbTaikhoan.Text = "Username:";
            // 
            // lb_Dangnhaphethong
            // 
            this.lb_Dangnhaphethong.AutoSize = true;
            this.lb_Dangnhaphethong.BackColor = System.Drawing.Color.Transparent;
            this.lb_Dangnhaphethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dangnhaphethong.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_Dangnhaphethong.Location = new System.Drawing.Point(258, 33);
            this.lb_Dangnhaphethong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Dangnhaphethong.Name = "lb_Dangnhaphethong";
            this.lb_Dangnhaphethong.Size = new System.Drawing.Size(160, 26);
            this.lb_Dangnhaphethong.TabIndex = 21;
            this.lb_Dangnhaphethong.Text = "ĐĂNG NHẬP ";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::QuanLyNganHang.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(632, 86);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 28;
            this.pbLogo.TabStop = false;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(632, 275);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.lb_Matkhau);
            this.Controls.Add(this.lbTaikhoan);
            this.Controls.Add(this.lb_Dangnhaphethong);
            this.ForeColor = System.Drawing.Color.Brown;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        public System.Windows.Forms.Label lb_Matkhau;
        public System.Windows.Forms.Label lbTaikhoan;
        public System.Windows.Forms.Label lb_Dangnhaphethong;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.PictureBox pbLogo;
    }
}