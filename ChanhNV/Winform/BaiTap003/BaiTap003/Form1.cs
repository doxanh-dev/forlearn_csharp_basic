using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap003
{
    public partial class Form1 : Form
    {
        #region Các link website
        private string sWebSSV = "http://vn.saishunkansys.com";
        private string sGoogle = "www.google.com";
        private string sNewzing = "www.news.zing.vn";
        private string sFacebook = "www.facebook.com";
        private string sYoutube = "www.youtube.com";
        #endregion
        #region Biến title của View hiển thị
        private string sTitleView = "Bạn đã chọn website: ";
        #endregion
        #region Các biến hiển thị thông báo
        public string mesFail = "Bạn chưa chọn website!";
        public string mesNote = "Thông báo";
        public string mesExit = "Bạn có muốn thoát";
        public string mesWarning = "Chú ý";
        #endregion
        #region Khởi tạo
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Sự kiện Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitializeListWebsite();
        }
        #endregion
        #region Sự kiện Click button OK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(this.IsSelectWeb(this.listBoxChonSite.Text))
            {
                this.ViewResult();
            }
            else
            {
                this.ShowMessErr();
            }
        }
        #endregion
        #region Sự kiện Click vào link trong richTextBox
        private void richTextBoxHienThi_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
        #endregion
        #region Sự kiện click button Reset
        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.ReSetViewResult();
        }
        #endregion
        #region Sự kiện click button Thoát
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chọn giá trị Yes/No khi thông báo muốn thoát
            DialogResult resultExit;
            resultExit = (MessageBox.Show(mesExit, mesWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            this.CheckExit(resultExit);
        }
        #endregion
        #region Hàm khởi tạo danh sách website
        private void InitializeListWebsite()
        {
            this.listBoxChonSite.Items.Add(sWebSSV);
            this.listBoxChonSite.Items.Add(sGoogle);
            this.listBoxChonSite.Items.Add(sNewzing);
            this.listBoxChonSite.Items.Add(sFacebook);
            this.listBoxChonSite.Items.Add(sYoutube);
        }
        #endregion
        #region Hàm hiển thị website đã chọn
        private void ViewResult()
        {
            this.richTextBoxHienThi.Text = sTitleView;
            this.richTextBoxHienThi.Enabled = true;
            this.richTextBoxHienThi.AppendText(Environment.NewLine + this.listBoxChonSite.Text);
        }
        #endregion
        #region Hàm Reset View
        private void ReSetViewResult()
        {
            this.richTextBoxHienThi.ResetText();
            this.richTextBoxHienThi.Enabled = false;
        }
        #endregion
        #region Hàm kiểm tra khi click button Thoát
        /// <summary>
        /// Hàm kiểm tra khi click button Thoát
        /// </summary>
        /// <param name="dialog"></param>
        public void CheckExit(DialogResult dialog)
        {
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.listBoxChonSite.SelectedIndex = 0;
            }
        }
        #endregion
        #region Hàm kiểm tra chọn website
        /// <summary>
        /// Hàm kiểm tra chọn website
        /// </summary>
        /// <param name="sText"></param>
        /// <returns></returns>
        private bool IsSelectWeb(string sText)
        {
            bool select = false;
            if(!String.IsNullOrEmpty(sText))
            {
                select = true;
            }
            return select;
        }
        #endregion
        #region Hàm hiển thị thông báo lỗi
        public void ShowMessErr()
        {
            MessageBox.Show(mesFail, mesNote, MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            this.listBoxChonSite.SelectedIndex = 0;

        }
        #endregion
    }
}
