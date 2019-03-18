using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap006
{
    public class Common
    {
        #region Các biến hiển thị thông báo
        private static string mesFail = "Bạn chưa nhập vào khung!";
        private static string mesNote = "Thông báo";
        private static string mesExit = "Bạn có muốn thoát";
        private static string mesWarning = "Chú ý";
        #endregion
        #region Hàm kiểm tra điền vào form
        /// <summary>
        /// Hàm kiểm tra điền vào form
        /// </summary>
        /// <param name="sCheck"></param>
        /// <returns></returns>
        public bool isFill(string sCheck)
        {
            bool result = false;
            if (!String.IsNullOrEmpty(sCheck))
            {
                result = true;
            }
            return result;
        }
        #endregion
        #region Hàm Hiển thị Message
        public void ShowMes()
        {
            MessageBox.Show(mesFail, mesNote, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
        #region Hàm kiểm tra chọn Yes/No
        public void CheckAccept(DialogResult dialog)
        {
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region Hàm Show Message Thoát
        public DialogResult showMesExit()
        {
            return MessageBox.Show(mesExit, mesWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
