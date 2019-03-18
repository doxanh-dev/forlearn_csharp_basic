using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_BaiTap002
{
    public class ThiSinh
    {
        public int SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public double DiemBai01 { get; set; }
        public double DiemBai02 { get; set; }
        public double DiemBai03 { get; set; }
        public double DiemTiengAnh { get; set; }
        public double DiemCSDL { get; set; }
        public double TongDiem { get; set; }
        public int LoaiThiSinh { get; set; }//1:Chuyên, 2:Siêu cúp

        public static ThiSinh ThemMoiThiSinh(int soBaoDanh, string hoTen, int loaiThiSinh, double diemBai01, double diemBai02
                                    , double diemBai03, double diemTiengAnh, double diemCSDL)
        {
            ThiSinh thiSinhMoi = new ThiSinh();
            thiSinhMoi.SoBaoDanh = soBaoDanh;
            thiSinhMoi.HoTen = hoTen;
            thiSinhMoi.LoaiThiSinh = loaiThiSinh;
            thiSinhMoi.DiemBai01 = diemBai01;
            thiSinhMoi.DiemBai02 = diemBai02;
            thiSinhMoi.DiemBai03 = diemBai03;
            thiSinhMoi.DiemTiengAnh = diemTiengAnh;
            thiSinhMoi.DiemCSDL = diemCSDL;
            thiSinhMoi.TongDiem = diemBai01 + diemBai02 + diemBai03 + diemCSDL + diemTiengAnh;
            return thiSinhMoi;
        }
    }
}
