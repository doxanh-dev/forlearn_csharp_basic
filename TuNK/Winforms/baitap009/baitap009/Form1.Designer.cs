namespace baitap009
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioChia = new System.Windows.Forms.RadioButton();
            this.radioNhan = new System.Windows.Forms.RadioButton();
            this.radioTru = new System.Windows.Forms.RadioButton();
            this.radioCong = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hạng thứ nhất";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNumber1.Location = new System.Drawing.Point(165, 29);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(66, 26);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber1);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNumber2.Location = new System.Drawing.Point(165, 71);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(66, 26);
            this.txtNumber2.TabIndex = 3;
            this.txtNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số hạng thứ hai";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textResult.Location = new System.Drawing.Point(165, 114);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(66, 26);
            this.textResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioChia);
            this.groupBox1.Controls.Add(this.radioNhan);
            this.groupBox1.Controls.Add(this.radioTru);
            this.groupBox1.Controls.Add(this.radioCong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(263, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép toán";
            // 
            // radioChia
            // 
            this.radioChia.AutoSize = true;
            this.radioChia.Location = new System.Drawing.Point(17, 104);
            this.radioChia.Name = "radioChia";
            this.radioChia.Size = new System.Drawing.Size(56, 20);
            this.radioChia.TabIndex = 3;
            this.radioChia.TabStop = true;
            this.radioChia.Text = "Chia";
            this.radioChia.UseVisualStyleBackColor = true;
            // 
            // radioNhan
            // 
            this.radioNhan.AutoSize = true;
            this.radioNhan.Location = new System.Drawing.Point(17, 78);
            this.radioNhan.Name = "radioNhan";
            this.radioNhan.Size = new System.Drawing.Size(60, 20);
            this.radioNhan.TabIndex = 2;
            this.radioNhan.TabStop = true;
            this.radioNhan.Text = "Nhân";
            this.radioNhan.UseVisualStyleBackColor = true;
            // 
            // radioTru
            // 
            this.radioTru.AutoSize = true;
            this.radioTru.Location = new System.Drawing.Point(17, 52);
            this.radioTru.Name = "radioTru";
            this.radioTru.Size = new System.Drawing.Size(48, 20);
            this.radioTru.TabIndex = 1;
            this.radioTru.TabStop = true;
            this.radioTru.Text = "Trừ";
            this.radioTru.UseVisualStyleBackColor = true;
            // 
            // radioCong
            // 
            this.radioCong.AutoSize = true;
            this.radioCong.Location = new System.Drawing.Point(17, 26);
            this.radioCong.Name = "radioCong";
            this.radioCong.Size = new System.Drawing.Size(59, 20);
            this.radioCong.TabIndex = 0;
            this.radioCong.TabStop = true;
            this.radioCong.Text = "Cộng";
            this.radioCong.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnThoat.Location = new System.Drawing.Point(37, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 36);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTinh.Location = new System.Drawing.Point(138, 156);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(80, 36);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 218);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình máy tính đơn giản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.RadioButton radioNhan;
        private System.Windows.Forms.RadioButton radioTru;
        private System.Windows.Forms.RadioButton radioCong;
        private System.Windows.Forms.RadioButton radioChia;
    }
}

