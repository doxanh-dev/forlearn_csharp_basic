namespace BaiTap005
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
            this.radioButtonGiaiPTBacHai = new System.Windows.Forms.RadioButton();
            this.radioButtonGiaiPTBacMot = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNhapA = new System.Windows.Forms.TextBox();
            this.buttonGiai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxNhapB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.textBoxNhapC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonGiaiPTBacHai);
            this.groupBox1.Controls.Add(this.radioButtonGiaiPTBacMot);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mời bạn chọn";
            // 
            // radioButtonGiaiPTBacHai
            // 
            this.radioButtonGiaiPTBacHai.AutoSize = true;
            this.radioButtonGiaiPTBacHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGiaiPTBacHai.Location = new System.Drawing.Point(6, 61);
            this.radioButtonGiaiPTBacHai.Name = "radioButtonGiaiPTBacHai";
            this.radioButtonGiaiPTBacHai.Size = new System.Drawing.Size(189, 22);
            this.radioButtonGiaiPTBacHai.TabIndex = 1;
            this.radioButtonGiaiPTBacHai.TabStop = true;
            this.radioButtonGiaiPTBacHai.Text = "Giải Phương Trình Bậc 2";
            this.radioButtonGiaiPTBacHai.UseVisualStyleBackColor = true;
            this.radioButtonGiaiPTBacHai.CheckedChanged += new System.EventHandler(this.radioButtonGiaiPTBacHai_CheckedChanged);
            // 
            // radioButtonGiaiPTBacMot
            // 
            this.radioButtonGiaiPTBacMot.AutoSize = true;
            this.radioButtonGiaiPTBacMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGiaiPTBacMot.Location = new System.Drawing.Point(6, 33);
            this.radioButtonGiaiPTBacMot.Name = "radioButtonGiaiPTBacMot";
            this.radioButtonGiaiPTBacMot.Size = new System.Drawing.Size(189, 22);
            this.radioButtonGiaiPTBacMot.TabIndex = 0;
            this.radioButtonGiaiPTBacMot.TabStop = true;
            this.radioButtonGiaiPTBacMot.Text = "Giải Phương Trình Bậc 1";
            this.radioButtonGiaiPTBacMot.UseVisualStyleBackColor = true;
            this.radioButtonGiaiPTBacMot.CheckedChanged += new System.EventHandler(this.radioButtonGiaiPTBacMot_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a:";
            // 
            // textBoxNhapA
            // 
            this.textBoxNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapA.Location = new System.Drawing.Point(110, 204);
            this.textBoxNhapA.Multiline = true;
            this.textBoxNhapA.Name = "textBoxNhapA";
            this.textBoxNhapA.Size = new System.Drawing.Size(207, 31);
            this.textBoxNhapA.TabIndex = 3;
            this.textBoxNhapA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhapA_KeyPress);
            // 
            // buttonGiai
            // 
            this.buttonGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiai.Location = new System.Drawing.Point(323, 204);
            this.buttonGiai.Name = "buttonGiai";
            this.buttonGiai.Size = new System.Drawing.Size(133, 31);
            this.buttonGiai.TabIndex = 4;
            this.buttonGiai.Text = "Giải";
            this.buttonGiai.UseVisualStyleBackColor = true;
            this.buttonGiai.Click += new System.EventHandler(this.buttonGiai_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(323, 241);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(133, 31);
            this.buttonXoa.TabIndex = 7;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // textBoxNhapB
            // 
            this.textBoxNhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapB.Location = new System.Drawing.Point(110, 241);
            this.textBoxNhapB.Multiline = true;
            this.textBoxNhapB.Name = "textBoxNhapB";
            this.textBoxNhapB.Size = new System.Drawing.Size(207, 31);
            this.textBoxNhapB.TabIndex = 6;
            this.textBoxNhapB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhapB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập b:";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(323, 278);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(133, 31);
            this.buttonThoat.TabIndex = 10;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // textBoxNhapC
            // 
            this.textBoxNhapC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapC.Location = new System.Drawing.Point(110, 278);
            this.textBoxNhapC.Multiline = true;
            this.textBoxNhapC.Name = "textBoxNhapC";
            this.textBoxNhapC.Size = new System.Drawing.Size(207, 31);
            this.textBoxNhapC.TabIndex = 9;
            this.textBoxNhapC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhapC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kết quả:";
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.Enabled = false;
            this.textBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKetQua.Location = new System.Drawing.Point(110, 315);
            this.textBoxKetQua.Multiline = true;
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(346, 62);
            this.textBoxKetQua.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 418);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.textBoxNhapC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.textBoxNhapB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGiai);
            this.Controls.Add(this.textBoxNhapA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(520, 465);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải PT Bâc 1-2 Cách 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonGiaiPTBacMot;
        private System.Windows.Forms.RadioButton radioButtonGiaiPTBacHai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNhapA;
        private System.Windows.Forms.Button buttonGiai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.TextBox textBoxNhapB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxNhapC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKetQua;
    }
}

