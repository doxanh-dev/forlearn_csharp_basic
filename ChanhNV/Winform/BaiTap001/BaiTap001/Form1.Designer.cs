namespace BaiTap001
{
    partial class Form1
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
            this.dmGroupBoxThongTinDangNhap = new System.Windows.Forms.GroupBox();
            this.dmTextBoxMatKhau = new System.Windows.Forms.TextBox();
            this.dmTextBoxTenNguoiDung = new System.Windows.Forms.TextBox();
            this.dmlabelMatKhau = new System.Windows.Forms.Label();
            this.dmlabelTenNguoiDung = new System.Windows.Forms.Label();
            this.dmButtonDangNhap = new System.Windows.Forms.Button();
            this.dmButtonThoat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dmGroupBoxThongTinDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // dmGroupBoxThongTinDangNhap
            // 
            this.dmGroupBoxThongTinDangNhap.Controls.Add(this.dmTextBoxMatKhau);
            this.dmGroupBoxThongTinDangNhap.Controls.Add(this.dmTextBoxTenNguoiDung);
            this.dmGroupBoxThongTinDangNhap.Controls.Add(this.dmlabelMatKhau);
            this.dmGroupBoxThongTinDangNhap.Controls.Add(this.dmlabelTenNguoiDung);
            this.dmGroupBoxThongTinDangNhap.Location = new System.Drawing.Point(70, 44);
            this.dmGroupBoxThongTinDangNhap.Name = "dmGroupBoxThongTinDangNhap";
            this.dmGroupBoxThongTinDangNhap.Size = new System.Drawing.Size(404, 162);
            this.dmGroupBoxThongTinDangNhap.TabIndex = 0;
            this.dmGroupBoxThongTinDangNhap.TabStop = false;
            this.dmGroupBoxThongTinDangNhap.Text = "Thông tin đăng nhập";
            // 
            // dmTextBoxMatKhau
            // 
            this.dmTextBoxMatKhau.Location = new System.Drawing.Point(120, 84);
            this.dmTextBoxMatKhau.Name = "dmTextBoxMatKhau";
            this.dmTextBoxMatKhau.Size = new System.Drawing.Size(206, 22);
            this.dmTextBoxMatKhau.TabIndex = 4;
            // 
            // dmTextBoxTenNguoiDung
            // 
            this.dmTextBoxTenNguoiDung.Location = new System.Drawing.Point(120, 35);
            this.dmTextBoxTenNguoiDung.Name = "dmTextBoxTenNguoiDung";
            this.dmTextBoxTenNguoiDung.Size = new System.Drawing.Size(206, 22);
            this.dmTextBoxTenNguoiDung.TabIndex = 3;
            // 
            // dmlabelMatKhau
            // 
            this.dmlabelMatKhau.AutoSize = true;
            this.dmlabelMatKhau.Location = new System.Drawing.Point(6, 84);
            this.dmlabelMatKhau.Name = "dmlabelMatKhau";
            this.dmlabelMatKhau.Size = new System.Drawing.Size(66, 17);
            this.dmlabelMatKhau.TabIndex = 2;
            this.dmlabelMatKhau.Text = "Mật khẩu";
            // 
            // dmlabelTenNguoiDung
            // 
            this.dmlabelTenNguoiDung.AutoSize = true;
            this.dmlabelTenNguoiDung.Location = new System.Drawing.Point(6, 38);
            this.dmlabelTenNguoiDung.Name = "dmlabelTenNguoiDung";
            this.dmlabelTenNguoiDung.Size = new System.Drawing.Size(108, 17);
            this.dmlabelTenNguoiDung.TabIndex = 1;
            this.dmlabelTenNguoiDung.Text = "Tên người dùng";
            // 
            // dmButtonDangNhap
            // 
            this.dmButtonDangNhap.Location = new System.Drawing.Point(97, 266);
            this.dmButtonDangNhap.Name = "dmButtonDangNhap";
            this.dmButtonDangNhap.Size = new System.Drawing.Size(167, 40);
            this.dmButtonDangNhap.TabIndex = 1;
            this.dmButtonDangNhap.Text = "Đăng nhập";
            this.dmButtonDangNhap.UseVisualStyleBackColor = true;
            this.dmButtonDangNhap.Click += new System.EventHandler(this.dmButtonDangNhap_Click);
            // 
            // dmButtonThoat
            // 
            this.dmButtonThoat.Location = new System.Drawing.Point(270, 266);
            this.dmButtonThoat.Name = "dmButtonThoat";
            this.dmButtonThoat.Size = new System.Drawing.Size(165, 40);
            this.dmButtonThoat.TabIndex = 2;
            this.dmButtonThoat.Text = "Thoát";
            this.dmButtonThoat.UseVisualStyleBackColor = true;
            this.dmButtonThoat.Click += new System.EventHandler(this.dmButtonThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 342);
            this.Controls.Add(this.dmButtonThoat);
            this.Controls.Add(this.dmButtonDangNhap);
            this.Controls.Add(this.dmGroupBoxThongTinDangNhap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tâm gà đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dmGroupBoxThongTinDangNhap.ResumeLayout(false);
            this.dmGroupBoxThongTinDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dmGroupBoxThongTinDangNhap;
        private System.Windows.Forms.TextBox dmTextBoxMatKhau;
        private System.Windows.Forms.TextBox dmTextBoxTenNguoiDung;
        private System.Windows.Forms.Label dmlabelMatKhau;
        private System.Windows.Forms.Label dmlabelTenNguoiDung;
        private System.Windows.Forms.Button dmButtonDangNhap;
        private System.Windows.Forms.Button dmButtonThoat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

