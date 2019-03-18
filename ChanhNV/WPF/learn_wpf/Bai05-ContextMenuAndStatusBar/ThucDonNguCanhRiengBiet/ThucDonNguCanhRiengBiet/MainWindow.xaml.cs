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

namespace ThucDonNguCanhRiengBiet
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

        private void ChuDam_Checked1(object sender, RoutedEventArgs e)
        {
            cmButton1.FontWeight = FontWeights.Bold;
        }

        private void ChuDam_Unchecked1(object sender, RoutedEventArgs e)
        {
            cmButton1.FontWeight = FontWeights.Normal;
        }

        private void Message1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn thực đơn nút bấm 1");
        }

        private void ChuDam_Checked2(object sender, RoutedEventArgs e)
        {
            cmButton2.FontWeight = FontWeights.Bold;
        }

        private void ChuDam_Unchecked2(object sender, RoutedEventArgs e)
        {
            cmButton2.FontWeight = FontWeights.Normal;
        }

        private void Message2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn thực đơn nút bấm 2");
        }
    }
}
