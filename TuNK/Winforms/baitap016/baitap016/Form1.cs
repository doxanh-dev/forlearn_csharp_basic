using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap016
{
    public partial class Form1 : Form
    {
        public string temp = "";
        private string PhepToan, LastValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var num1 = btn1.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var num2 = btn2.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var num3 = btn3.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            var num4 = btn4.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            var num5 = btn5.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            var num6 = btn6.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            var num7 = btn7.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            var num8 = btn8.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            var num9 = btn9.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            var num0 = btn0.Text;
            temp = txtShow.Text;
            txtShow.Text = temp + num0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
            txtShow.Focus();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            LastValue = txtShow.Text;
            PhepToan = "+";
            txtShow.Clear();
            txtShow.Focus();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            LastValue = txtShow.Text;
            PhepToan = "-";
            txtShow.Clear();
            txtShow.Focus();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            LastValue = txtShow.Text;
            PhepToan = "*";
            txtShow.Clear();
            txtShow.Focus();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            LastValue = txtShow.Text;
            PhepToan = "/";
            txtShow.Clear();
            txtShow.Focus();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            var soThuNhat = float.Parse(LastValue);
            var soThuHai = float.Parse(txtShow.Text);

            if (string.IsNullOrEmpty(LastValue) && string.IsNullOrEmpty(txtShow.Text))
            {
                MessageBox.Show("Không thỏa mãn !", "Thông báo");
            }
            else
            {
                if (PhepToan == "+")
                {
                    txtShow.Text = (soThuNhat + soThuHai).ToString();
                }
                else if (PhepToan == "-")
                {
                    txtShow.Text = (soThuNhat - soThuHai).ToString();
                }
                else if (PhepToan == "*")
                {
                    txtShow.Text = (soThuNhat * soThuHai).ToString();
                }
                else if (PhepToan == "/")
                {
                    txtShow.Text = Math.Round(soThuNhat / soThuHai, 2).ToString();
                }
            }
        }
    }
}
