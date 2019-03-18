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
    public partial class Form2 : Form
    {
        #region Biến để nhận giá trị truyền từ Form khác
        private string _message;
        #endregion
        #region Khai báo biến dùng chung
        /// <summary>
        /// Khai báo biến dùng chung
        /// </summary>
        Common cm = new Common();
        #endregion
        #region Các chuỗi giá trị cần hiển thị
        private string strTim = "Đã tìm thấy";
        private string strKyTu = "Ký tự";
        private string strDauCach = " ";
        private string strKetqua = "Kết quả";
        private string strKhongThay = "Không tim thấy giá trị!";
        private string strXuatHienTaiVT = "xuất hiện tại vị trí";
        private string strTrongChuoi = "trong chuỗi";
        #endregion
        #region Khởi tạo
        public Form2()
        {
            InitializeComponent();
        }
        #endregion
        #region Hàm khởi tạo truyền nhận biến message
        public String Message
        {
            get { return _message; }
            set { _message = value ; }
        }
        #endregion
        #region Sự kiện Form Load
        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBoxHoTenVuaNhap.Text = _message;
        }
        #endregion
        #region Sự kiện Click button Tìm
        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (this.cm.isFill(textBoxKyTuCanTim.Text))
            {
                this.ShowResult(this.strTim + this.strDauCach
                                                + this.TimKiemKyTu(_message, textBoxKyTuCanTim.Text).ToString()
                                                + this.strDauCach + this.strKyTu + this.strDauCach + this.strTrongChuoi);
            }
            else
            {
                this.cm.ShowMes();
            }
        }
        #endregion
        #region Sự kiện click button Vị trí
        private void buttonViTri_Click(object sender, EventArgs e)
        {
            if (this.cm.isFill(textBoxKyTuCanTim.Text))
            {
                this.textBoxViTriXuatHien.Text =  this.TimViTriKyTu(_message, this.textBoxKyTuCanTim.Text);
                this.textBoxViTriXuatHien.Enabled = true;
            }
            else
            {
                this.cm.ShowMes();
            }
        }
        #endregion
        #region Hàm hiển thị kết quả
        private void ShowResult(string strRe)
        {
            MessageBox.Show(strRe, strKetqua, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
        #region Hàm Tìm kiếm Ký Tự
        /// <summary>
        /// Hàm Tìm kiếm Ký Tự
        /// </summary>
        /// <param name="chuoiCanTim"></param>
        /// <param name="kyTuTK"></param>
        /// <returns></returns>
        public int TimKiemKyTu(string chuoiCanTim, string kyTuTK)
        {
            int soKyTu = 0;
            int index = chuoiCanTim.LastIndexOf(kyTuTK);

            while (index != -1)
            {
                chuoiCanTim = chuoiCanTim.Substring(0, index);
                soKyTu++;
                index = chuoiCanTim.LastIndexOf(kyTuTK);
            }

            return soKyTu;
        }
        #endregion
        #region Hàm Tìm vị trí ký tự
        /// <summary>
        /// Hàm Tìm vị trí ký tự
        /// </summary>
        /// <param name="chuoiCanTim"></param>
        /// <param name="kyTuTim"></param>
        /// <returns></returns>
        public string TimViTriKyTu(string chuoiCanTim, string kyTuTim)
        {
            string result = string.Empty;
            int vitri = 0;
            vitri = chuoiCanTim.IndexOf(kyTuTim);
            if(vitri >= 0)
            {
                result = strKyTu + strDauCach + chuoiCanTim.Substring(vitri, kyTuTim.Length) + strDauCach;
                result += strXuatHienTaiVT + strDauCach;
                result += vitri;
            }
            else
            {
                result = strKhongThay;
            }
            return result;
        }
        #endregion

    }
}
