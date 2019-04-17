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
            txtKq1.Text = "12";
            txtKq2.Text = "12";
            txtKq3.Text = "12";
            txtKq4.Text = "12";
        }

        //check only number for TextBox
        private void CheckOnlyNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
