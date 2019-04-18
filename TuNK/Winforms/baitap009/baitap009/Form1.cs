using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkNumber1(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        private void checkNumber2(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            var num1 = txtNumber1.Text;
            var num2 = txtNumber2.Text;

            if (string.IsNullOrEmpty(num1))
            {
                MessageBox.Show("Bạn chưa điền số hạng thứ nhất", "Thông báo");
                txtNumber1.Focus();
            }
            else if (string.IsNullOrEmpty(num2))
            {
                MessageBox.Show("Bạn chưa điền số hạng thứ hai", "Thông báo");
                txtNumber2.Focus();
            }
            else if (radioCong.Checked == false && radioTru.Checked == false && radioNhan.Checked == false && radioChia.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn phép tính", "Thông báo");
                radioCong.Focus();
            }
            else
            {
                string result = string.Empty;

                if (radioCong.Checked == true)
                {
                    var cong = int.Parse(num1) + int.Parse(num2);
                    textResult.Text = cong.ToString();
                }
                else if (radioTru.Checked == true)
                {
                    var tru = int.Parse(num1) - int.Parse(num2);
                    textResult.Text = tru.ToString();
                }
                else if (radioNhan.Checked == true)
                {
                    var nhan = int.Parse(num1) * int.Parse(num2);
                    textResult.Text = nhan.ToString();
                }
                else
                {
                    var chia = float.Parse(num1) / float.Parse(num2);
                    float chia_float = (float)Math.Round(chia * 100f) / 100f;
                    textResult.Text = chia_float.ToString();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //check only number for TextBox
        private void CheckOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)  && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
