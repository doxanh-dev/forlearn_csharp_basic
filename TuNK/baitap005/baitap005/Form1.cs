using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioSelect2_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
        }

        private void radioSelect1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = false;
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

            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        //click button Giai
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
                //check value radio
                if (radioSelect1.Checked == true)
                {
                    //gọi hàm giải phương trình bậc 1
                    var result = PTBac1.GiaiPhuongTrinhBac1(float.Parse(a), float.Parse(b));
                    txtResule.Text = result;
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
                        var result = PTBac2.GiaiPhuongTrinhBac2(float.Parse(a), float.Parse(b), float.Parse(c));
                        txtResule.Text = result;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtResule.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
