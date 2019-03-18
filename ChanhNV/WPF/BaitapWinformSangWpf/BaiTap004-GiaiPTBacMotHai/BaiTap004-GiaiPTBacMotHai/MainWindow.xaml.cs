using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BaiTap004_GiaiPTBacMotHai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Khai báo các Class cần sử dụng
        Utility utility = new Utility();
        PTBacMot pTBacMot = new PTBacMot();
        PTBacHai pTBacHai = new PTBacHai();
        #endregion
        #region Các biến hằng số
        public const int intOne = 1;
        public const int intTwo = 2;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Sự kiện radioButtonGiaiPTBacHai_Checked
        private void radioButtonGiaiPTBacHai_Checked(object sender, RoutedEventArgs e)
        {
            this.textBoxNhapC.IsEnabled = true;
        }
        #endregion
        #region Sự kiện radioButtonGiaiPTBacHai_UnChecked
        private void radioButtonGiaiPTBacHai_UnChecked(object sender, RoutedEventArgs e)
        {
            this.textBoxNhapC.IsEnabled = false;
        }
        #endregion
        #region Sự kiện buttonGiai_Click
        private void buttonGiai_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxKetQua.IsEnabled = true;
            if(this.radioButtonGiaiPTBacMot.IsChecked == true)
            {
                this.textBoxKetQua.Text = this.GiaiPhuongTrinhBacMotHoacHai(intOne);
            }
            else if(this.radioButtonGiaiPTBacHai.IsChecked == true)
            {
                this.textBoxKetQua.Text =  this.GiaiPhuongTrinhBacMotHoacHai(intTwo);
            }
        }
        #endregion
        #region Hàm giải phương trình bậc một hoặc bậc hai
        /// <summary>
        /// Giải phương trình bậc một hoặc bậc hai
        /// </summary>
        /// <param name="pt">loại phương trình</param>
        /// <returns></returns>
        public string GiaiPhuongTrinhBacMotHoacHai(int pt)
        {
            string result = string.Empty;
            if (pt == intOne)
            {
                if (this.utility.IsNull(this.textBoxNhapA.Text.ToString()))
                {
                    this.utility.ShowMesRequireA();
                }
                else if (this.utility.IsNull(this.textBoxNhapB.Text.ToString()))
                {
                    this.utility.ShowMesRequireB();
                }
                else
                {
                    result = this.pTBacMot.GiaiPhuongTrinhBacMot(
                                        Convert.ToDouble(this.textBoxNhapA.Text.ToString())
                                        , Convert.ToDouble(this.textBoxNhapB.Text.ToString()));
                }
            }
            else
            {
                if (this.utility.IsNull(this.textBoxNhapA.Text.ToString()))
                {
                    this.utility.ShowMesRequireA();
                }
                else if (this.utility.IsNull(this.textBoxNhapB.Text.ToString()))
                {
                    this.utility.ShowMesRequireB();
                }
                else if (this.utility.IsNull(this.textBoxNhapC.Text.ToString()))
                {
                    this.utility.ShowMesRequireC();
                }
                else
                {
                    result = this.pTBacHai.GiaiPhuongTrinhBacHai(
                                            Convert.ToDouble(this.textBoxNhapA.Text)
                                            , Convert.ToDouble(this.textBoxNhapB.Text)
                                            , Convert.ToDouble(this.textBoxNhapC.Text));
                }
            }
            return result;
        }
        #endregion
        #region Sự kiện buttonXoa_Click
        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;

            result = MessageBox.Show(Utility.mesReset, Utility.mesNote, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                this.ResetGiaiPT();
            }
        }
        #endregion
        #region Sự kiện buttonThoat_Click
        private void buttonThoat_Click(object sender, RoutedEventArgs e)
        {
            this.utility.CheckExit();
        }
        #endregion
        #region Hàm Reset
        private void ResetGiaiPT()
        {
            this.textBoxNhapA.Text = string.Empty;
            this.textBoxNhapB.Text = string.Empty;
            this.textBoxNhapC.Text = string.Empty;
            this.textBoxKetQua.Text = string.Empty;
            this.textBoxNhapC.IsEnabled = false;
            this.textBoxKetQua.IsEnabled = false;
            this.radioButtonGiaiPTBacMot.IsChecked = true;
            this.radioButtonGiaiPTBacHai.IsChecked = false;
        }
        #endregion
        #region Sự kiện textBoxNhapA_PreviewTextInput
        private void textBoxNhapA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
        #region Sự kiện textBoxNhapB_PreviewTextInput
        private void textBoxNhapB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
        #region Sự kiện textBoxNhapC_PreviewTextInput
        private void textBoxNhapC_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
    }
}
