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

namespace CacDieuKhienCoBan
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

        private void buttonXemThongTin_Click(object sender, RoutedEventArgs e)
        {
            String strMessage, strHoTen, strTitle, strNgoaiNgu = "";
            strHoTen = this.textBoxHoDem.Text + " " + this.textBoxTen.Text;
            if (this.radioButtonNam.IsChecked == true)
                strTitle = "Mr.";
            else
                strTitle = "Miss/Mrs.";
            strMessage = "Xin chào: " + strTitle + " " + strHoTen;
            if (this.checkBoxTiengAnh.IsChecked == true)
            {
                strNgoaiNgu = "Tiếng Anh";
            }
            if (this.checkBoxTiengPhap.IsChecked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Tiếng Pháp" : (strNgoaiNgu + " và Tiếng Pháp");
            }
            strMessage += "\n Ngoại ngữ: " + strNgoaiNgu;            if (this.comboBoxQueQuan.SelectedIndex >= 0)//Nếu đã có một mục trong danh sách được chọn
            {
                strMessage += "\n Quê Quán: " + this.comboBoxQueQuan.Text;
            }
            MessageBox.Show(strMessage);
        }

        private void buttonNhapLai_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxHoDem.Text = "";
            this.textBoxTen.Text = "";
            this.radioButtonNam.IsChecked = true;
            this.radioButtonNu.IsChecked = false;
            this.checkBoxTiengAnh.IsChecked = false;
            this.checkBoxTiengPhap.IsChecked = false;
            this.comboBoxQueQuan.SelectedIndex = 0;
        }
    }
}
