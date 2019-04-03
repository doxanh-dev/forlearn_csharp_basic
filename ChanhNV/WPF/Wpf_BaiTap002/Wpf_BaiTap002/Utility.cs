using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_BaiTap002
{
    public static class Utility
    {

        #region Các biến hiển thị thông báo
        public static string mesNote = "Thông báo";
        public static string mesExit = "Bạn chắc chắn muốn thoát";
        public static string mesReset = "Bạn có chắc muốn Reset!";
        public static string mesA = "Bạn chưa nhập Số Báo Danh!";
        #endregion
        #region Hàm kiểm tra giá trị null or empty
        /// <summary>
        /// Hàm kiểm tra giá trị null or empty
        /// </summary>
        /// <param name="strCheck">chuối kiểm tra</param>
        /// <returns></returns>
        public static bool IsNull(string strCheck)
        {
            bool result = true;
            if (string.IsNullOrEmpty(strCheck))
            {
                result = true;
            }
            return result;
        }
        #endregion
        #region Hàm kiểm tra nhấn nút thoát
        /// <summary>
        /// Hàm kiểm tra nhấn nút thoát
        /// </summary>
        public static void CheckExit()
        {
            MessageBoxResult result;

            result = MessageBox.Show(mesExit, mesNote, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown(99);
            }
        }
        #endregion
        #region Hàm hiển thị message yêu cầu nhập Số Báo Danh
        public static void MesReSoBaoDanh()
        {
            MessageBox.Show(mesA, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #endregion
    }
}
