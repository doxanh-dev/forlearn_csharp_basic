namespace BaiTap002
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dmComboBoxNgay = new System.Windows.Forms.ComboBox();
            this.dmComboBoxThang = new System.Windows.Forms.ComboBox();
            this.dmComboBoxNam = new System.Windows.Forms.ComboBox();
            this.dmTextBoxHoVaTen = new System.Windows.Forms.TextBox();
            this.dmTextBoxSoThich = new System.Windows.Forms.TextBox();
            this.dmButtonXem = new System.Windows.Forms.Button();
            this.dmButtonThoat = new System.Windows.Forms.Button();
            this.dmListBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(179, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sở thích";
            // 
            // dmComboBoxNgay
            // 
            this.dmComboBoxNgay.FormattingEnabled = true;
            this.dmComboBoxNgay.Location = new System.Drawing.Point(184, 153);
            this.dmComboBoxNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dmComboBoxNgay.Name = "dmComboBoxNgay";
            this.dmComboBoxNgay.Size = new System.Drawing.Size(51, 24);
            this.dmComboBoxNgay.TabIndex = 1;
            // 
            // dmComboBoxThang
            // 
            this.dmComboBoxThang.FormattingEnabled = true;
            this.dmComboBoxThang.Location = new System.Drawing.Point(244, 153);
            this.dmComboBoxThang.Margin = new System.Windows.Forms.Padding(4);
            this.dmComboBoxThang.Name = "dmComboBoxThang";
            this.dmComboBoxThang.Size = new System.Drawing.Size(48, 24);
            this.dmComboBoxThang.TabIndex = 2;
            this.dmComboBoxThang.SelectedIndexChanged += new System.EventHandler(this.dmComboBoxThang_SelectedIndexChanged);
            // 
            // dmComboBoxNam
            // 
            this.dmComboBoxNam.FormattingEnabled = true;
            this.dmComboBoxNam.Location = new System.Drawing.Point(301, 153);
            this.dmComboBoxNam.Margin = new System.Windows.Forms.Padding(4);
            this.dmComboBoxNam.Name = "dmComboBoxNam";
            this.dmComboBoxNam.Size = new System.Drawing.Size(92, 24);
            this.dmComboBoxNam.TabIndex = 3;
            // 
            // dmTextBoxHoVaTen
            // 
            this.dmTextBoxHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmTextBoxHoVaTen.Location = new System.Drawing.Point(184, 92);
            this.dmTextBoxHoVaTen.Margin = new System.Windows.Forms.Padding(4);
            this.dmTextBoxHoVaTen.Multiline = true;
            this.dmTextBoxHoVaTen.Name = "dmTextBoxHoVaTen";
            this.dmTextBoxHoVaTen.Size = new System.Drawing.Size(209, 36);
            this.dmTextBoxHoVaTen.TabIndex = 0;
            // 
            // dmTextBoxSoThich
            // 
            this.dmTextBoxSoThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmTextBoxSoThich.Location = new System.Drawing.Point(184, 207);
            this.dmTextBoxSoThich.Margin = new System.Windows.Forms.Padding(4);
            this.dmTextBoxSoThich.Multiline = true;
            this.dmTextBoxSoThich.Name = "dmTextBoxSoThich";
            this.dmTextBoxSoThich.Size = new System.Drawing.Size(209, 36);
            this.dmTextBoxSoThich.TabIndex = 4;
            // 
            // dmButtonXem
            // 
            this.dmButtonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmButtonXem.Location = new System.Drawing.Point(84, 268);
            this.dmButtonXem.Margin = new System.Windows.Forms.Padding(4);
            this.dmButtonXem.Name = "dmButtonXem";
            this.dmButtonXem.Size = new System.Drawing.Size(133, 43);
            this.dmButtonXem.TabIndex = 5;
            this.dmButtonXem.Text = "Xem";
            this.dmButtonXem.UseVisualStyleBackColor = true;
            this.dmButtonXem.Click += new System.EventHandler(this.dmButtonXem_Click);
            // 
            // dmButtonThoat
            // 
            this.dmButtonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmButtonThoat.Location = new System.Drawing.Point(271, 268);
            this.dmButtonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.dmButtonThoat.Name = "dmButtonThoat";
            this.dmButtonThoat.Size = new System.Drawing.Size(124, 43);
            this.dmButtonThoat.TabIndex = 6;
            this.dmButtonThoat.Text = "Thoát";
            this.dmButtonThoat.UseVisualStyleBackColor = true;
            this.dmButtonThoat.Click += new System.EventHandler(this.dmButtonThoat_Click);
            // 
            // dmListBoxResult
            // 
            this.dmListBoxResult.FormattingEnabled = true;
            this.dmListBoxResult.ItemHeight = 16;
            this.dmListBoxResult.Location = new System.Drawing.Point(84, 340);
            this.dmListBoxResult.Name = "dmListBoxResult";
            this.dmListBoxResult.Size = new System.Drawing.Size(309, 196);
            this.dmListBoxResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 563);
            this.Controls.Add(this.dmListBoxResult);
            this.Controls.Add(this.dmButtonThoat);
            this.Controls.Add(this.dmButtonXem);
            this.Controls.Add(this.dmTextBoxSoThich);
            this.Controls.Add(this.dmTextBoxHoVaTen);
            this.Controls.Add(this.dmComboBoxNam);
            this.Controls.Add(this.dmComboBoxThang);
            this.Controls.Add(this.dmComboBoxNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dmComboBoxNgay;
        private System.Windows.Forms.ComboBox dmComboBoxThang;
        private System.Windows.Forms.ComboBox dmComboBoxNam;
        private System.Windows.Forms.TextBox dmTextBoxHoVaTen;
        private System.Windows.Forms.TextBox dmTextBoxSoThich;
        private System.Windows.Forms.Button dmButtonXem;
        private System.Windows.Forms.Button dmButtonThoat;
        private System.Windows.Forms.ListBox dmListBoxResult;
    }
}

