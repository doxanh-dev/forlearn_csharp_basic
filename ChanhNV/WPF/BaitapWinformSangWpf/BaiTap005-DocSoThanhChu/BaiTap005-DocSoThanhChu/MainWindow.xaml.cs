using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BaiTap005_DocSoThanhChu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Khai báo các Class
        Utility utility = new Utility();
        DocSoThanhChu docSoThanhChu = new DocSoThanhChu();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Hàm Reset Đọc số thành chữ
        private void ResetDocSoThanhChu()
        {
            this.textBoxKetQua.IsEnabled = false;
            this.textBoxKetQua.Text = string.Empty;
            this.textBoxNhapDaySo.Text = string.Empty;
        }
        #endregion
        #region Sự kiện buttonXoa_Click
        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;

            result = MessageBox.Show(Utility.mesReset, Utility.mesNote, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                this.ResetDocSoThanhChu();
            }
        }
        #endregion
        #region Sự kiện textBoxNhapDaySo_PreviewTextInput
        private void textBoxNhapDaySo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
        #region Sự kiện buttonThoat_Click
        private void buttonThoat_Click(object sender, RoutedEventArgs e)
        {
            this.utility.CheckExit();
        }
        #endregion
        #region Sự kiện buttonThucHien_Click
        private void buttonThucHien_Click(object sender, RoutedEventArgs e)
        {
            if (!this.utility.IsNull(this.textBoxNhapDaySo.Text))
            {
                this.textBoxKetQua.IsEnabled = true;
                this.textBoxKetQua.Foreground = Brushes.White;
                this.textBoxKetQua.Text = docSoThanhChu.DocChuSo(this.textBoxNhapDaySo.Text);
            }
            else
            {
                this.utility.ShowMesRequire();
            }
        }
        #endregion
    }
}
