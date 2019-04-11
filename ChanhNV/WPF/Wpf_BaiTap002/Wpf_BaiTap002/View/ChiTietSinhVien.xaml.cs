using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Wpf_BaiTap002.View
{
    /// <summary>
    /// Interaction logic for ChiTietSinhVien.xaml
    /// </summary>
    public partial class ChiTietSinhVien : Window
    {
        public ChiTietSinhVien()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
