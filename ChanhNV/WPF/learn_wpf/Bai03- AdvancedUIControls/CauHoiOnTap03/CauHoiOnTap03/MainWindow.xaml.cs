using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CauHoiOnTap03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Đặt các cờ xác định lựa chọn tương ứng với các loại đồ uống
        bool selectedOrange;
        bool selectedKiwi;
        bool selectedMango;
        bool selectedMilk;
        bool selectedEspesso;
        #endregion
        public MainWindow()
        {
            InitializeComponent();

            #region Khởi tạo biến đánh dấu chọn
            selectedOrange = false;
            selectedKiwi = false;
            selectedMango = false;
            selectedMilk = false;
            selectedEspesso = false;
            #endregion
        }

        #region Hàm xử lý sự kiện bỏ chọn (Unchecked) của mỗi checkbox
        //Hàm xử lý sự kiện bỏ chọn (Unchecked) của mỗi checkbox
        //Lưu ý: Ở đây ta chỉ sử dụng một hàm duy nhất xử lý sự kiện này cho mọi checkbox
        //Để phân biệt checkbox nào phát động sự kiện, ta dựa vào tham số sender và so sánh nó với các checkbox
        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(chkCafe)) selectedEspesso = false;
            if (sender.Equals(chkKiwiJuice)) selectedKiwi = false;
            if (sender.Equals(chkMangoJuice)) selectedMango = false;
            if (sender.Equals(chkMilk)) selectedMilk = false;
            if (sender.Equals(chkOrangeJuice)) selectedOrange = false;
        }
        #endregion
        #region Hàm xử lý sự kiện bỏ chọn (checked) của mỗi checkbox
        // Hàm xử lý sự kiện bỏ chọn (checked) của mỗi checkbox
        private void HandleChecked(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(chkCafe)) selectedEspesso = true;
            if (sender.Equals(chkKiwiJuice)) selectedKiwi = true;
            if (sender.Equals(chkMangoJuice)) selectedMango = true;
            if (sender.Equals(chkMilk)) selectedMilk = true;
            if (sender.Equals(chkOrangeJuice)) selectedOrange = true;
        }
        #endregion
        #region Hàm xử lý sự kiện hiển thị các đồ uống được chọn
        /// <summary>
        /// Hàm xử lý sự kiện hiển thị các đồ uống được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoiDoUong_Click(object sender, RoutedEventArgs e)
        {
            String choices = "Ban đã chọn: ";
            bool selected = false;
            // chọn Nước cam
            if (selectedOrange)
            {
                choices += "Nước cam; ";
                selected = true;
            }
            // chọn Nước kiwi
            if (selectedKiwi)
            {
                choices += "Nước kiwi; ";
                selected = true;
            }
            // chọn Sữa tươi
            if (selectedMilk)
            {
                choices += "Sữa tươi; ";
                selected = true;
            }
            // chọn Nước soài ép
            if (selectedMango)
            {
                choices += "Nước soài ép; ";
                selected = true;
            }
            // chọn Cafe
            if (selectedEspesso)
            {
                choices += "Cafe Espresso;";
                selected = true;
            }
            // không chọn đồ uống
            if (!selected) choices = "Vui lòng chọn đồ uống !";
            // hiển thị menu
            MessageBox.Show(choices);
        }
        #endregion

    }
}
