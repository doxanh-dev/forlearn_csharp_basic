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

namespace Wpf_BaiTap001_DungCSharp
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

        #region Sự kiện khi viết thêm ký tự mới ở TextBoxWrite
        /// <summary>
        /// Sự kiện khi viết thêm ký tự mới ở TextBoxWrite
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void TextBoxWrite_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.textBoxWrite.Text.Length >= 0)
            {
                this.labelChuyenMauDo.Visibility = Visibility.Visible;
            }
        }
        #endregion
        #region Sự kiện khi xóa bớt ký tự ở TextBoxWrite
        /// <summary>
        /// Sự kiện khi xóa bớt ký tự ở TextBoxWrite
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void TextBoxWrite_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxWrite.Text.ToString()))
            {
                this.labelChuyenMauDo.Visibility = Visibility.Hidden;
            }
        }
        #endregion
        #region Sự kiện khi di chuyển chuột vào label: LabelChuyenMauDo
        /// <summary>
        /// Sự kiện khi di chuyển chuột vào label: LabelChuyenMauDo
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void LabelChuyenMauDo_MouseEnter(object sender, MouseEventArgs e)
        {
            this.labelChuyenMauDo.Foreground = Brushes.Red;
        }
        #endregion
        #region Sự kiện khi di chuyển chuột ra ngoài label: LabelChuyenMauDo
        /// <summary>
        /// Sự kiện khi di chuyển chuột ra ngoài label: LabelChuyenMauDo
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void LabelChuyenMauDo_MouseLeave(object sender, MouseEventArgs e)
        {
            this.labelChuyenMauDo.Foreground = Brushes.Black;
        }
        #endregion
    }
}
