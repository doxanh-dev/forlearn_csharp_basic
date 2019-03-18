using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BaiTap003_LienKetWebSite
{
    public class Website
    {
        #region Các biến hiển thị thông báo
        public static string mesWebsite = "Bạn chưa chọn Website!";
        public static string mesNote = "Thông báo";
        public static string mesExit = "Bạn chắc chắn muốn thoát";
        public static string mesReset = "Bạn có chắc muốn Reset!";
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
        #region Hàm hiển thị message yêu cầu chọn website
        public void ShowMesRequireWebsite()
        {
            MessageBox.Show(mesWebsite, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
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
                //this.Close();
                Application.Current.Shutdown(99);
            }
        }
        #endregion
    }
}
