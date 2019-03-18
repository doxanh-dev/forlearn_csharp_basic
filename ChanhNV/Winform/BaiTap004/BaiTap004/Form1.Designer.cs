namespace BaiTap004
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
            this.labelGiaiPhuongTrinh = new System.Windows.Forms.Label();
            this.radioButtonGiaiPTBacMot = new System.Windows.Forms.RadioButton();
            this.labelNhapA = new System.Windows.Forms.Label();
            this.textBoxNhapA = new System.Windows.Forms.TextBox();
            this.radioButtonGiaiPTBacHai = new System.Windows.Forms.RadioButton();
            this.labelNhapB = new System.Windows.Forms.Label();
            this.labelNhapC = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.textBoxNhapB = new System.Windows.Forms.TextBox();
            this.textBoxNhapC = new System.Windows.Forms.TextBox();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.buttonGiai = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBoxChon = new System.Windows.Forms.GroupBox();
            this.groupBoxChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGiaiPhuongTrinh
            // 
            this.labelGiaiPhuongTrinh.AutoSize = true;
            this.labelGiaiPhuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaiPhuongTrinh.ForeColor = System.Drawing.Color.Red;
            this.labelGiaiPhuongTrinh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelGiaiPhuongTrinh.Location = new System.Drawing.Point(107, 9);
            this.labelGiaiPhuongTrinh.Name = "labelGiaiPhuongTrinh";
            this.labelGiaiPhuongTrinh.Size = new System.Drawing.Size(276, 39);
            this.labelGiaiPhuongTrinh.TabIndex = 0;
            this.labelGiaiPhuongTrinh.Text = "Giải phương trình";
            // 
            // radioButtonGiaiPTBacMot
            // 
            this.radioButtonGiaiPTBacMot.AutoSize = true;
            this.radioButtonGiaiPTBacMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGiaiPTBacMot.Location = new System.Drawing.Point(6, 38);
            this.radioButtonGiaiPTBacMot.Name = "radioButtonGiaiPTBacMot";
            this.radioButtonGiaiPTBacMot.Size = new System.Drawing.Size(206, 24);
            this.radioButtonGiaiPTBacMot.TabIndex = 2;
            this.radioButtonGiaiPTBacMot.TabStop = true;
            this.radioButtonGiaiPTBacMot.Text = "Giải phương trình Bậc 1";
            this.radioButtonGiaiPTBacMot.UseVisualStyleBackColor = true;
            this.radioButtonGiaiPTBacMot.CheckedChanged += new System.EventHandler(this.radioButtonGiaiPTBacMot_CheckedChanged);
            // 
            // labelNhapA
            // 
            this.labelNhapA.AutoSize = true;
            this.labelNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapA.Location = new System.Drawing.Point(50, 208);
            this.labelNhapA.Name = "labelNhapA";
            this.labelNhapA.Size = new System.Drawing.Size(67, 20);
            this.labelNhapA.TabIndex = 4;
            this.labelNhapA.Text = "Nhập a:";
            // 
            // textBoxNhapA
            // 
            this.textBoxNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapA.Location = new System.Drawing.Point(130, 195);
            this.textBoxNhapA.Multiline = true;
            this.textBoxNhapA.Name = "textBoxNhapA";
            this.textBoxNhapA.Size = new System.Drawing.Size(187, 33);
            this.textBoxNhapA.TabIndex = 4;
            this.textBoxNhapA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhapA_KeyPress);
            // 
            // radioButtonGiaiPTBacHai
            // 
            this.radioButtonGiaiPTBacHai.AutoSize = true;
            this.radioButtonGiaiPTBacHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGiaiPTBacHai.Location = new System.Drawing.Point(6, 79);
            this.radioButtonGiaiPTBacHai.Name = "radioButtonGiaiPTBacHai";
            this.radioButtonGiaiPTBacHai.Size = new System.Drawing.Size(206, 24);
            this.radioButtonGiaiPTBacHai.TabIndex = 3;
            this.radioButtonGiaiPTBacHai.TabStop = true;
            this.radioButtonGiaiPTBacHai.Text = "Giải phương trình Bậc 2";
            this.radioButtonGiaiPTBacHai.UseVisualStyleBackColor = true;
            this.radioButtonGiaiPTBacHai.CheckedChanged += new System.EventHandler(this.radioButtonGiaiPTBacHai_CheckedChanged);
            // 
            // labelNhapB
            // 
            this.labelNhapB.AutoSize = true;
            this.labelNhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapB.Location = new System.Drawing.Point(50, 250);
            this.labelNhapB.Name = "labelNhapB";
            this.labelNhapB.Size = new System.Drawing.Size(67, 20);
            this.labelNhapB.TabIndex = 10;
            this.labelNhapB.Text = "Nhập b:";
            // 
            // labelNhapC
            // 
            this.labelNhapC.AutoSize = true;
            this.labelNhapC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapC.Location = new System.Drawing.Point(50, 290);
            this.labelNhapC.Name = "labelNhapC";
            this.labelNhapC.Size = new System.Drawing.Size(67, 20);
            this.labelNhapC.TabIndex = 11;
            this.labelNhapC.Text = "Nhập c:";
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetQua.Location = new System.Drawing.Point(46, 350);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(71, 20);
            this.labelKetQua.TabIndex = 13;
            this.labelKetQua.Text = "Kết quả:";
            // 
            // textBoxNhapB
            // 
            this.textBoxNhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapB.Location = new System.Drawing.Point(130, 237);
            this.textBoxNhapB.Multiline = true;
            this.textBoxNhapB.Name = "textBoxNhapB";
            this.textBoxNhapB.Size = new System.Drawing.Size(187, 33);
            this.textBoxNhapB.TabIndex = 5;
            this.textBoxNhapB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhapB_KeyPress);
            // 
            // textBoxNhapC
            // 
            this.textBoxNhapC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapC.Location = new System.Drawing.Point(130, 276);
            this.textBoxNhapC.Multiline = true;
            this.textBoxNhapC.Name = "textBoxNhapC";
            this.textBoxNhapC.Size = new System.Drawing.Size(187, 33);
            this.textBoxNhapC.TabIndex = 6;
            this.textBoxNhapC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhapC_KeyPress);
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.Enabled = false;
            this.textBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKetQua.Location = new System.Drawing.Point(130, 315);
            this.textBoxKetQua.Multiline = true;
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(312, 55);
            this.textBoxKetQua.TabIndex = 7;
            // 
            // buttonGiai
            // 
            this.buttonGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiai.Location = new System.Drawing.Point(348, 195);
            this.buttonGiai.Name = "buttonGiai";
            this.buttonGiai.Size = new System.Drawing.Size(94, 75);
            this.buttonGiai.TabIndex = 17;
            this.buttonGiai.Text = "Giải";
            this.buttonGiai.UseVisualStyleBackColor = true;
            this.buttonGiai.Click += new System.EventHandler(this.buttonGiai_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(348, 277);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(94, 32);
            this.buttonThoat.TabIndex = 18;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // groupBoxChon
            // 
            this.groupBoxChon.Controls.Add(this.radioButtonGiaiPTBacMot);
            this.groupBoxChon.Controls.Add(this.radioButtonGiaiPTBacHai);
            this.groupBoxChon.Location = new System.Drawing.Point(115, 72);
            this.groupBoxChon.Name = "groupBoxChon";
            this.groupBoxChon.Size = new System.Drawing.Size(268, 117);
            this.groupBoxChon.TabIndex = 19;
            this.groupBoxChon.TabStop = false;
            this.groupBoxChon.Text = "Bạn vui lòng chọn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(498, 414);
            this.Controls.Add(this.groupBoxChon);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonGiai);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.textBoxNhapC);
            this.Controls.Add(this.textBoxNhapB);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.labelNhapC);
            this.Controls.Add(this.labelNhapB);
            this.Controls.Add(this.textBoxNhapA);
            this.Controls.Add(this.labelNhapA);
            this.Controls.Add(this.labelGiaiPhuongTrinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(609, 461);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc 1 - 2";
            this.groupBoxChon.ResumeLayout(false);
            this.groupBoxChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGiaiPhuongTrinh;
        private System.Windows.Forms.RadioButton radioButtonGiaiPTBacMot;
        private System.Windows.Forms.Label labelNhapA;
        private System.Windows.Forms.TextBox textBoxNhapA;
        private System.Windows.Forms.RadioButton radioButtonGiaiPTBacHai;
        private System.Windows.Forms.Label labelNhapB;
        private System.Windows.Forms.Label labelNhapC;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.TextBox textBoxNhapB;
        private System.Windows.Forms.TextBox textBoxNhapC;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Button buttonGiai;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.GroupBox groupBoxChon;
    }
}

