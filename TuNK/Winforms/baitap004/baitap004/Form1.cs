using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioSelect1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = false;
        }

        private void radioSelect2_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
        }

        private void txtA_TextChanged(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        private void txtB_TextChanged(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        private void txtC_TextChanged(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        //Sự kiên khi click button Giải
        private void btnGiai_Click(object sender, EventArgs e)
        {
            var a = txtA.Text;
            var b = txtB.Text;
            var c = txtC.Text;

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                MessageBox.Show("Các tham số cần phải điền đầy đủ !", "Thông báo");
                if (string.IsNullOrEmpty(a))
                {
                    txtA.Focus();
                }
                else
                {
                    txtB.Focus();
                }
            }
            else
            {
                if (radioSelect1.Checked == true)
                {
                    //gọi hàm giải phương trình bậc 1
                    GiaiPhuongTrinhBac1(float.Parse(a), float.Parse(b));
                }
                else if (radioSelect2.Checked == true)
                {
                    if (string.IsNullOrEmpty(c))
                    {
                        MessageBox.Show("Các tham số cần phải điền đầy đủ !", "Thông báo");
                        txtC.Focus();
                    }
                    else
                    {
                        //gọi hàm giải phương trình bậc 2
                        GiaiPhuongTrinhBac2(float.Parse(a), float.Parse(b), float.Parse(c));
                    }
                }
            }
        }

        //GiaiPhuongTrinhBac1 
        private void GiaiPhuongTrinhBac1(float a, float b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    txtResule.Text = "Pt vô số nghiệm";
                }
                else
                {
                    txtResule.Text = "Pt vô nghiệm";
                }
            }
            else 
            {
                var result = -b/a;

                float x = (float)Math.Round(result * 100f) / 100f;
                txtResule.Text = "Pt có nghiệm: "+ x;
            }
        }

        //GiaiPhuongTrinhBac2
        private void GiaiPhuongTrinhBac2(float a, float b, float c)
        {
            if (a != 0)
            {
                var delta = (b * b) - (4 * a * c);

                if (delta < 0)
                {
                    txtResule.Text = "Pt vô nghiệm";
                }
                else if (delta == 0)
                {
                    var result = (-b) / (2 * a);
                    float x1c = (float)Math.Round(result * 100f) / 100f;
                    txtResule.Text = "Pt có nghiệm kép: x1=x1=" + x1c;
                }
                else
                {
                    var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    float x1c = (float)Math.Round(x1 * 100f) / 100f;
                    float x2c = (float)Math.Round(x2 * 100f) / 100f;
                    txtResule.Text = "Pt có 2 nghiệm: x1=" + x1c + " và x2=" + x2c;
                }
            }
            else
            {
                //gọi hàm giải phương trình bậc 1
                GiaiPhuongTrinhBac1(b, c);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //check only number
        private void CheckOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
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
