using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap006
{
    public partial class Form1 : Form
    {
        public static string HoTen = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HoTen = textHoTen.Text;

            if (string.IsNullOrEmpty(HoTen))
            {
                MessageBox.Show("Phải điền Họ tên", "Thông báo");
            }
            else
            {
                this.Visible = false;
                Form2 form2 = new Form2();
                form2.Show();
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
    }
}
