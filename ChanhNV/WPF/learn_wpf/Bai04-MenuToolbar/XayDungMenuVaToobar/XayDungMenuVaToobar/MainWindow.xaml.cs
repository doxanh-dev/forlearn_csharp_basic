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

namespace XayDungMenuVaToobar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Hàm tạo kiểu chữ in đậm
        private void Bold_Checked(object sender, RoutedEventArgs e)
        {
            this.textBoxHienThi.FontWeight = FontWeights.Bold;
            this.checkBoxChuDam.IsChecked = true;
            Menu21.IsChecked = true;
        }
        #endregion
        #region Hàm bỏ kiểu chữ in đậm
        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBoxHienThi.FontWeight = FontWeights.Normal;
            this.checkBoxChuDam.IsChecked = false;
            Menu21.IsChecked = false;
        }
        #endregion
        #region Hàm tạo kiểu chữ nghiêng
        private void Italic_Checked(object sender, RoutedEventArgs e)
        {
            this.textBoxHienThi.FontStyle = FontStyles.Italic;
            this.checkBoxChuNghieng.IsChecked = true;
            Menu22.IsChecked = true;
        }
        #endregion
        #region Hàm bỏ kiểu chữ nghiêng
        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBoxHienThi.FontStyle = FontStyles.Normal;
            this.checkBoxChuNghieng.IsChecked = false;
            Menu22.IsChecked = false;
        }
        #endregion
        #region Hàm giảm cỡ chữ
        private void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (this.textBoxHienThi.FontSize < 18)
            {
                this.textBoxHienThi.FontSize += 2;
            }
        }
        #endregion
        #region Hàm Tăng cỡ chữ
        private void DecreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (this.textBoxHienThi.FontSize > 10)
            {
                this.textBoxHienThi.FontSize -= 2;
            }
        }
        #endregion


    }
}
