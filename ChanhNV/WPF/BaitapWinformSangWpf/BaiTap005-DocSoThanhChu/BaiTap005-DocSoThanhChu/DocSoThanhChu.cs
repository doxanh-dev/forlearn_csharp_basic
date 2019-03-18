using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap005_DocSoThanhChu
{
    public class DocSoThanhChu
    {
        #region Các hằng số
        public const int intZero = 0;
        public const int intOne = 1;
        public const int intTwo = 2;
        public const int intThree = 3;
        public const int intFour = 4;
        public const int intFive = 5;
        public const int intSix = 6;
        public const int intSeven = 7;
        public const int intEight = 8;
        public const int intNine = 9;
        #endregion
        #region Các biễn dạng string từ: Không đến Chín
        public string strZero = "Không";
        public string strOne = "Một";
        public string strTwo = "Hai";
        public string strThree = "Ba";
        public string strFour = "Bốn";
        public string strFive = "Năm";
        public string strSix = "Sáu";
        public string strSeven = "Bảy";
        public string strEight = "Tám";
        public string strNine = "Chín";
        #endregion
        #region Các biến dạng string hàng chục
        public string strLinh = "Linh";
        public string strMuoi = "Mười";
        public string strHaiMuoi = "Hai Mươi";
        public string strBaMuoi = "Ba Mươi";
        public string strBonMuoi = "Bốn Mươi";
        public string strNamMuoi = "Năm Mươi";
        public string strSauMuoi = "Sáu Mươi";
        public string strBayMuoi = "Bảy Mươi";
        public string strTamMuoi = "Tám Mươi";
        public string strChinMuoi = "Chín Mươi";
        #endregion
        #region Các biến dạng string hàng trăm
        public string strKoTram = "Không Trăm";
        public string strMotTram = "Một Trăm";
        public string strHaiTram = "Hai Trăm";
        public string strBaTram = "Ba Trăm";
        public string strBonTram = "Bốn Trăm";
        public string strNamTram = "Năm Trăm";
        public string strSauTram = "Sáu Trăm";
        public string strBayTram = "Bảy Trăm";
        public string strTamTram = "Tám Trăm";
        public string strChinTram = "Chín Trăm";
        #endregion
        #region Các biến để hiển thị
        public string strDauCach = " ";
        public string strSoChan = "Chẵn";
        #endregion
        #region Hàm Đọc chữ số hàng đơn vị
        /// <summary>
        /// Đọc chữ số hàng đơn vị
        /// </summary>
        /// <param name="So"></param>
        /// <returns></returns>
        public string DocHangDonVi(int So)
        {
            switch (So)
            {
                case intZero: return strZero;
                case intOne: return strOne;
                case intTwo: return strTwo;
                case intThree: return strThree;
                case intFour: return strFour;
                case intFive: return strFive;
                case intSix: return strSix;
                case intSeven: return strSeven;
                case intEight: return strEight;
                case intNine: return strNine;
                default: return strNine;
            }
        }
        #endregion
        #region Hàm Đọc chữ số hàng chục
        /// <summary>
        /// Đọc chữ số hàng chục
        /// </summary>
        /// <param name="So"></param>
        /// <returns></returns>
        public string DocHangChuc(int So)
        {
            switch (So)
            {
                case intZero: return strLinh;
                case intOne: return strMuoi;
                case intTwo: return strHaiMuoi;
                case intThree: return strBaMuoi;
                case intFour: return strBonMuoi;
                case intFive: return strNamMuoi;
                case intSix: return strSauMuoi;
                case intSeven: return strBayMuoi;
                case intEight: return strTamMuoi;
                case intNine: return strChinMuoi;
                default: return strChinMuoi;
            }
        }
        #endregion
        #region Hàm Đọc chữ số hàng trăm
        /// <summary>
        /// Đọc chữ số hàng trăm
        /// </summary>
        /// <param name="So"></param>
        /// <returns></returns>
        public string DocHangTram(int So)
        {
            switch (So)
            {
                case intZero: return strKoTram;
                case intOne: return strMotTram;
                case intTwo: return strHaiTram;
                case intThree: return strBaTram;
                case intFour: return strBonTram;
                case intFive: return strNamTram;
                case intSix: return strSauTram;
                case intSeven: return strBayTram;
                case intEight: return strTamTram;
                case intNine: return strChinTram;
                default: return strChinTram;
            }
        }
        #endregion
        #region Hàm Đọc Chữ Số
        /// <summary>
        /// Đọc chữ số
        /// </summary>
        /// <param name="chuSo"></param>
        /// <returns></returns>
        public string DocChuSo(string chuSo)
        {
            // Biến kết quả
            string result = string.Empty;
            // Khai báo các biến string để đọc chữ số
            string strHangDonVi = string.Empty;
            string strHangChuc = string.Empty;
            string strHangTram = string.Empty;
            // Khai báo các biến int để đọc chữ số
            int intHangDonVi;
            int intHangChuc;
            int intHangTram;

            // Trường hợp số có 1 chữ số
            if (chuSo.Length == intOne)
            {
                intHangDonVi = int.Parse(chuSo.Substring(chuSo.Length - intOne, intOne));
                strHangDonVi = this.DocHangDonVi(intHangDonVi);
                result = strHangDonVi;
            }
            // Trường hợp số có 2 chữ số
            else if (chuSo.Length == intTwo)
            {
                intHangDonVi = int.Parse(chuSo.Substring(chuSo.Length - intOne, intOne));
                intHangChuc = int.Parse(chuSo.Substring(chuSo.Length - intTwo, intOne));
                strHangDonVi = this.DocHangDonVi(intHangDonVi);
                strHangChuc = this.DocHangChuc(intHangChuc);
                if (intHangDonVi == intZero)
                {
                    result = strHangChuc;
                }
                else
                {
                    result = strHangChuc + strDauCach + strHangDonVi;
                }
            }
            // Trường hợp số có 3 chữ số
            else if (chuSo.Length == intThree)
            {
                intHangDonVi = int.Parse(chuSo.Substring(chuSo.Length - intOne, intOne));
                intHangChuc = int.Parse(chuSo.Substring(chuSo.Length - intTwo, intOne));
                intHangTram = int.Parse(chuSo.Substring(chuSo.Length - intThree, intOne));
                strHangDonVi = this.DocHangDonVi(intHangDonVi);
                strHangChuc = this.DocHangChuc(intHangChuc);
                strHangTram = this.DocHangTram(intHangTram);
                if (intHangDonVi == intZero)
                {
                    result = strHangTram + strDauCach + strSoChan;
                }
                else
                {
                    result = strHangTram + strDauCach + strHangChuc + strDauCach + strHangDonVi;
                }

            }
            return result;
        }
        #endregion
    }
}
