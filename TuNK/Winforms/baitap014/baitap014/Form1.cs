using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumber(sender, e);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            var num = txtNum.Text;

            if (string.IsNullOrEmpty(num))
            {
                MessageBox.Show("Bạn chưa nhập số !!!", "Thông báo");
                txtNum.Focus();
                txtKiemTra.Text = "";
                txtListSNT.Text = "";
            }
            else
            {
                if (kiemTraSNT(int.Parse(num)))
                {
                    txtKiemTra.Text = num + " là số nguyên tố";
                }
                else
                {
                    txtKiemTra.Text = num + " không phải là số nguyên tố";
                }

                //tim day SNT 
                timDaySNT(int.Parse(num));
            }
        }

        //Kiem tra SNT
        private bool kiemTraSNT(int num)
        {
            var result = false;
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                result = true;
            }

            return result;
        }

        //tim day SNT 
        private void timDaySNT(int num)
        {
            string daySNT = "1 ";

            for (int i = 1; i< num; i++)
            {
                if (kiemTraSNT(i))
                {
                    daySNT += i + " ";
                }
            }
            txtListSNT.Text = daySNT;
        }

        //Check only number
        private void checkOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
