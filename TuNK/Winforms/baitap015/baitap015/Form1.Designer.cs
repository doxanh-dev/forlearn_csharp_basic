namespace baitap015
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMauSo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuSo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMauSo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuSo2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.grBoxKQ = new System.Windows.Forms.GroupBox();
            this.txtKQMauSo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKQTuSo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grBoxKQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phép Tính Phân Số";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMauSo1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTuSo1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(172, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân số 1:";
            // 
            // txtMauSo1
            // 
            this.txtMauSo1.Location = new System.Drawing.Point(96, 72);
            this.txtMauSo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMauSo1.MaxLength = 2;
            this.txtMauSo1.Name = "txtMauSo1";
            this.txtMauSo1.Size = new System.Drawing.Size(49, 30);
            this.txtMauSo1.TabIndex = 3;
            this.txtMauSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMauSo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMauSo1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mẫu số:";
            // 
            // txtTuSo1
            // 
            this.txtTuSo1.Location = new System.Drawing.Point(96, 33);
            this.txtTuSo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTuSo1.MaxLength = 2;
            this.txtTuSo1.Name = "txtTuSo1";
            this.txtTuSo1.Size = new System.Drawing.Size(49, 30);
            this.txtTuSo1.TabIndex = 1;
            this.txtTuSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTuSo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuSo1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tử số:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMauSo2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTuSo2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(240, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(172, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân số 2:";
            // 
            // txtMauSo2
            // 
            this.txtMauSo2.Location = new System.Drawing.Point(96, 72);
            this.txtMauSo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMauSo2.MaxLength = 2;
            this.txtMauSo2.Name = "txtMauSo2";
            this.txtMauSo2.Size = new System.Drawing.Size(49, 30);
            this.txtMauSo2.TabIndex = 3;
            this.txtMauSo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMauSo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMauSo2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mẫu số:";
            // 
            // txtTuSo2
            // 
            this.txtTuSo2.Location = new System.Drawing.Point(96, 33);
            this.txtTuSo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTuSo2.MaxLength = 2;
            this.txtTuSo2.Name = "txtTuSo2";
            this.txtTuSo2.Size = new System.Drawing.Size(49, 30);
            this.txtTuSo2.TabIndex = 1;
            this.txtTuSo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTuSo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuSo2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tử số:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChia);
            this.groupBox3.Controls.Add(this.btnCong);
            this.groupBox3.Controls.Add(this.btnTru);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(43, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(172, 136);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phép tính";
            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChia.Location = new System.Drawing.Point(92, 80);
            this.btnChia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(68, 41);
            this.btnChia.TabIndex = 1;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(15, 31);
            this.btnCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(67, 41);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTru.Location = new System.Drawing.Point(92, 31);
            this.btnTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(68, 41);
            this.btnTru.TabIndex = 2;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // grBoxKQ
            // 
            this.grBoxKQ.Controls.Add(this.txtKQMauSo);
            this.grBoxKQ.Controls.Add(this.label8);
            this.grBoxKQ.Controls.Add(this.txtKQTuSo);
            this.grBoxKQ.Controls.Add(this.label9);
            this.grBoxKQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxKQ.ForeColor = System.Drawing.Color.Blue;
            this.grBoxKQ.Location = new System.Drawing.Point(240, 228);
            this.grBoxKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grBoxKQ.Name = "grBoxKQ";
            this.grBoxKQ.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grBoxKQ.Size = new System.Drawing.Size(172, 136);
            this.grBoxKQ.TabIndex = 5;
            this.grBoxKQ.TabStop = false;
            this.grBoxKQ.Text = "Kết quả";
            // 
            // txtKQMauSo
            // 
            this.txtKQMauSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKQMauSo.Enabled = false;
            this.txtKQMauSo.Location = new System.Drawing.Point(96, 72);
            this.txtKQMauSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQMauSo.Name = "txtKQMauSo";
            this.txtKQMauSo.Size = new System.Drawing.Size(49, 30);
            this.txtKQMauSo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mẫu số:";
            // 
            // txtKQTuSo
            // 
            this.txtKQTuSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKQTuSo.Enabled = false;
            this.txtKQTuSo.Location = new System.Drawing.Point(96, 33);
            this.txtKQTuSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQTuSo.Name = "txtKQTuSo";
            this.txtKQTuSo.Size = new System.Drawing.Size(49, 30);
            this.txtKQTuSo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tử số:";
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.Location = new System.Drawing.Point(57, 308);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(67, 41);
            this.btnNhan.TabIndex = 3;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Location = new System.Drawing.Point(103, 384);
            this.btnTiepTuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(100, 40);
            this.btnTiepTuc.TabIndex = 6;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(256, 384);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 465);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.grBoxKQ);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý phân số";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.grBoxKQ.ResumeLayout(false);
            this.grBoxKQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMauSo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuSo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMauSo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTuSo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grBoxKQ;
        private System.Windows.Forms.TextBox txtKQMauSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKQTuSo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}

