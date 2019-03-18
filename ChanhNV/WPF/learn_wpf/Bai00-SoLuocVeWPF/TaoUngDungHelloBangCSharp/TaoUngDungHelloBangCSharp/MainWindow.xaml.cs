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

namespace TaoUngDungHelloBangCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // khai báo 1 button
        Button buttonHello;
        public MainWindow()
        {
            InitializeComponent();
            // tạo mới 1 button
            buttonHello = new Button();
            // xác định thuộc tính cho button
            buttonHello.Content = "Hello Wpf";
            buttonHello.LayoutTransform = new ScaleTransform(3,3);
            buttonHello.Margin = new System.Windows.Thickness(10);
            // thêm phương thức xử lý sự kiện Click cho button
            buttonHello.Click += new RoutedEventHandler(buttonHello_Click);
            // đưa buttonHello vào window
            this.Content = buttonHello;
        }

        private void buttonHello_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            // xử lý buttonHello khi người dùng click
            buttonHello.Content = "I'm from Hanoi, Viet Nam";
        }
    }
}
