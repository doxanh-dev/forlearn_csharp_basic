using System.Text;
using System.Windows;

namespace SuKienCoDinhTuyen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Dùng một StringBuilder để lưu trữ thông tin kết quả
        private StringBuilder eventstr = new StringBuilder();

        public MainWindow()
        {
            InitializeComponent();
        }
        #region Đơn vị xử lý sự kiện Click của Button
        private void HandleClick(object sender, RoutedEventArgs args)
        {
            // Lấy thông tin về đối tượng xử lý sự kiện Click
            FrameworkElement fe = (FrameworkElement)sender;
            eventstr.Append("Sự kiện được xử lý bởi đối tượng có tên: ");
            eventstr.Append(fe.Name);
            eventstr.Append("\n");
            
            // Lấy thông tin về nguồn phát ra sự kiện CLick:
            FrameworkElement fe2 = (FrameworkElement)args.Source;
            eventstr.Append("Sự kiện xuất phát từ nguồn đối tượng kiểu:");
            //+ Loại thành phần UI;
            eventstr.Append(args.Source.GetType().ToString());
            //+ Định danh;
            eventstr.Append(" với tên gọi: ");
            eventstr.Append(fe2.Name);
            eventstr.Append("\n");
            
            // Lấy thông tin về phương thức định tuyến
            eventstr.Append("Sự kiện sử dụng phương thức định tuyến: ");
            eventstr.Append(args.RoutedEvent.RoutingStrategy);
            eventstr.Append("\n");
            
            // Đưa thông tin ra màn hình
            this.results.Text = eventstr.ToString();
        }
        #endregion
    }
}