using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace BaiTap003_LienKetWebSite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Các link website
        private string sWebSSV = "http://vn.saishunkansys.com";
        private string sGoogle = "www.google.com";
        private string sNewzing = "www.news.zing.vn";
        private string sFacebook = "www.facebook.com";
        private string sYoutube = "www.youtube.com";
        #endregion
        #region Khai báo lớp Website
        Website website = new Website();
        #endregion
        public MainWindow()
        {
            #region Khởi tạo
            InitializeComponent();
            this.InitializeListWeb();
            #endregion
        }
        #region Sự kiện richTextBoxResult_MouseDoubleClick
        private void richTextBoxResult_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string richText = new TextRange(richTextBoxResult.Document.ContentStart, richTextBoxResult.Document.ContentEnd).Text;
            Process.Start(this.listBoxChonSite.SelectedItem.ToString());
        }
        #endregion
        #region Hàm hiển thị kết quả
        private void ViewResult()
        {
            this.richTextBoxResult.Document.Blocks.Clear();
            this.richTextBoxResult.IsEnabled = true;
            this.labelHienThi.Visibility = Visibility;
            this.richTextBoxResult.Foreground = Brushes.Blue;
            this.richTextBoxResult.AppendText(Environment.NewLine + this.listBoxChonSite.SelectedItem.ToString());
        }
        #endregion
        #region Hàm khởi tạo Danh sách website
        private void InitializeListWeb()
        {
            this.listBoxChonSite.Items.Add(sWebSSV);
            this.listBoxChonSite.Items.Add(sGoogle);
            this.listBoxChonSite.Items.Add(sNewzing);
            this.listBoxChonSite.Items.Add(sFacebook);
            this.listBoxChonSite.Items.Add(sYoutube);
            this.richTextBoxResult.IsEnabled = false;
        }
        #endregion
        #region Hàm Kiểm tra Reset
        private void CheckReset()
        {
            MessageBoxResult result;

            result = MessageBox.Show(Website.mesReset, Website.mesNote, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                this.richTextBoxResult.Document.Blocks.Clear();
                this.richTextBoxResult.IsEnabled = false;
            }
        }
        #endregion
        #region Sự kiện buttonOk_Click
        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            if (this.listBoxChonSite.SelectedIndex >= 0)
            {
                this.ViewResult();
            }
            else
            {
                this.website.ShowMesRequireWebsite();
            }
        }
        #endregion
        #region Sự kiện buttonReset_Click
        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            this.CheckReset();
        }
        #endregion
        #region Sự kiện buttonThoat_Click
        private void buttonThoat_Click(object sender, RoutedEventArgs e)
        {
            this.website.CheckExit();
        }
        #endregion
    }
}
