using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_BaiTap002
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ThiSinh> danhSachThiSinhChuyen = new List<ThiSinh>();
        List<ThiSinh> danhSachThiSinhSieuCup = new List<ThiSinh>();
        public static DanhSachThiSinh danhSachThiSinh = new DanhSachThiSinh();
        public static ThemThiSinh themThiSinh = new ThemThiSinh();
        public static Boolean IsDanhSachThiSinh = true;
        public static Boolean IsThemThiSinh = true;

        public MainWindow()
        {
            InitializeComponent();
            this.Hide();
            danhSachThiSinh.Show();

            danhSachThiSinh.dataGridThiSinhChuyen.ItemsSource = danhSachThiSinhChuyen;
            danhSachThiSinh.dataGridThiSinhSieuCup.ItemsSource = danhSachThiSinhSieuCup;

            danhSachThiSinh.buttonThem.Click += (o, e) =>
            {
                themThiSinh.Show();
                this.ResetThemSinhVien();
                themThiSinh.buttonCapNhat.Click += (a, b) =>
                {
                    if(!String.IsNullOrEmpty(themThiSinh.textBoxSoBaoDanh.Text))
                    {
                        int soBaoDanh = Int32.Parse(themThiSinh.textBoxSoBaoDanh.Text);
                        List<ThiSinh> lstThiSinhChuyen = (List<ThiSinh>)danhSachThiSinh.dataGridThiSinhChuyen.ItemsSource;
                        List<ThiSinh> lstThiSinhSieuCup = (List<ThiSinh>)danhSachThiSinh.dataGridThiSinhSieuCup.ItemsSource;

                        ThiSinh thiSinhChuyen;
                        ThiSinh thiSinhSieuCup;

                        thiSinhChuyen = lstThiSinhChuyen.Where(m => m.SoBaoDanh == soBaoDanh).FirstOrDefault();
                        thiSinhSieuCup = lstThiSinhSieuCup.Where(m => m.SoBaoDanh == soBaoDanh).FirstOrDefault();

                        if(thiSinhChuyen == null && thiSinhSieuCup == null)
                        {
                            ThiSinh thiSinh = ThiSinh.ThemMoiThiSinh(
                                Int32.Parse(themThiSinh.textBoxSoBaoDanh.Text)
                                , themThiSinh.textBoxHoTen.Text
                                , 1
                                , Double.Parse(themThiSinh.textBoxDiemBai01.Text)
                                , Double.Parse(themThiSinh.textBoxDiemBai02.Text)
                                , Double.Parse(themThiSinh.textBoxDiemBai03.Text)
                                , 0.0
                                , 0.0);

                            if (themThiSinh.radioButtonChuyen.IsChecked == true)
                            {
                                thiSinh.LoaiThiSinh = 1;
                                thiSinh.DiemTiengAnh = Double.Parse(themThiSinh.textBoxDiemTA.Text);
                                danhSachThiSinhChuyen.Add(thiSinh);
                                danhSachThiSinh.dataGridThiSinhChuyen.Items.Refresh();
                            }
                            else
                            {
                                thiSinh.LoaiThiSinh = 2;
                                thiSinh.DiemCSDL = Double.Parse(themThiSinh.textBoxDiemCSDL.Text);
                                danhSachThiSinhSieuCup.Add(thiSinh);
                                danhSachThiSinh.dataGridThiSinhSieuCup.Items.Refresh();
                            }
                            themThiSinh.Hide();
                            
                        }
                    }
                };
            };

        }
        public void ResetThemSinhVien()
        {
            themThiSinh.textBoxSoBaoDanh.Text = string.Empty;
            themThiSinh.textBoxHoTen.Text = string.Empty;
            themThiSinh.textBoxDiemBai01.Text = string.Empty;
            themThiSinh.textBoxDiemBai02.Text = string.Empty;
            themThiSinh.textBoxDiemBai03.Text = string.Empty;
            themThiSinh.textBoxDiemTA.Text = string.Empty;
            themThiSinh.textBoxDiemCSDL.Text = string.Empty;
        }

        //public ThiSinh ThemMoiThiSinh(int soBaoDanh, string hoTen, int loaiThiSinh, double diemBai01, double diemBai02
        //                            , double diemBai03, double diemTiengAnh, double diemCSDL, double tongDiem)
        //{
        //    //ThiSinh thiSinhMoi = new ThiSinh();
        //    //thiSinhMoi.SoBaoDanh = soBaoDanh;
        //    //thiSinhMoi.HoTen = hoTen;
        //    //thiSinhMoi.LoaiThiSinh = loaiThiSinh;
        //    //thiSinhMoi.DiemBai01 = diemBai01;
        //    //thiSinhMoi.DiemBai02 = diemBai02;
        //    //thiSinhMoi.DiemBai03 = diemBai03;
        //    //thiSinhMoi.DiemTiengAnh = diemTiengAnh;
        //    //thiSinhMoi.DiemCSDL = diemCSDL;
        //    //thiSinhMoi.TongDiem = tongDiem;
        //    //return thiSinhMoi;
        //    return ThiSinh
        //        {

        //    }
        //};
    }
}
