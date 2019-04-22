using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap012
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            var number = txtNum.Text;
            var daySo = txtDaySo.Text;
            int tong = !string.IsNullOrEmpty(txtTong.Text) ? int.Parse(txtTong.Text) : 0;
            int tongChan = !string.IsNullOrEmpty(txtTongChan.Text) ? int.Parse(txtTongChan.Text) : 0;
            int tongLe = !string.IsNullOrEmpty(txtTongLe.Text) ? int.Parse(txtTongLe.Text) : 0;

            if (string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Bạn chưa điền số ", "Thông báo");
                txtNum.Focus();
            }
            else
            {
                //hien thi day so
                daySo += number + " ";
                txtDaySo.Text = daySo;

                //tinh tong
                tong += int.Parse(number);
                txtTong.Text = tong.ToString();

                //tinh tong so chan va so le
                if (int.Parse(number)%2 == 0)
                {
                    tongChan += int.Parse(number);
                }
                else
                {
                    tongLe += int.Parse(number);
                }

                //hien thi tong so Chan va tong so Le
                txtTongChan.Text = tongChan.ToString();
                txtTongLe.Text = tongLe.ToString();
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtDaySo.Text = "";
            txtTong.Text = "";
            txtTongChan.Text = "";
            txtTongLe.Text = "";
            txtNum.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //check only number
        private void checkOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
