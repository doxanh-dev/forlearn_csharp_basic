using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkSoN(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        private void checkSoX(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var soN = txtSoN.Text;
            var soX = txtSoX.Text;

            if (string.IsNullOrEmpty(soN) || string.IsNullOrEmpty(soX))
            {
                MessageBox.Show("Bạn phải nhập đủ số X hoặc sô N", "Thông báo");
                if (string.IsNullOrEmpty(soN))
                {
                    txtSoN.Focus();
                }
                else
                {
                    txtSoX.Focus();
                }
            }
            else
            {
                var kq1 = string.Empty;
                var kq2 = string.Empty;
                var kq3 = string.Empty;
                var kq4 = 0;

                int temp = 0;

                for(int i = 1; i <= int.Parse(soN); i++)
                {
                    temp = 0;
                    kq1 += "X^" + i + " + ";
                    kq2 += int.Parse(soX) + "^" + i + " + ";

                    temp = (int) Math.Pow(int.Parse(soX), i);
                    kq3 += temp + " + ";
                    kq4 += temp;
                }

                kq1 = kq1.Substring(0, kq1.Length - 3);
                kq2 = kq2.Substring(0, kq2.Length - 3);
                kq3 = kq3.Substring(0, kq3.Length - 3);

                txtKq1.Text = kq1;
                txtKq2.Text = kq2;
                txtKq3.Text = kq3;
                txtKq4.Text = kq4.ToString();
            }
        }

        //check only number for TextBox
        private void CheckOnlyNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
