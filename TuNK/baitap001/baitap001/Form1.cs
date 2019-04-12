using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var id = textId.Text;
            var pass = textPass.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng hoặc mật khẩu");
            }
            else 
            {
                if (id == "tunk" && pass == "123")
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Bạn hãy nhập lại");
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
