namespace BaiTap007
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNhapDaySo = new System.Windows.Forms.TextBox();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.buttonThucHien = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(140, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đọc Số Thành Chữ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(80, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập dãy số : (Từ 1 - 999)";
            // 
            // textBoxNhapDaySo
            // 
            this.textBoxNhapDaySo.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNhapDaySo.Location = new System.Drawing.Point(356, 107);
            this.textBoxNhapDaySo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNhapDaySo.MaxLength = 3;
            this.textBoxNhapDaySo.Multiline = true;
            this.textBoxNhapDaySo.Name = "textBoxNhapDaySo";
            this.textBoxNhapDaySo.Size = new System.Drawing.Size(127, 37);
            this.textBoxNhapDaySo.TabIndex = 2;
            this.textBoxNhapDaySo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNhapDaySo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhapDaySo_KeyPress);
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.BackColor = System.Drawing.Color.LightSalmon;
            this.textBoxKetQua.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxKetQua.ForeColor = System.Drawing.Color.Blue;
            this.textBoxKetQua.Location = new System.Drawing.Point(84, 220);
            this.textBoxKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKetQua.Multiline = true;
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(399, 41);
            this.textBoxKetQua.TabIndex = 3;
            this.textBoxKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonThucHien
            // 
            this.buttonThucHien.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonThucHien.Location = new System.Drawing.Point(84, 165);
            this.buttonThucHien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThucHien.Name = "buttonThucHien";
            this.buttonThucHien.Size = new System.Drawing.Size(128, 47);
            this.buttonThucHien.TabIndex = 4;
            this.buttonThucHien.Text = "Thực hiện";
            this.buttonThucHien.UseVisualStyleBackColor = true;
            this.buttonThucHien.Click += new System.EventHandler(this.buttonThucHien_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonXoa.Location = new System.Drawing.Point(220, 165);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(128, 47);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonThoat.Location = new System.Drawing.Point(356, 165);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(128, 47);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 297);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThucHien);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.textBoxNhapDaySo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(578, 344);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc số thành chứ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNhapDaySo;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Button buttonThucHien;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
    }
}

