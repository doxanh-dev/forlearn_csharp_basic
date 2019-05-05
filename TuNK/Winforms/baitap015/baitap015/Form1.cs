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
                txtKQTuSo.Text = kqTuSo.ToString();
                txtKQMauSo.Text = kqMauSo.ToString();
            }
        }

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
                txtKQTuSo.Text = kqTuSo.ToString();
                txtKQMauSo.Text = kqMauSo.ToString();
            }
        }

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
                txtKQTuSo.Text = kqTuSo.ToString();
                txtKQMauSo.Text = kqMauSo.ToString();
            }
        }

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
                txtKQTuSo.Text = kqTuSo.ToString();
                txtKQMauSo.Text = kqMauSo.ToString();
            }
        }

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
    }
}
