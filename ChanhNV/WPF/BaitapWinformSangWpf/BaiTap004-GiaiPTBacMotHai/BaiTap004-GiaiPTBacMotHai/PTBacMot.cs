using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap004_GiaiPTBacMotHai
{
    public class PTBacMot
    {
        #region Các biến lưu khi hiển thị kết quả
        public string strPtVoNghiem = "Phương trình vô nghiệm";
        public string strPtVoSoNghiem = "Phương trình vô số nghiệm";
        public string strPtCoNghiem = "Phương trình có nghiệm: ";
        public string strNghiemX = "x";
        public string strDauBang = "=";
        public string strDauCach = " ";
        #endregion
        #region Hàm Giải Phương Trình Bậc Một
        /// <summary>
        /// GiaiPhuongTrinhBacMot
        /// </summary>
        /// <param name="heSoA"></param>
        /// <param name="heSoB"></param>
        /// <returns></returns>
        public string GiaiPhuongTrinhBacMot(double heSoA, double heSoB)
        {
            string result = string.Empty;
            if (heSoA == 0)
            {
                if (heSoB == 0)
                {
                    result = this.strPtVoSoNghiem;
                }
                else
                {
                    result = this.strPtVoNghiem;
                }
            }
            else
            {
                result = strPtCoNghiem + strNghiemX
                                        + strDauBang + strDauCach + ((-heSoB) / heSoA).ToString();
            }
            return result;
        }
        #endregion
    }
}
