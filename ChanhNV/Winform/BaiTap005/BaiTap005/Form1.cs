using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap005
{
    public partial class Form1 : Form
    {
        #region Các biến hằng số
        public const int intOne = 1;
        public const int intTwo = 2;
        public const int intFour = 4;
        #endregion
        #region Các biến hiển thị thông báo
        public string mesFail = "Bạn phải điền đủ hệ số!";
        public string mesNote = "Thông báo";
        public string mesExit = "Bạn có muốn thoát";
        public string mesWarning = "Chú ý";
        public string mesDel = "Bạn có muốn nhập lại hệ số";
        #endregion
        #region Các Biến Giải PT Bậc Một, Bậc Hai
        PTBacMot pTBacMot;
        PTBacHai pTBacHai;
        #endregion
        #region Khởi tạo
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Sự Kiện Check của radioButtonGiaiPTBacMot
        private void radioButtonGiaiPTBacMot_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxNhapC.Enabled = false;
            this.ResetTextBox();
        }
        #endregion
        #region Sự Kiện Check của radioButtonGiaiPTBacHai
        private void radioButtonGiaiPTBacHai_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxNhapC.Enabled = true;
            this.ResetTextBox();
        }
        #endregion
        #region Sự Kiện KeyPress của textBoxNhapA
        private void textBoxNhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.CheckAcceptNumber(sender, e);
        }
        #endregion
        #region Sự Kiện KeyPress của textBoxNhapB
        private void textBoxNhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.CheckAcceptNumber(sender, e);
        }
        #endregion
        #region Sự Kiện KeyPress của textBoxNhapC
        private void textBoxNhapC_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.CheckAcceptNumber(sender, e);
        }
        #endregion
        #region Sự Kiện khi Click button Giải
        private void buttonGiai_Click(object sender, EventArgs e)
        {
            if (this.IsFill(this.textBoxNhapA.Text)
                && this.IsFill(this.textBoxNhapB.Text))
            {
                this.textBoxKetQua.Enabled = true;
                if (radioButtonGiaiPTBacMot.Checked == true)
                {
                    this.textBoxKetQua.Text = this.GiaiPhuongTrinhBacMotHoacHai(intOne);
                }
                else
                {
                    if (this.IsFill(this.textBoxNhapC.Text))
                    {
                        this.textBoxKetQua.Text = this.GiaiPhuongTrinhBacMotHoacHai(intTwo);
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
        #region Sự kiện Click vào button Xóa
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chọn giá trị Yes/No khi thông báo muốn Xóa
            DialogResult resultDel;
            resultDel = (MessageBox.Show(mesDel, mesWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            this.CheckDel(resultDel);
        }
        #endregion
        #region Sự kiện Click vào button Thoát
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chọn giá trị Yes/No khi thông báo muốn thoát
            DialogResult resultExit;
            resultExit = (MessageBox.Show(mesExit, mesWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));

            this.CheckAccept(resultExit);
        }
        #endregion
        #region Hàm giải phương trình bậc một hoặc bậc hai
        /// <summary>
        /// Giải phương trình bậc một hoặc bậc hai
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        public string GiaiPhuongTrinhBacMotHoacHai(int pt)
        {
            string result = string.Empty;
            if (pt == intOne)
            {
                pTBacMot = new PTBacMot();
                result = this.pTBacMot.GiaiPhuongTrinhBacMot(
                                        Convert.ToDouble(this.textBoxNhapA.Text)
                                        , Convert.ToDouble(this.textBoxNhapB.Text));
            }
            else
            {
                pTBacHai = new PTBacHai();
                result = this.pTBacHai.GiaiPhuongTrinhBacHai(
                                            Convert.ToDouble(this.textBoxNhapA.Text)
                                            , Convert.ToDouble(this.textBoxNhapB.Text)
                                            , Convert.ToDouble(this.textBoxNhapC.Text));
            }
            return result;
        }
        #endregion
        #region Hàm Reset TextBox
        private void ResetTextBox()
        {
            this.textBoxNhapA.ResetText();
            this.textBoxNhapB.ResetText();
            this.textBoxNhapC.ResetText();
            this.textBoxKetQua.ResetText();
            this.textBoxKetQua.Enabled = false;
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
            if ((e.KeyChar == '.') && (e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('.') > -1))
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
        #region Hàm kiểm tra khi click button
        /// <summary>
        /// Hàm kiểm tra khi click button
        /// </summary>
        /// <param name="dialog"></param>
        public void CheckAccept(DialogResult dialog)
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
        #region Hàm Kiểm tra khi Click button Xóa
        public void CheckDel(DialogResult dialog)
        {
            if (dialog == DialogResult.Yes)
            {
                this.ResetTextBox();
            }
            else
            {
                this.textBoxNhapA.Focus();
            }
        }
        #endregion
    }
}
