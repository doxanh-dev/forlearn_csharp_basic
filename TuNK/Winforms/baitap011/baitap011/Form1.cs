using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumber(sender, e);
        }

        private void txtB_TextChanged(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumber(sender, e);
        }

        //Check only number
        private void checkOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            var a = txtA.Text;
            var b = txtB.Text;

            if (string.IsNullOrEmpty(a))
            {
                MessageBox.Show("Bạn chưa điền số a !", "Thông báo");
                txtA.Focus();
            }
            else if (string.IsNullOrEmpty(b))
            {
                MessageBox.Show("Bạn chưa điền số b !", "Thông báo");
                txtB.Focus();
            }
            else
            {
                //UCLN
                txtResultUS.Text = timUCLN(int.Parse(a), int.Parse(b)).ToString();

                //BCNN
                txtResultBS.Text = timBCNN(int.Parse(a), int.Parse(b)).ToString();
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResultUS.Text = "";
            txtResultBS.Text = "";
            txtA.Focus();
        }

        //tim UCLN
        private int timUCLN(int a, int b)
        {
            int result = 0;
            if (a == 0 || b == 0)
            {
                result =  a + b;
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

        //tim BCNN
        private int timBCNN(int a, int b)
        {
            int result = 0;
            result = a * b * timUCLN(a, b);

            return result;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
