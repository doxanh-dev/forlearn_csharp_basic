using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf_BaiTap003.Model;
using Wpf_BaiTap003.View;

namespace Wpf_BaiTap003.ViewModel
{
    class MainViewModel
    {
        private ICommand addButtonCommand;
        private ICommand editButtonCommand;
        private ICommand cancelButtonCommand;
        private ICommand deleteButtonCommand;

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        private bool canExecute = true;
        public bool CanExecute { get => canExecute; set => canExecute = value; }

        // Used to notify the page that a data context property changed
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Used to notify the data context that a data context property is about to change
        protected void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        public ObservableCollection<NhanVien> DanhSachNhanVien
        {
            get;
            set;
        }

        public NhanVien _detailItem = new NhanVien();

        public NhanVien DetailItem
        {
            get => _detailItem;
            set
            {
                NotifyPropertyChanging("DetailItem");
                _detailItem = value;
                NotifyPropertyChanged("DetailItem");
            }
        }

        public NhanVien _selectItem;

        public NhanVien SelectItem
        {
            get => _selectItem;
            set
            {
                NotifyPropertyChanging("SelectItem");
                _selectItem = value;
                if(_selectItem != null)
                {
                    DetailItem.MaNhanVien = _selectItem.MaNhanVien;
                    DetailItem.HoTen = _selectItem.HoTen;
                    DetailItem.NgaySinh = _selectItem.NgaySinh;
                    DetailItem.DiaChi = _selectItem.DiaChi;
                }
                
                NotifyPropertyChanged("SelectItem");
            }
        }

        public MainViewModel()
        {
            addButtonCommand = new RelayCommand.RelayCommand(AddNhanVienCommand, param => this.canExecute);
            editButtonCommand = new RelayCommand.RelayCommand(EditNhanVienCommand, param => this.canExecute);
            deleteButtonCommand = new RelayCommand.RelayCommand(DeleteCommand, param => this.canExecute);
            cancelButtonCommand = new RelayCommand.RelayCommand(CloseCommand, param => this.canExecute);
        }

        public void LoadDanhSachNhanVien()
        {
            ObservableCollection<NhanVien> nhanViens = new ObservableCollection<NhanVien>();
            nhanViens.Add(new NhanVien { MaNhanVien = "1", HoTen = "Nguyen Van A", NgaySinh = 20190502, DiaChi = "Ha Noi" });
            nhanViens.Add(new NhanVien { MaNhanVien = "2", HoTen = "Nguyen Van B", NgaySinh = 20190402, DiaChi = "Ha Noi" });
            nhanViens.Add(new NhanVien { MaNhanVien = "3", HoTen = "Nguyen Van C", NgaySinh = 20190302, DiaChi = "Ha Noi" });

            DanhSachNhanVien = nhanViens;
        }

        public ICommand EditButtonCommand { get => editButtonCommand; set => editButtonCommand = value; }
        public void EditNhanVienCommand(object obj)
        {
            NhanVien nhanVienTonTai = DanhSachNhanVien.Where(x => x.MaNhanVien == _detailItem.MaNhanVien).FirstOrDefault();
            if(nhanVienTonTai == null)
            {
                MessageBox.Show("Không tồn tại nhân viên để cập nhật");
            }
            else
            {
                if (string.IsNullOrEmpty(_detailItem.HoTen))
                {
                    MessageBox.Show("Bạn chưa nhập họ tên");
                    return;
                }
                else
                {
                    SelectItem.HoTen = DetailItem.HoTen;
                }
                if (string.IsNullOrEmpty(_detailItem.DiaChi))
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ");
                }
                else
                {
                    SelectItem.NgaySinh = DetailItem.NgaySinh;
                }
                
                SelectItem.DiaChi = DetailItem.DiaChi;
            }
        }

        #region AddButtonCommand
        public ICommand AddButtonCommand { get => addButtonCommand; set => addButtonCommand = value; }
        public void AddNhanVienCommand(object obj)
        {
            if (_detailItem != null)
            {
                NhanVien nhanVienTonTai = DanhSachNhanVien.Where(x => x.MaNhanVien == _detailItem.MaNhanVien).FirstOrDefault();
                if (nhanVienTonTai != null)
                {
                    MessageBox.Show("Mã số nhân viên: " + nhanVienTonTai.MaNhanVien + " đã tồn tại");
                }
                else
                {
                    if(string.IsNullOrEmpty(_detailItem.MaNhanVien))
                    {
                        MessageBox.Show("Bạn chưa nhập mã nhân viên");
                        return;
                    }
                    if(string.IsNullOrEmpty(_detailItem.HoTen))
                    {
                        MessageBox.Show("Bạn chưa nhập họ tên");
                        return;
                    }
                    if (string.IsNullOrEmpty(_detailItem.DiaChi))
                    {
                        MessageBox.Show("Bạn chưa nhập địa chỉ");
                        return;
                    }
                    DanhSachNhanVien.Add((NhanVien)_detailItem.Clone());
                }
            }
        }
        #endregion

        #region DeleteButtonCommand
        public ICommand DeleteButtonCommand { get => deleteButtonCommand; set => deleteButtonCommand = value; }

        public void DeleteCommand(object obj)
        {
            if(_detailItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xóa!");
                return;
            }
            if (MessageBoxResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Question delete?", MessageBoxButton.YesNo))
            {
                if (_detailItem != null)
                {
                    DanhSachNhanVien.Remove(_selectItem);
                }
            }

        }
        #endregion

        #region CancelButtonCommand
        public ICommand CancelButtonCommand { get => cancelButtonCommand; set => cancelButtonCommand = value; }
        public void CloseCommand(object obj)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Bạn chắc chắn muốn thoát?", "Question close?", MessageBoxButton.YesNo))
            {
                ((Window)obj).Close();
            }
        }
        #endregion
    }
}
