using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap002
{
    public partial class Form1 : Form
    {
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
        public string mesFail = "Bạn vui lòng nhập đủ thông tin!";
        public string mesNote = "Thông báo";
        public string mesExit = "Bạn có muốn thoát";
        public string mesWarning = "Chú ý";
        #endregion
        #region Khởi tạo
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Sự kiện Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitializeDate(intThirOne);
            this.InitializeMonth(intTwelve);
            this.InitializeYear(2030);
        }
        #endregion
        #region Hàm kiểm tra năm nhuận
        private bool IsNamNhuan(int year)
        {
            bool result = false;
            if (((year % intOneHundred == intZero) && year % intFourHundred == intZero)
                || (year % intFour == intZero))
            {
                result = true;
            }

            return result;
        }
        #endregion
        #region Hàm khởi tạo giá trị Năm cho comboBox
        private void InitializeYear(int numYear)
        {
            for (int y = sYear; y <= numYear; y++)
            {
                this.dmComboBoxNam.Items.Add(y);
            }
        }
        #endregion
        #region Hàm khởi tạo giá trị ngày trong tháng
        private void InitializeDate(int numDay)
        {
            for (int d = intOne; d <= numDay; d++)
            {
                this.dmComboBoxNgay.Items.Add(d);
            }
        }
        #endregion
        #region Hàm khởi tạo giá trị tháng
        private void InitializeMonth(int numMonth)
        {
            for (int m = intOne; m <= numMonth; m++)
            {
                this.dmComboBoxThang.Items.Add(m);
            }
        }
        #endregion
        #region Hàm kiểm tra đã điền đủ thông tin hay chưa
        private bool isFillInfo()
        {
            bool result = false;
            if(!String.IsNullOrEmpty(this.dmTextBoxHoVaTen.Text) 
                && !String.IsNullOrEmpty(this.dmComboBoxNgay.Text)
                && !String.IsNullOrEmpty(this.dmComboBoxThang.Text)
                && !String.IsNullOrEmpty(this.dmComboBoxNam.Text)
                && !String.IsNullOrEmpty(this.dmTextBoxSoThich.Text)
                )
            {
                result = true;
            }
            return result;
        }
        #endregion
        #region Hàm hiển thị kết quả
        /// <summary>
        /// Hiển thị kết quả
        /// </summary>
        private void ShowResult()
        {
            this.dmListBoxResult.Items.Add(this.dmTextBoxHoVaTen.Text);

            this.dmListBoxResult.Items.Add(
                this.dmComboBoxNgay.Text + '/'
                + this.dmComboBoxThang.Text + '/'
                + this.dmComboBoxNam.Text);

            this.dmListBoxResult.Items.Add(this.dmTextBoxSoThich.Text);

        }
        #endregion
        #region Hàm kiểm tra DialogResult khi Click vào nút thoát
        /// <summary>
        /// Hàm kiểm tra DialogResult khi Click vào nút thoát
        /// </summary>
        /// <param name="dialog"></param>
        public void CheckExit(DialogResult dialog)
        {
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.dmComboBoxNam.Focus();
            }
        }
        #endregion
        #region Hàm hiển thị thông báo lỗi
        public void ShowMessErr()
        {
            MessageBox.Show(mesFail, mesNote);
            this.dmTextBoxHoVaTen.Focus();

        }
        #endregion
        #region Hàm kiểm tra khi chọn giá trị tháng
        private void SelectedThang()
        {
            this.dmComboBoxNgay.Items.Clear();
            switch (int.Parse(this.dmComboBoxThang.Text))
            {
                case intTwo:
                    if (!String.IsNullOrEmpty(this.dmComboBoxNam.Text))
                    {
                        if (this.IsNamNhuan(int.Parse(this.dmComboBoxNam.Text)))
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
                        this.dmComboBoxNam.Text = sYear.ToString();

                        if (this.IsNamNhuan(int.Parse(this.dmComboBoxNam.Text)))
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
        #endregion
        #region Sự kiện chọn button Xem
        private void dmButtonXem_Click(object sender, EventArgs e)
        {
            //Kiểm tra đăng nhập hay chưa
            if(this.isFillInfo())
            {
                // Hiển thị kết quả
                this.ShowResult();
            }
            else
            {
                // Hiển thị thông báo lỗi
                this.ShowMessErr();
            }
            
        }
        #endregion
        #region Sự kiện chọn giá trị Tháng
        private void dmComboBoxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm ta sự kiện chọn giá trị tháng
            this.SelectedThang();
        }
        #endregion
        #region Sự kiện button Thoát
        private void dmButtonThoat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chọn giá trị Yes/No khi thông báo muốn thoát
            DialogResult resultExit;
            resultExit = (MessageBox.Show(mesExit, mesWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            this.CheckExit(resultExit);
        }
        #endregion
    }
}
