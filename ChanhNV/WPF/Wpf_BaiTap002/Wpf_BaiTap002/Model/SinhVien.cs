using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_BaiTap002.Model
{
    class SinhVien : INotifyPropertyChanged
    {
        private int _soBaoDanh;
        private string _hoTen;
        private bool _loaiThiSinh;
        private double _diemBai01;
        private double _diemBai02;
        private double _diemBai03;
        private double _diemTiengAnh;
        private double _diemCSDL;
        private double _tongDiem;

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public int SoBaoDanh
        {
            get => _soBaoDanh;
            set
            {
                _soBaoDanh = value;
                RaisePropertyChanged("SoBaoDanh");
            }
        }

        public string HoTen
        {
            get => _hoTen;
            set
            {
                _hoTen = value;
                RaisePropertyChanged("HoTen");
            }
        }

        public bool LoaiThiSinh
        {
            get => _loaiThiSinh;
            set
            {
                _loaiThiSinh = value;
                RaisePropertyChanged("LoaiThiSinh");
            }
        }

        public double DiemBai01
        {
            get => _diemBai01;
            set
            {
                _diemBai01 = value;
                RaisePropertyChanged("DiemBai01");
            }
        }

        public double DiemBai02
        {
            get => _diemBai02;
            set
            {
                _diemBai02 = value;
                RaisePropertyChanged("DiemBai02");
            }
        }

        public double DiemBai03
        {
            get => _diemBai03;
            set
            {
                _diemBai03 = value;
                RaisePropertyChanged("DiemBai03");
            }
        }

        public double DiemTiengAnh
        {
            get => _diemTiengAnh;
            set
            {
                _diemTiengAnh = value;
                RaisePropertyChanged("DiemBai03");
            }
        }

        public double DiemCSDL
        {
            get => _diemCSDL;
            set
            {
                _diemCSDL = value;
                RaisePropertyChanged("DiemBai03");
            }
        }

        public double TongDiem
        {
            get => _tongDiem;
            set
            {
                _tongDiem = value;
                RaisePropertyChanged("DiemBai03");
            }
        }

    }
}
