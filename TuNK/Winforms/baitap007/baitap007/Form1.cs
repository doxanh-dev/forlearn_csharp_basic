using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, KeyPressEventArgs e)
        {
            CheckOnlyNumber(sender, e);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            var number = txtNumber.Text;
            if (string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Bạn chưa nhấp số", "Thông báo");
                txtNumber.Focus();
            }
            else
            {
                if (number.Length == 1)
                {
                    var result = DocChuSo.DocSo1ChuSo(number);
                    txtResult.Text = result;
                }
                else if (number.Length == 2)
                {
                    var result = DocChuSo.DocSo2ChuSo(number);
                    txtResult.Text = result;
                }
                else
                {
                    var result = DocChuSo.DocSo3ChuSo(number);
                    txtResult.Text = result;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtResult.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát đúng không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //check only number for TextBox
        private void CheckOnlyNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
