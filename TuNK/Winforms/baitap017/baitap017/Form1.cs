using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHTGNhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumberTextbox(sender, e);
        }

        private void txtHTGNhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumberTextbox(sender, e);
        }

        private void txtHTGNhapC_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkOnlyNumberTextbox(sender, e);
        }

        private void rdoHVuong_CheckedChanged(object sender, EventArgs e)
        {
            grpHinhVuong.Show();
            grpHinhTron.Hide();
            grpHinhChuNhat.Hide();
            grpHinhTamGiac.Hide();
            txtHVCanhA.Focus();
        }

        private void rdoHTron_CheckedChanged(object sender, EventArgs e)
        {
            grpHinhTron.Show();
            grpHinhVuong.Hide();
            grpHinhChuNhat.Hide();
            grpHinhTamGiac.Hide();
            txtHTBanKinh.Focus();
        }

        private void rdoHChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            grpHinhChuNhat.Show();
            grpHinhTron.Hide();
            grpHinhVuong.Hide();
            grpHinhTamGiac.Hide();
            txtHCNNhapA.Focus();
        }

        private void rdoHTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            grpHinhTamGiac.Show();
            grpHinhChuNhat.Hide();
            grpHinhTron.Hide();
            grpHinhVuong.Hide();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdoHVuong.Checked)
            {
                var canhA = txtHVCanhA.Text;

                if (string.IsNullOrEmpty(canhA))
                {
                    MessageBox.Show("Bạn chưa nhập cạnh A của hình vuông", "Thông báo");
                    txtHVCanhA.Focus();
                }
                else
                {
                    var chuViHV = int.Parse(canhA) * 4;
                    var dienTichHV = int.Parse(canhA) * int.Parse(canhA);

                    txtHVChuVi.Text = chuViHV.ToString();
                    txtHVDienTich.Text = dienTichHV.ToString();
                }
            }
            else if (rdoHTron.Checked)
            {
                var banKinh = txtHTBanKinh.Text;

                if (string.IsNullOrEmpty(banKinh))
                {
                    MessageBox.Show("Bạn chưa nhập bán kính của hình tròn", "Thông báo");
                    txtHTBanKinh.Focus();
                }
                else
                {
                    var chuViHT = Math.Round(2 * int.Parse(banKinh) * 3.14, 2);
                    var dienTichHT = Math.Round(int.Parse(banKinh) * int.Parse(banKinh) * 3.14, 2);

                    txtHTChuVi.Text = chuViHT.ToString();
                    txtHTDienTich.Text = dienTichHT.ToString();
                }
            }
            else if (rdoHChuNhat.Checked)
            {
                var canhA = txtHCNNhapA.Text;
                var canhB = txtHCNNhapB.Text;

                if (string.IsNullOrEmpty(canhA))
                {
                    MessageBox.Show("Bạn chưa nhập cạnh A của hình chữ nhật", "Thông báo");
                    txtHCNNhapA.Focus();
                }
                else if (string.IsNullOrEmpty(canhB))
                {
                    MessageBox.Show("Bạn chưa nhập cạnh B của hình chữ nhật", "Thông báo");
                    txtHCNNhapB.Focus();
                }
                else
                {
                    var chuViHCN = (int.Parse(canhA) + int.Parse(canhB)) * 2;
                    var dienTichHCN = int.Parse(canhA) * int.Parse(canhB);

                    txtHCNChuVi.Text = chuViHCN.ToString();
                    txtHCNDienTich.Text = dienTichHCN.ToString();
                }
            }
            else if (rdoHTamGiac.Checked)
            {
                var canhA = txtHTGNhapA.Text;
                var canhB = txtHTGNhapB.Text;
                var canhC = txtHTGNhapC.Text;

                if (string.IsNullOrEmpty(canhA))
                {
                    MessageBox.Show("Bạn chưa nhập cạnh A của hình tam giác", "Thông báo");
                    txtHTGNhapA.Focus();
                }
                else if (string.IsNullOrEmpty(canhB))
                {
                    MessageBox.Show("Bạn chưa nhập cạnh B của hình tam giác", "Thông báo");
                    txtHTGNhapB.Focus();
                }
                else if (string.IsNullOrEmpty(canhC))
                {
                    MessageBox.Show("Bạn chưa nhập cạnh C của hình tam giác", "Thông báo");
                    txtHTGNhapC.Focus();
                }
                else
                {

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (rdoHVuong.Checked)
            {
                txtHVCanhA.Text = "";
                txtHVChuVi.Text = "";
                txtHVDienTich.Text = "";
                txtHVCanhA.Focus();
            }
            else if (rdoHTron.Checked)
            {
                txtHTBanKinh.Text = "";
                txtHTChuVi.Text = "";
                txtHTDienTich.Text = "";
                txtHTBanKinh.Focus();
            }
            else if (rdoHChuNhat.Checked)
            {
                txtHCNNhapA.Text = "";
                txtHCNNhapB.Text = "";
                txtHCNChuVi.Text = "";
                txtHCNDienTich.Text = "";
                txtHCNNhapA.Focus();
            }
            else if (rdoHTamGiac.Checked)
            {
                txtHTGNhapA.Text = "";
                txtHTGNhapB.Text = "";
                txtHTGNhapC.Text = "";
                txtHTGChuVi.Text = "";
                txtHTGDienTich.Text = "";
                txtLaTamGiac.Text = "";
                txtHTGNhapA.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát đúng không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// checkOnlyNumberTextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkOnlyNumberTextbox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
