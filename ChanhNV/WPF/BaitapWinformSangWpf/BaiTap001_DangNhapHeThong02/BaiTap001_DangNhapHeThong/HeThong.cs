using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BaiTap001_DangNhapHeThong
{
    public class HeThong
    {
        #region Các biến thông tin đăng nhập
        private static string user = "123";
        private static string password = "123";
        #endregion
        #region Các biến hiển thị thông báo
        private static string mesSuccess= "Đăng nhập thành công!";
        private static string mesNote = "Thông báo";
        private static string mesExit = "Bạn chắc chắn muốn thoát";
        private static string mesWarning = "Bạn đã nhập sai tài khoản hoặc mật khẩu";
        private static string mesReInfo = "Bạn phải nhập đủ thông tin";
        #endregion
        #region Hàm kiểm tra nhấn nút thoát
        /// <summary>
        /// Hàm kiểm tra nhấn nút thoát
        /// </summary>
        public void CheckExit()
        {
            MessageBoxResult result;

            result = MessageBox.Show(mesExit, mesNote, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                //this.Close();
                Application.Current.Shutdown(99);
            }
        }
        #endregion
        #region Hàm Kiểm tra đăng nhập
        /// <summary>
        /// Hàm Kiểm tra đăng nhập
        /// </summary>
        /// <param name="tenNguoiDung">tên người dùng</param>
        /// <param name="matKhau">mật khẩu</param>
        public void CheckLogin(string tenNguoiDung, string matKhau)
        {
            if (tenNguoiDung == user
                && matKhau == password)
            {
                MessageBox.Show(mesSuccess, mesNote, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (tenNguoiDung.Length == 0
                    || matKhau.Length == 0)
            {
                MessageBox.Show(mesReInfo, mesNote, MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else
            {
                MessageBox.Show(mesWarning, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        #endregion
    }
}
