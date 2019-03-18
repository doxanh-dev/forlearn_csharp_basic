using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap005
{
    public class PTBacHai
    {
        #region Các biến lưu khi hiển thị kết quả
        public string strPtVoNghiem = "Phương trình vô nghiệm";
        public string strPtVoSoNghiem = "Phương trình vô số nghiệm";
        public string strPtCoNghiem = "Phương trình có nghiệm: ";
        public string strPtCoMotNghiem = "Phương trình có 1 nghiệm: ";
        public string strPtCoHaiNghiem = "Phương trình có 2 nghiệm: ";
        public string strNghiemX = "x";
        public string strNghiemX1 = "x1";
        public string strNghiemX2 = "x2";
        public string strDauBang = "=";
        public string strDauCach = " ";
        public string strDauPhay = ",";
        #endregion
        #region Các biến hằng số
        public const int intOne = 1;
        public const int intTwo = 2;
        public const int intFour = 4;
        #endregion
        #region Hàm giải phương trình bậc Hai
        /// <summary>
        /// Hàm giải phương trình bậc Hai
        /// </summary>
        /// <param name="heSoA"></param>
        /// <param name="heSoB"></param>
        /// <param name="heSoC"></param>
        public string GiaiPhuongTrinhBacHai(double heSoA, double heSoB, double heSoC)
        {
            string result = string.Empty;
            // Tắt vô hiệu hóa textbox hiển thị
            //this.textBoxKetQua.Enabled = true;
            // Khai báo biến delta
            double delta;
            // Trường hợp hệ số a = 0
            if (heSoA == 0)
            {
                if (heSoB == 0)
                {
                    if (heSoC == 0)
                    {
                        result = strPtVoSoNghiem;
                    }
                    else
                    {
                        result = strPtVoNghiem;
                    }
                }
                else
                {
                    result = strPtCoNghiem + strNghiemX
                                            + strDauBang + strDauCach + ((-heSoC) / heSoB).ToString();
                }
            }
            else
            {
                // Trường hợp hệ số a khác 0
                delta = Math.Pow(heSoB, intTwo) - (intFour * heSoA * heSoC);
                if (delta < 0)
                {
                    result = strPtVoNghiem;
                }
                else
                {
                    if (delta == 0)
                    {
                        result = strPtCoMotNghiem + strNghiemX
                                + strDauBang + strDauCach + ((-heSoB) / (intTwo * heSoA));
                    }
                    else
                    {
                        result = strPtCoHaiNghiem
                                + strNghiemX1 + strDauBang + strDauCach + ((-heSoB) + Math.Sqrt(delta)) / (intTwo * heSoA)
                                + strDauPhay + strDauCach
                                + strNghiemX2 + strDauBang + strDauCach + ((-heSoB) - Math.Sqrt(delta)) / (intTwo * heSoA);
                    }
                }
            }

            return result;
        }
        #endregion
    }
}
