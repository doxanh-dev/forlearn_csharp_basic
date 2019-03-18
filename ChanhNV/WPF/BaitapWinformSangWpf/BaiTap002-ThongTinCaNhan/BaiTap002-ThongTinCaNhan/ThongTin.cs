using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BaiTap002_ThongTinCaNhan
{
    public class ThongTin
    {
        #region Các Biến hằng số
        public const int intZero = 0;
        public const int intFour = 4;
        public const int intOneHundred = 100;
        public const int intFourHundred = 400;
        #endregion
        #region Các biến dùng khác
        public int sYear = 1980;
        public int eYear = 2300;
        #endregion
        #region Các biến hiển thị thông báo
        public string mesFail = "Bạn vui lòng nhập đủ thông tin!";
        private static string mesName = "Bạn chưa nhập họ tên!";
        private static string mesNote = "Thông báo";
        private static string mesExit = "Bạn chắc chắn muốn thoát";
        private static string mesBirthDay = "Bạn chưa nhập ngày tháng năm sinh";
        private static string mesFav = "Bạn chưa nhập sở thích";
        #endregion
        #region Hàm kiểm tra năm nhuận
        /// <summary>
        /// Hàm kiểm tra năm nhuận
        /// </summary>
        /// <param name="year">năm</param>
        /// <returns></returns>
        public bool IsNamNhuan(int year)
        {
            bool result = false;
            if (((year % intOneHundred == intZero) && year % intFourHundred == intZero)
                || (year % intFour == intZero))
            {
                result = true;
            }

            return result;
        }
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
            if(!String.IsNullOrEmpty(strCheck))
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
                //this.Close();
                Application.Current.Shutdown(99);
            }
        }
        #endregion
        #region Hàm hiển thị message yêu cầu nhập họ tên
        public void ShowMesName()
        {
            MessageBox.Show(mesName, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #endregion
        #region Hàm hiển thị message yêu cầu nhập ngày tháng năm sinh
        public void ShowMesBirthday()
        {
            MessageBox.Show(mesBirthDay, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #endregion
        #region Hàm hiển thị message yêu cầu nhập sở thích
        public void ShowMesFav()
        {
            MessageBox.Show(mesFav, mesNote, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #endregion
    }
}
