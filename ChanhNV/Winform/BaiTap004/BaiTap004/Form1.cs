using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap004
{
    public partial class Form1 : Form
    {
        #region Các biến lưu khi hiển thị kết quả
        public string strPtVoNghiem = "Phương trình vô nghiệm";
        public string strPtVoSoNghiem = "Phương trình vô số nghiệm";
        public string strPtCoNghiem = "Phương trình có nghiệm: ";
        public string strPtCoMotNghiem = "Phương trình có 1 nghiệm: ";
        public string strPtCoHaiNghiem = "Phương trình có 2 nghiệm: ";
        public string strNghiemX = "x";
        public string strNghiemX1 = "x1";
        public string strNghiemX2 = "x2";
        public string strDauBang = "=";
        public string strDauCach = " ";
        public string strDauPhay = ",";
        #endregion
        #region Các biến hằng số
        public const int intOne = 1;
        public const int intTwo = 2;
        public const int intFour= 4;
        #endregion
        #region Các biến hiển thị thông báo
        public string mesFail = "Bạn phải điền đủ hệ số!";
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
        #region Sự kiện Click button Giai
        private void buttonGiai_Click(object sender, EventArgs e)
        {
            if(this.IsFill(this.textBoxNhapA.Text)
                && this.IsFill(this.textBoxNhapB.Text))
            {
                if (radioButtonGiaiPTBacMot.Checked == true)
                {
                    this.GiaiPhuongTrinhBacMotHoacHai(intOne);
                }
                else
                {
                    if(this.IsFill(this.textBoxNhapC.Text))
                    {
                        this.GiaiPhuongTrinhBacMotHoacHai(intTwo);
                    }
                    else
                    {
                        this.ShowMessErr();
                    }
                    
                }
                
            }
            else
            {
                this.ShowMessErr();
            }
        }
        #endregion
        #region Sự kiện click radiobutton GiaiPTBacMot
        private void radioButtonGiaiPTBacMot_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxNhapC.Enabled = false;
            this.textBoxKetQua.Enabled = false;
            this.ResetTextBox();
        }
        #endregion
        #region Sự kiện click radiobutton GiaiPTBacHai
        private void radioButtonGiaiPTBacHai_CheckedChanged(object sender, EventArgs e)
        {

            this.textBoxNhapC.Enabled = true;
            this.textBoxKetQua.Enabled = false;
            this.ResetTextBox();
        }
        #endregion
        #region Sự kiện khi nhập hệ số A
        private void textBoxNhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.CheckAcceptNumber(sender, e);
        }
        #endregion
        #region Sự kiện khi nhập hệ số B
        private void textBoxNhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.CheckAcceptNumber(sender, e);
        }
        #endregion
        #region Sự kiện khi nhập hệ số C
        private void textBoxNhapC_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.CheckAcceptNumber(sender, e);
        }
        #endregion
        #region Sự kiện Click button Thoát
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chọn giá trị Yes/No khi thông báo muốn thoát
            DialogResult resultExit;
            resultExit = (MessageBox.Show(mesExit, mesWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            this.CheckExit(resultExit);
        }
        #endregion
        #region Hàm Reset TextBox
        private void ResetTextBox()
        {
            this.textBoxNhapA.ResetText();
            this.textBoxNhapB.ResetText();
            this.textBoxNhapC.ResetText();
            this.textBoxKetQua.ResetText();
        }
        #endregion
        #region Hàm giải phương trình bậc một
        /// <summary>
        /// Giải phương trình bậc một
        /// </summary>
        /// <param name="heSoA"></param>
        /// <param name="heSoB"></param>
        public void GiaiPhuongTrinhBacMot(double heSoA, double heSoB)
        {
            // Tắt vô hiệu hóa textbox hiển thị
            this.textBoxKetQua.Enabled = true;
            if (heSoA == 0)
            {
                if(heSoB == 0)
                {
                     this.textBoxKetQua.Text =  this.strPtVoSoNghiem;
                }
                else
                {
                    this.textBoxKetQua.Text =  this.strPtVoNghiem;
                }
            }
            else
            {
                this.textBoxKetQua.Text = strPtCoNghiem + strNghiemX
                                        + strDauBang + strDauCach + ((-heSoB) / heSoA).ToString();
            }
        }
        #endregion
        #region Hàm giải phương trình bậc Hai
        /// <summary>
        /// Hàm giải phương trình bậc Hai
        /// </summary>
        /// <param name="heSoA"></param>
        /// <param name="heSoB"></param>
        /// <param name="heSoC"></param>
        public void GiaiPhuongTrinhBacHai(double heSoA, double heSoB, double heSoC)
        {
            // Tắt vô hiệu hóa textbox hiển thị
            this.textBoxKetQua.Enabled = true;
            // Khai báo biến delta
            double delta;
            // Trường hợp hệ số a = 0
            if (heSoA == 0)
            {
                if(heSoB == 0)
                {
                    if(heSoC == 0)
                    {
                        this.textBoxKetQua.Text = strPtVoSoNghiem;
                    }
                    else
                    {
                        this.textBoxKetQua.Text = strPtVoNghiem;
                    }
                }
                else
                {
                    this.textBoxKetQua.Text = strPtCoNghiem + strNghiemX
                                            + strDauBang + strDauCach + ((-heSoC) / heSoB).ToString();
                }
            }
            else
            {
                // Trường hợp hệ số a khác 0
                delta = Math.Pow(heSoB, intTwo) - (intFour * heSoA * heSoC);
                if(delta < 0)
                {
                    this.textBoxKetQua.Text = strPtVoNghiem;
                }
                else
                {
                    if(delta == 0)
                    {
                        this.textBoxKetQua.Text = strPtCoMotNghiem + strNghiemX
                                                + strDauBang + strDauCach + ((-heSoB) / (intTwo * heSoA));
                    }
                    else
                    {
                        this.textBoxKetQua.Text = strPtCoHaiNghiem
                                                + strNghiemX1 + strDauBang + strDauCach + ((-heSoB) + Math.Sqrt(delta)) / (intTwo * heSoA)
                                                + strDauPhay + strDauCach
                                                + strNghiemX2 + strDauBang + strDauCach + ((-heSoB) - Math.Sqrt(delta)) / (intTwo * heSoA);
                    }
                }
            }

        }
        #endregion
        #region Hàm giải phương trình bậc một hoặc bậc hai
        /// <summary>
        /// Giải phương trình bậc một hoặc bậc hai
        /// </summary>
        /// <param name="pt"></param>
        public void GiaiPhuongTrinhBacMotHoacHai(int pt)
        {
            if(pt == intOne)
            {
                this.GiaiPhuongTrinhBacMot(Convert.ToDouble(this.textBoxNhapA.Text)
                                            , Convert.ToDouble(this.textBoxNhapB.Text));
            }
            else
            {
                this.GiaiPhuongTrinhBacHai(Convert.ToDouble(this.textBoxNhapA.Text)
                                            , Convert.ToDouble(this.textBoxNhapB.Text)
                                            , Convert.ToDouble(this.textBoxNhapC.Text));
            }
        }
        #endregion
        #region Hàm chỉ cho phép điền số, dấu thập phân, dấu phép toán trừ
        /// <summary>
        /// Hàm chỉ cho phép điền số, dấu thập phân, dấu phép toán trừ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAcceptNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // Cho phép điền dấu thập phân và dấu phép toán trừ
            if ((e.KeyChar == '.') && (e.KeyChar == '-') &&((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Hàm Kiểm tra điền hệ số
        private bool IsFill(string sText)
        {
            bool result = false;
            if (!String.IsNullOrEmpty(sText))
            {
                result = true;
            }
            return result;
        }
        #endregion
        #region Hàm thông báo lỗi
        public void ShowMessErr()
        {
            MessageBox.Show(mesFail, mesNote, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.textBoxNhapA.Focus();
        }
        #endregion
        #region Hàm kiểm tra khi click button Thoát
        /// <summary>
        /// Hàm kiểm tra khi click button Thoát
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
                this.textBoxNhapA.Focus();
            }
        }
        #endregion

    }
}
