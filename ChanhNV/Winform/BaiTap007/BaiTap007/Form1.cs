using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap007
{
    public partial class Form1 : Form
    {
        #region Khai báo Class các hàm hay dùng
        /// <summary>
        /// Khái báo các hàm hay dùng
        /// </summary>
        Common cm = new Common();
        #endregion
        #region Khai Báo Class DocSoThanhChu
        DocSoThanhChu docSoThanhChu;
        #endregion
        #region Khởi tạo
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Sự kiện Click button Thoát
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chọn giá trị Yes/No khi thông báo muốn thoát
            DialogResult resultExit = cm.showMesExit();
            this.cm.CheckAccept(resultExit);
        }
        #endregion
        #region Sự kiện Click button Xóa
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chọn giá trị Yes/No khi thông báo muốn thoát
            DialogResult resultExit = cm.showMesReset();
            this.CheckDel(resultExit);
        }
        #endregion
        #region Sự kiện KeyPress của textBox nhập số
        private void textBoxNhapDaySo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.CheckAcceptNumber(sender, e);
        }
        #endregion
        #region Sự kiện Click button Thực hiện
        private void buttonThucHien_Click(object sender, EventArgs e)
        {
            if (this.cm.IsFill(this.textBoxNhapDaySo.Text))
            {
                //this.textBoxKetQua.Text = this.textBoxNhapDaySo.Text;
                docSoThanhChu = new DocSoThanhChu();
                this.textBoxKetQua.Text = docSoThanhChu.DocChuSo(this.textBoxNhapDaySo.Text);
            }
            else
            {
                this.cm.ShowMes();
            }
        }
        #endregion
        #region Hàm chỉ cho phép điền số
        /// <summary>
        /// Hàm chỉ cho phép điền số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAcceptNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Hàm ResetTextBox
        public void ResetTextBox()
        {
            this.textBoxNhapDaySo.ResetText();
            this.textBoxKetQua.ResetText();
        }
        #endregion
        #region Hàm Kiểm tra xem có chọn Xóa hay không
        public void CheckDel(DialogResult dialog)
        {
            if (dialog == DialogResult.Yes)
            {
                this.ResetTextBox();
            }
        }
        #endregion
    }
}
