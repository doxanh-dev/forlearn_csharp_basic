using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap007
{
    public static class DocChuSo
    {
        public static string DocSo1ChuSo(string number)
        {
            var result = DocSo(int.Parse(number));
            return result;
        }

        public static string DocSo2ChuSo(string number)
        {
            var result = "";
            var tenHangDonVi = string.Empty;
            var tenHangChuc = string.Empty;

            int hangDonVi = int.Parse(number.Substring(1));
            int hangChuc = int.Parse(number.Substring(0,1));

            //lấy tên đọc của số
            tenHangDonVi = DocSo(hangDonVi);
            tenHangChuc = DocSo(hangChuc);
            
            if (hangDonVi != 0)
            {
                if (hangChuc != 1)
                {
                    //số có dạng 0*
                    if (hangChuc == 0)
                    {
                        result = DocSo1ChuSo(hangDonVi.ToString());
                    }
                    else
                    {
                        result = tenHangChuc + " Mươi " + tenHangDonVi;
                    }
                }
                //số có dạng 1*
                else
                {
                    result = "Mười " + tenHangDonVi;
                }
            }
            else
            {
                //số là 10
                if (hangChuc == 1)
                {
                    result = "Mười";
                }
                //số là tròn chục khác 10
                else
                {
                    result = tenHangChuc + " Mươi";
                }
            }
            return result;
        }

        public static string DocSo3ChuSo(string number)
        {
            var result = "";
            var tenHangDonVi = string.Empty;
            var tenHangChuc = string.Empty;
            var tenHangTram = string.Empty;

            int hangDonVi = int.Parse(number.Substring(2));
            int hangChuc = int.Parse(number.Substring(1, 1));
            int hangTram = int.Parse(number.Substring(0, 1));

            tenHangDonVi = DocSo(hangDonVi);
            tenHangChuc = DocSo(hangChuc);
            tenHangTram = DocSo(hangTram);

            if (hangDonVi != 0)
            {
                if (hangTram != 0)
                {
                    //số có dạng *** (* đều khác 0)
                    if (hangChuc != 0)
                    {
                        result = tenHangTram + " Trăm " + tenHangChuc + " Mươi " + tenHangDonVi;
                    }
                    //số có dạng *0* (* đều khác 0)
                    else
                    {
                        result = tenHangTram + " Trăm Linh " + tenHangDonVi;
                    }
                }
                else
                {
                    //số có dạng 0** (* đều khác 0)
                    if (hangChuc != 0)
                    {
                        result = DocSo2ChuSo(hangChuc.ToString() + hangDonVi.ToString());
                    }
                    //số có dạng 00* (* đều khác 0)
                    else
                    {
                        result = DocSo1ChuSo(hangDonVi.ToString());
                    }
                }
            }
            else
            {
                if (hangTram != 0)
                {
                    //số có dạng **0 (* đều khác 0)
                    if (hangChuc != 0)
                    {
                        result = tenHangTram + " Trăm " + tenHangChuc + " Mươi";
                    }
                    //số có dạng *00 (* đều khác 0)
                    else
                    {
                        result = tenHangTram + " Trăm";
                    }
                }
                else
                {
                    //số có dạng 0*0 (* đều khác 0)
                    if (hangChuc != 0)
                    {
                        result = DocSo2ChuSo(hangChuc.ToString() + hangDonVi.ToString());
                    }
                    //số có dạng 00*
                    else
                    {
                        result = DocSo1ChuSo(hangDonVi.ToString());
                    }
                }
            }
            return result;
        }

        //Doc so hang DonVi
        private static string DocSo(int number)
        {
            var result = "";
            switch (number)
            {
                case 0:
                    result = "Không";
                    break;
                case 1:
                    result = "Một";
                    break;
                case 2:
                    result = "Hai";
                    break;
                case 3:
                    result = "Ba";
                    break;
                case 4:
                    result = "Bốn";
                    break;
                case 5:
                    result = "Năm";
                    break;
                case 6:
                    result = "Sáu";
                    break;
                case 7:
                    result = "Bảy";
                    break;
                case 8:
                    result = "Tám";
                    break;
                case 9:
                    result = "Chín";
                    break;
            }
            return result;
        }
    }
}
