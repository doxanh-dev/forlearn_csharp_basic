using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap001
{
    public partial class Form1 : Form
    {
        #region Biến lưu Tên người dùng đăng nhập
        /// <summary>
        /// Biến Tên người dùng đăng nhập
        /// </summary>
        private string tenNguoiDung = "tamga";
        #endregion
        #region Biến lưu Mật Khẩu đăng nhập
        /// <summary>
        /// Biến Mật Khẩu đăng nhập
        /// </summary>
        private string matKhau = "123";
        #endregion
        #region Các biến để hiển thị trong MessageBox
        public string mesSuccess = "Bạn đã đăng nhập thành công";
        public string mesFail = "Bạn vui lòng đăng nhập lại";
        public string mesNote = "Thông báo";
        public string mesExit = "Bạn có muốn thoát";
        public string mesWarning = "Chú ý";
        #endregion
        #region Hàm kiểm tra Thông tin đăng nhập
        /// <summary>
        /// Hàm kiểm tra Thông tin đăng nhập
        /// </summary>
        /// <param name="tenNDung"></param>
        /// <param name="mKhau"></param>
        /// <returns></returns>
        public bool IsLoginSuccess(string tenNDung, string mKhau)
        {
            bool result = true;

            if (this.tenNguoiDung.Equals(tenNDung) && this.matKhau.Equals(mKhau))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        #endregion
        #region Hàm hiển thị Message khi Login
        /// <summary>
        /// Hàm hiển thị Message khi Login
        /// </summary>
        /// <param name="isLogin"></param>
        public void ShowMessBox(bool isLogin)
        {
            if (isLogin)
            {
                MessageBox.Show(mesSuccess);
            }
            else
            {
                MessageBox.Show(mesFail, mesNote);
                this.dmTextBoxTenNguoiDung.Focus();
            }
        }
        #endregion
        #region Hàm kiểm tra DialogResult khi Click vào nút thoát
        /// <summary>
        /// Hàm kiểm tra DialogResult khi Click vào nút thoát
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
                this.dmTextBoxTenNguoiDung.Focus();
            }
        }
        #endregion
        #region InitializeComponent
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Form load
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // setting hiển thị mật khẩu có dạng *
            dmTextBoxMatKhau.PasswordChar = '*';
        }
        #endregion
        #region Sự kiện khi Click vào button Đăng Nhập
        /// <summary>
        /// Sự kiện khi Click vào button Đăng Nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dmButtonDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên người dung và mật khẩu
            bool isLSuccess = (this.IsLoginSuccess(this.dmTextBoxTenNguoiDung.Text, this.dmTextBoxMatKhau.Text));
            if (isLSuccess)
            {
                this.ShowMessBox(true);
            }
            else
            {
                this.ShowMessBox(false);
            }
        }
        #endregion
        #region Sự kiện khhi click vào button Thoát
        private void dmButtonThoat_Click(object sender, EventArgs e)
        {
            DialogResult resultExit;
            resultExit = (MessageBox.Show(mesExit, mesWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            this.CheckExit(resultExit);
        }
        #endregion
    }
}