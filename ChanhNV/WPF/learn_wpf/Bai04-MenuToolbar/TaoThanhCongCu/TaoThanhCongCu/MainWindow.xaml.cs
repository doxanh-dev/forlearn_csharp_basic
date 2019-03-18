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

namespace TaoThanhCongCu
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
        #region Hàm xử lý sự kiện khi buttonTangCoChu được nhấn
        private void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (this.textBoxThayDoi.FontSize < 18)
            {
                this.textBoxThayDoi.FontSize += 2;//Tăng cỡ font chữ của textBox1 lên 2 đơn vị
            }
        }
        #endregion

        #region Hàm xử lý sự kiện khi buttonGiamCoChu được nhấn
        private void DecreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (this.textBoxThayDoi.FontSize > 10)
            {
                this.textBoxThayDoi.FontSize -= 2;//Giảm cỡ font chữ của textBox1 lên 2 đơn vị
            }
        }
        #endregion

        #region Thiết lập thuộc tính chữ đậm
        private void Bold_Checked(object sender, RoutedEventArgs e)
        {
            //Thiết lập thuộc tính chữ đậm cho textBoxThayDoi
            this.textBoxThayDoi.FontWeight = FontWeights.Bold;
        }
        #endregion
        #region Thiết lập thuộc tính chữ thường
        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            //Thiết lập thuộc tính chữ thường cho textBoxThayDoi
            this.textBoxThayDoi.FontWeight = FontWeights.Normal;
        }
        #endregion
        #region Thiết lập thuộc tính chữ nghiêng
        private void Italic_Checked(object sender, RoutedEventArgs e)
        {
            //Thiết lập thuộc tính chữ nghiêng cho textBoxThayDoi
            this.textBoxThayDoi.FontStyle = FontStyles.Italic;
        }
        #endregion
        #region
        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            //Thiết lập thuộc tính chữ thẳng đứng cho textBoxThayDoi
            this.textBoxThayDoi.FontStyle = FontStyles.Normal;
        }
        #endregion
    }
}
