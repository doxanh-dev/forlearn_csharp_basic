namespace baitap006
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKyTu = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnViTri = new System.Windows.Forms.Button();
            this.TextHoTen = new System.Windows.Forms.TextBox();
            this.TextViTri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên bạn vừa nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(55, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập ký tự cần tìm";
            // 
            // txtKyTu
            // 
            this.txtKyTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKyTu.Location = new System.Drawing.Point(58, 132);
            this.txtKyTu.Name = "txtKyTu";
            this.txtKyTu.Size = new System.Drawing.Size(81, 26);
            this.txtKyTu.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTim.Location = new System.Drawing.Point(156, 132);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(64, 26);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnViTri
            // 
            this.btnViTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnViTri.Location = new System.Drawing.Point(237, 132);
            this.btnViTri.Name = "btnViTri";
            this.btnViTri.Size = new System.Drawing.Size(64, 26);
            this.btnViTri.TabIndex = 5;
            this.btnViTri.Text = "Vị trí";
            this.btnViTri.UseVisualStyleBackColor = true;
            this.btnViTri.Click += new System.EventHandler(this.btnViTri_Click);
            // 
            // TextHoTen
            // 
            this.TextHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextHoTen.Location = new System.Drawing.Point(49, 60);
            this.TextHoTen.Name = "TextHoTen";
            this.TextHoTen.ReadOnly = true;
            this.TextHoTen.Size = new System.Drawing.Size(263, 26);
            this.TextHoTen.TabIndex = 7;
            // 
            // TextViTri
            // 
            this.TextViTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextViTri.Location = new System.Drawing.Point(49, 181);
            this.TextViTri.Name = "TextViTri";
            this.TextViTri.ReadOnly = true;
            this.TextViTri.Size = new System.Drawing.Size(263, 26);
            this.TextViTri.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 243);
            this.Controls.Add(this.TextViTri);
            this.Controls.Add(this.TextHoTen);
            this.Controls.Add(this.btnViTri);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtKyTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiển thị";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKyTu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnViTri;
        private System.Windows.Forms.TextBox TextHoTen;
        private System.Windows.Forms.TextBox TextViTri;
    }
}