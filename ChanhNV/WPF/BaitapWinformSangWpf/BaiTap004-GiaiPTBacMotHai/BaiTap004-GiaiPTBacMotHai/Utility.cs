using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BaiTap004_GiaiPTBacMotHai
{
    public class Utility
    {
        #region Các biến hiển thị thông báo
        public static string mesNote = "Thông báo";
        public static string mesExit = "Bạn chắc chắn muốn thoát";
        public static string mesReset = "Bạn có chắc muốn Reset!";
        public static string mesA = "Bạn chưa nhập hệ số A!";
        public static string mesB = "Bạn chưa nhập hệ số B!";
        public static string mesC = "Bạn chưa nhập hệ số C!";
        #endregion
        #region Hàm kiểm tra giá trị null or empty
        /// <summary>
        /// Hàm kiểm tra giá trị null or empty
        /// </summary>
        /// <param name="strCheck">chuối kiểm tra</param>
        /// <returns></returns>
        public bool IsNull(string strCheck)
        {
            bool result = true;
            if (!String.IsNullOrEmpty(strCheck))
            {
                result = false;
            }
            return result;
        }
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
                Application.Current.Shutdown(99);
            }
        }
        #endregion
        #region Hàm hiển thị message yêu cầu nhập hệ số A
        public void ShowMesRequireA()
        {
            MessageBox.Show(mesA, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #endregion
        #region Hàm hiển thị message yêu cầu nhập hệ số B
        public void ShowMesRequireB()
        {
            MessageBox.Show(mesB, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #endregion
        #region Hàm hiển thị message yêu cầu nhập hệ số C
        public void ShowMesRequireC()
        {
            MessageBox.Show(mesC, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #endregion
        
    }
}
