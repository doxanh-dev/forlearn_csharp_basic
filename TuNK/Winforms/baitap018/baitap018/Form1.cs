using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            var noiDung = txtNoiDung.Text;
            var temp = string.Empty;

            if (string.IsNullOrEmpty(noiDung))
            {
                MessageBox.Show("Bạn chưa điền nội dung !!!", "Thông báo");
                txtNoiDung.Focus();
            }
            else
            {
                if (!rdoChuThuong.Checked && !rdoChuHoa.Checked)
                {
                    MessageBox.Show("Bạn chưa chọn chữ thường hoặc chữ hoa !!!", "Thông báo");
                    rdoChuThuong.Focus();
                }
                else
                {
                    if (rdoChuThuong.Checked)
                    {
                        temp = noiDung.ToLower();
                    }
                    else
                    {
                        temp = noiDung.ToUpper();
                    }
                    txtShow.Text = temp;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
            txtShow.Text = "";
            rdoChuHoa.Checked = false;
            rdoChuThuong.Checked = false;
            txtNoiDung.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
