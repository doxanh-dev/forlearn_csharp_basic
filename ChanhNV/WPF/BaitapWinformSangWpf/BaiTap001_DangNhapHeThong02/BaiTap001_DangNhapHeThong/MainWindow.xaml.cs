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

namespace BaiTap001_DangNhapHeThong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   // Khai báo lớp hệ thống
        HeThong heThong = new HeThong();
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Sự kiện Click của buttonDangNhap
        private void buttonDangNhap_Click(object sender, RoutedEventArgs e)
        {
            //heThong.CheckLogin(this.textBoxTenNguoiDung.Text.ToString(), this.passwordBoxMatKhau.Password.ToString());
            Window1 w = new Window1();
            
            w.Show();
            string a = w.labelHello.Content.ToString();
            this.Hide();
        }
        #endregion
        #region Sự kiện Click của buttonThoat
        private void buttonThoat_Click(object sender, RoutedEventArgs e)
        {
            heThong.CheckExit();
        }
        #endregion
    }
}
