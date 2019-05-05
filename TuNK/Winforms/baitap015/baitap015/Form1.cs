using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTuSo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumberTextbox(sender, e);
        }

        private void txtMauSo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumberTextbox(sender, e);
        }

        private void txtTuSo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumberTextbox(sender, e);
        }

        private void txtMauSo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumberTextbox(sender, e);
        }

        /// <summary>
        /// sự kiện click button Cộng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCong_Click(object sender, EventArgs e)
        {
            var tuSo1 = txtTuSo1.Text;
            var mauSo1 = txtMauSo1.Text;
            var tuSo2 = txtTuSo2.Text;
            var mauSo2 = txtMauSo2.Text;

            if (!checkValidate(tuSo1, mauSo1, tuSo2, mauSo2))
            {
                var kqTuSo = (int.Parse(tuSo1) * int.Parse(mauSo2)) + (int.Parse(tuSo2) * int.Parse(mauSo1));
                var kqMauSo = int.Parse(mauSo1) * int.Parse(mauSo2);

                grBoxKQ.Text = "Kết quả Cộng";
                rutGon(kqTuSo, kqMauSo);
            }
        }

        /// <summary>
        /// sự kiện click button Trừ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTru_Click(object sender, EventArgs e)
        {
            var tuSo1 = txtTuSo1.Text;
            var mauSo1 = txtMauSo1.Text;
            var tuSo2 = txtTuSo2.Text;
            var mauSo2 = txtMauSo2.Text;

            if (!checkValidate(tuSo1, mauSo1, tuSo2, mauSo2))
            {
                var kqTuSo = (int.Parse(tuSo1) * int.Parse(mauSo2)) - (int.Parse(tuSo2) * int.Parse(mauSo1));
                var kqMauSo = int.Parse(mauSo1) * int.Parse(mauSo2);

                grBoxKQ.Text = "Kết quả Trừ";
                rutGon(kqTuSo, kqMauSo);
            }
        }

        /// <summary>
        /// sự kiện click button Nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhan_Click(object sender, EventArgs e)
        {
            var tuSo1 = txtTuSo1.Text;
            var mauSo1 = txtMauSo1.Text;
            var tuSo2 = txtTuSo2.Text;
            var mauSo2 = txtMauSo2.Text;

            if (!checkValidate(tuSo1, mauSo1, tuSo2, mauSo2))
            {
                var kqTuSo = int.Parse(tuSo1) * int.Parse(tuSo2);
                var kqMauSo = int.Parse(mauSo1) * int.Parse(mauSo2);

                grBoxKQ.Text = "Kết quả Nhân";
                rutGon(kqTuSo, kqMauSo);
            }
        }

        /// <summary>
        /// sự kiện click button Chia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChia_Click(object sender, EventArgs e)
        {
            var tuSo1 = txtTuSo1.Text;
            var mauSo1 = txtMauSo1.Text;
            var tuSo2 = txtTuSo2.Text;
            var mauSo2 = txtMauSo2.Text;

            if (!checkValidate(tuSo1, mauSo1, tuSo2, mauSo2))
            {
                var kqTuSo = int.Parse(tuSo1) * int.Parse(mauSo2);
                var kqMauSo = int.Parse(mauSo1) * int.Parse(tuSo2);

                grBoxKQ.Text = "Kết quả Chia";
                rutGon(kqTuSo, kqMauSo);
            }
        }

        /// <summary>
        /// sự kiện click button Tiếp tục
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTuSo1.Text = "";
            txtMauSo1.Text = "";
            txtTuSo2.Text = "";
            txtMauSo2.Text = "";
            txtKQTuSo.Text = "";
            txtKQMauSo.Text = "";
            grBoxKQ.Text = "Kết quả";
            txtTuSo1.Focus();
        }

        /// <summary>
        /// sự kiện click button Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// checkValidate
        /// </summary>
        /// <param name="tuSo1"></param>
        /// <param name="mauSo1"></param>
        /// <param name="tuSo2"></param>
        /// <param name="mauSo2"></param>
        /// <returns></returns>
        private bool checkValidate(string tuSo1, string mauSo1, string tuSo2, string mauSo2)
        {
            bool result = false;

            if (string.IsNullOrEmpty(tuSo1) 
                || string.IsNullOrEmpty(mauSo1) 
                || string.IsNullOrEmpty(tuSo2) 
                || string.IsNullOrEmpty(mauSo2)
                )
            {
                if (string.IsNullOrEmpty(tuSo1))
                {
                    MessageBox.Show("Bạn chưa nhập tử số của phân số 1", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    txtTuSo1.Focus();
                }
                else if (string.IsNullOrEmpty(mauSo1))
                {
                    MessageBox.Show("Bạn chưa nhập mẫu số của phân số 1", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    txtMauSo1.Focus();
                }
                else if (string.IsNullOrEmpty(tuSo2))
                {
                    MessageBox.Show("Bạn chưa nhập tử số của phân số 2", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    txtTuSo2.Focus();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mẫu số của phân số 2", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    txtMauSo2.Focus();
                }

                result = true;
            }
            
            return result;
        }

        private void rutGon(int tuSo, int mauSo)
        {
            int i = 0;
            if (tuSo < 0)
            {
                int tuSoTemp = tuSo * -1;
                i = timUCLN(tuSoTemp, mauSo);
            }
            else
            {
                i = timUCLN(tuSo, mauSo);
            }
            
            txtKQTuSo.Text = (tuSo / i).ToString();
            txtKQMauSo.Text = (mauSo / i).ToString();
        }

        /// <summary>
        /// checkOnlyNumberTextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkOnlyNumberTextbox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// timUCLN
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int timUCLN(int a, int b)
        {
            int result = 0;
            if (a == 0 || b == 0)
            {
                result = a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            result = a;
            return result;
        }
    }
}
