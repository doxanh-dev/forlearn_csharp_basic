namespace baitap002
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
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSoThich = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.RichTextBox();
            this.cbboxDay = new System.Windows.Forms.ComboBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(134, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // textHoTen
            // 
            this.textHoTen.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textHoTen.Location = new System.Drawing.Point(132, 77);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(170, 22);
            this.textHoTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(35, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sở thích";
            // 
            // textSoThich
            // 
            this.textSoThich.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSoThich.Location = new System.Drawing.Point(132, 141);
            this.textSoThich.Name = "textSoThich";
            this.textSoThich.Size = new System.Drawing.Size(170, 22);
            this.textSoThich.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnXem.Location = new System.Drawing.Point(78, 185);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(81, 32);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnThoat.Location = new System.Drawing.Point(195, 185);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 32);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textResult.Location = new System.Drawing.Point(37, 241);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(287, 91);
            this.textResult.TabIndex = 8;
            this.textResult.Text = "";
            // 
            // cbboxDay
            // 
            this.cbboxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxDay.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbboxDay.FormattingEnabled = true;
            this.cbboxDay.Location = new System.Drawing.Point(132, 107);
            this.cbboxDay.MaxLength = 2;
            this.cbboxDay.Name = "cbboxDay";
            this.cbboxDay.Size = new System.Drawing.Size(42, 23);
            this.cbboxDay.TabIndex = 9;
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(243, 107);
            this.cbbYear.MaxLength = 4;
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(59, 23);
            this.cbbYear.TabIndex = 10;
            // 
            // cbbMonth
            // 
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(184, 107);
            this.cbbMonth.MaxLength = 2;
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(42, 23);
            this.cbbMonth.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 358);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbboxDay);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.textSoThich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSoThich;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox textResult;
        private System.Windows.Forms.ComboBox cbboxDay;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.ComboBox cbbMonth;
    }
}

