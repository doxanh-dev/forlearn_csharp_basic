namespace BaiTap006
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHoTenVuaNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKyTuCanTim = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.buttonViTri = new System.Windows.Forms.Button();
            this.textBoxViTriXuatHien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxHoTenVuaNhap
            // 
            resources.ApplyResources(this.textBoxHoTenVuaNhap, "textBoxHoTenVuaNhap");
            this.textBoxHoTenVuaNhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxHoTenVuaNhap.Name = "textBoxHoTenVuaNhap";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxKyTuCanTim
            // 
            resources.ApplyResources(this.textBoxKyTuCanTim, "textBoxKyTuCanTim");
            this.textBoxKyTuCanTim.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxKyTuCanTim.Name = "textBoxKyTuCanTim";
            // 
            // buttonTim
            // 
            resources.ApplyResources(this.buttonTim, "buttonTim");
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // buttonViTri
            // 
            resources.ApplyResources(this.buttonViTri, "buttonViTri");
            this.buttonViTri.Name = "buttonViTri";
            this.buttonViTri.UseVisualStyleBackColor = true;
            this.buttonViTri.Click += new System.EventHandler(this.buttonViTri_Click);
            // 
            // textBoxViTriXuatHien
            // 
            resources.ApplyResources(this.textBoxViTriXuatHien, "textBoxViTriXuatHien");
            this.textBoxViTriXuatHien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxViTriXuatHien.Name = "textBoxViTriXuatHien";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxViTriXuatHien);
            this.Controls.Add(this.buttonViTri);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxKyTuCanTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHoTenVuaNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHoTenVuaNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKyTuCanTim;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonViTri;
        private System.Windows.Forms.TextBox textBoxViTriXuatHien;
    }
}