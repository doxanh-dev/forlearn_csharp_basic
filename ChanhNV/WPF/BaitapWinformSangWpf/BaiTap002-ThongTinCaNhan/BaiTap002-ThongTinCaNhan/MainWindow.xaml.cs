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

namespace BaiTap002_ThongTinCaNhan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Khai báo lớp Thông Tin
        ThongTin thongTin = new ThongTin();
        #endregion
        #region Các Biến hằng số
        public const int intZero = 0;
        public const int intOne = 1;
        public const int intTwo = 2;
        public const int intThree = 3;
        public const int intFour = 4;
        public const int intFive = 5;
        public const int intSix = 6;
        public const int intSeven = 7;
        public const int intEight = 8;
        public const int intNine = 9;
        public const int intTen = 10;
        public const int intEleven = 11;
        public const int intTwelve = 12;
        public const int intTwenEight = 28;
        public const int intTwenNine = 29;
        public const int intThirty = 30;
        public const int intThirOne = 31;
        public const int intOneHundred = 100;
        public const int intFourHundred = 400;
        #endregion
        #region Các biến dùng khác
        public int sYear = 1980;
        public int eYear = 2300;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            #region Khởi tạo giá trị ban đầu
            this.InitializeDate(intThirOne);
            this.InitializeMonth(intTwelve);
            this.InitializeYear(2030);
            #endregion
        }

        #region Hàm khởi tạo giá trị Năm cho comboBox
        private void InitializeYear(int numYear)
        {
            for (int y = sYear; y <= numYear; y++)
            {
                this.comboBoxNam.Items.Add(y);
            }
        }
        #endregion
        #region Hàm khởi tạo giá trị ngày trong tháng
        private void InitializeDate(int numDay)
        {
            for (int d = intOne; d <= numDay; d++)
            {
                this.comboBoxNgay.Items.Add(d);
            }
        }
        #endregion
        #region Hàm khởi tạo giá trị tháng
        private void InitializeMonth(int numMonth)
        {
            for (int m = intOne; m <= numMonth; m++)
            {
                this.comboBoxThang.Items.Add(m);
            }
        }
        #endregion
        #region Hàm kiểm tra khi chọn giá trị tháng
        private void SelectedThang()
        {
            this.comboBoxNgay.Items.Clear();
            if(!String.IsNullOrEmpty(this.comboBoxThang.Text.ToString()))
            {

                switch (int.Parse(this.comboBoxThang.Text.ToString()))
                {
                    case intTwo:
                        if (!String.IsNullOrEmpty(this.comboBoxNam.Text))
                        {
                            if (this.thongTin.IsNamNhuan(int.Parse(this.comboBoxNam.Text)))
                            {
                                this.InitializeDate(intTwenNine);
                            }
                            else
                            {
                                this.InitializeDate(intTwenEight);
                            }
                        }
                        else
                        {
                            this.comboBoxNam.Text = sYear.ToString();

                            if (this.thongTin.IsNamNhuan(int.Parse(this.comboBoxNam.Text)))
                            {
                                this.InitializeDate(intTwenNine);
                            }
                            else
                            {
                                this.InitializeDate(intTwenEight);
                            }
                        }
                        break;
                    case intOne:
                    case intThree:
                    case intFive:
                    case intSeven:
                    case intEight:
                    case intTen:
                    case intTwelve:
                        this.InitializeDate(intThirOne);
                        break;
                    default:
                        this.InitializeDate(intThirty);
                        break;
                }
            }
            else
            {
                this.InitializeDate(intThirOne);
            }
        }

        #endregion
        #region Sự kiện comboBoxNgay_PreviewMouseLeftButtonDown
        private void comboBoxNgay_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.SelectedThang();
        }
        #endregion
        #region Sự kiện buttonXem_Click
        private void buttonXem_Click(object sender, RoutedEventArgs e)
        {
            if(thongTin.IsNull(this.textBoxHoVaTen.Text.ToString()))
            {
                thongTin.ShowMesName();
            }
            else if(thongTin.IsNull(this.comboBoxNgay.Text.ToString())
                    || thongTin.IsNull(this.comboBoxThang.Text.ToString())
                    || thongTin.IsNull(this.comboBoxNam.Text.ToString()))
            {
                thongTin.ShowMesBirthday();
            }
            else if(thongTin.IsNull(this.textBoxSoThich.Text.ToString()))
            {
                thongTin.ShowMesFav();
            }
            else
            {
                this.ShowResult();
            }
        }
        #endregion
        #region Sự kiện buttonThoat_Click
        private void buttonThoat_Click(object sender, RoutedEventArgs e)
        {
            thongTin.CheckExit();
        }
        #endregion
        #region Hàm hiển thị kết quả
        private void ShowResult()
        {
            this.listBoxResult.Items.Add("Họ tên: " + this.textBoxHoVaTen.Text);
            this.listBoxResult.Items.Add("Năm sinh: "
            + this.comboBoxNgay.Text.ToString() + '/'
            + this.comboBoxThang.Text.ToString() + '/'
            + this.comboBoxNam.Text.ToString());
            this.listBoxResult.Items.Add("Sở thích: " + this.textBoxSoThich.Text.ToString());
        }
        #endregion
    }
}
