using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap006
{
    public partial class Form1 : Form
    {
        #region báo các hàm dùng chung
        /// <summary>
        /// Khái báo các hàm dùng chung
        /// </summary>
        Common cm = new Common();
        #endregion
        #region Khởi tạo
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Sự kiện Click button Tìm Kiếm
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            this.TimKiem();
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
        #region Hàm Tìm kiếm
        /// <summary>
        /// Hàm Tìm kiếm
        /// </summary>
        public void TimKiem()
        {
            if (this.cm.isFill(textBoxNhapHoTen.Text))
            {
                Form2 formThaoTac = new Form2();
                formThaoTac.Message = textBoxNhapHoTen.Text;
                formThaoTac.Show();
            }
            else
            {
                this.cm.ShowMes();
            }
        }
        #endregion
    }
}
