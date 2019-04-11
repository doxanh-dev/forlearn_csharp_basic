using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Wpf_BaiTap003.Model;
using Wpf_BaiTap003.ViewModel;

namespace Wpf_BaiTap003.View
{
    /// <summary>
    /// Interaction logic for QuanLyNhanVien.xaml
    /// </summary>
    public partial class QuanLyNhanVien : Window
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            MainViewModel viewModel = new MainViewModel();
            viewModel.LoadDanhSachNhanVien();
            DataContext = viewModel;

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
