using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_BaiTap003.Model
{
    class NhanVien : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private string _maNhanVien;
        private string _hoTen;
        private int _ngaySinh;
        private string _diaChi;

        public string MaNhanVien
        {
            get => _maNhanVien;
            set
            {
                _maNhanVien = value;
                RaisePropertyChanged("MaNhanVien");
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

        public int NgaySinh
        {
            get => _ngaySinh;
            set
            {
                _ngaySinh = value;
                RaisePropertyChanged("NgaySinh");
            }
        }

        public string DiaChi
        {
            get => _diaChi;
            set
            {
                _diaChi = value;
                RaisePropertyChanged("DiaChi");
            }
        }
    }
}
