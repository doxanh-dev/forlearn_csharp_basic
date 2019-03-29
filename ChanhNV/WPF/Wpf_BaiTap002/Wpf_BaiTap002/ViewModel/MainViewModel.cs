using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf_BaiTap002.Model;

namespace Wpf_BaiTap002.ViewModel
{
    class MainViewModel
    {
        private SinhVien _selectedItem;
        private SinhVien _detailItem;
        private SinhVien _selectedSinhVienSieuCup;

        private ICommand addButtonCommand;
        private ICommand editButtonCommand;
        private ICommand saveButtonCommand;
        private ICommand cancelButtonCommand;
        private ICommand deleteButtonCommand;

        private bool isEdit = true;
        private bool canExecute = true;

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public ObservableCollection<SinhVien> DanhSachSinhVienChuyen
        {
            get;
            set;
        }

        public ObservableCollection<SinhVien> DanhSachSinhVienSieuCup
        {
            get;
            set;
        }

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

        public void LoadDanhSachSinhVien()
        {
            ObservableCollection<SinhVien> sinhVienChuyens = new ObservableCollection<SinhVien>();
            sinhVienChuyens.Add(new SinhVien { SoBaoDanh = 1, HoTen = "Nguyen Van A", DiemBai01 = 10, DiemBai02 = 10, DiemBai03 = 10, DiemTiengAnh=10 });
            sinhVienChuyens.Add(new SinhVien { SoBaoDanh = 2, HoTen = "Nguyen Van B", DiemBai01 = 9, DiemBai02 = 8, DiemBai03 = 9, DiemTiengAnh = 10 });
            sinhVienChuyens.Add(new SinhVien { SoBaoDanh = 3, HoTen = "Nguyen Van C", DiemBai01 = 10, DiemBai02 = 9, DiemBai03 = 9, DiemTiengAnh = 10 });
            sinhVienChuyens.Add(new SinhVien { SoBaoDanh = 4, HoTen = "Nguyen Van D", DiemBai01 = 9, DiemBai02 = 9, DiemBai03 = 10, DiemTiengAnh = 10 });
            sinhVienChuyens.Add(new SinhVien { SoBaoDanh = 5, HoTen = "Nguyen Van E", DiemBai01 = 9, DiemBai02 = 10, DiemBai03 = 10, DiemTiengAnh = 10 });
            DanhSachSinhVienChuyen = sinhVienChuyens;

            ObservableCollection<SinhVien> sinhVienSieuCups = new ObservableCollection<SinhVien>();
            sinhVienSieuCups.Add(new SinhVien { SoBaoDanh = 6, HoTen = "Nguyen Van F", DiemBai01 = 10, DiemBai02 = 10, DiemBai03 = 10, DiemCSDL = 10 });
            sinhVienSieuCups.Add(new SinhVien { SoBaoDanh = 7, HoTen = "Nguyen Van H", DiemBai01 = 9, DiemBai02 = 8, DiemBai03 = 9, DiemCSDL = 10 });
            sinhVienSieuCups.Add(new SinhVien { SoBaoDanh = 8, HoTen = "Nguyen Van I", DiemBai01 = 10, DiemBai02 = 9, DiemBai03 = 9, DiemCSDL = 10 });
            sinhVienSieuCups.Add(new SinhVien { SoBaoDanh = 9, HoTen = "Nguyen Van K", DiemBai01 = 9, DiemBai02 = 9, DiemBai03 = 10, DiemCSDL = 10 });
            sinhVienSieuCups.Add(new SinhVien { SoBaoDanh = 10, HoTen = "Nguyen Van L", DiemBai01 = 9, DiemBai02 = 10, DiemBai03 = 10, DiemCSDL = 10 });
            DanhSachSinhVienSieuCup = sinhVienSieuCups;
        }

        public MainViewModel()
        {
            //addButtonCommand = new RelayCommand.RelayCommand(ShowFormAddCommand, param => this.canExecute);
            //editButtonCommand = new RelayCommand.RelayCommand(ShowFormEditCommand, param => this.canExecute);
            deleteButtonCommand = new RelayCommand.RelayCommand(DeleteCommand, param => this.canExecute);
            //saveButtonCommand = new RelayCommand.RelayCommand(SaveCommand, param => this.canExecute);
            cancelButtonCommand = new RelayCommand.RelayCommand(CloseCommand, param => this.canExecute);
        }

        public void CloseCommand(object obj)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Do you want close window?", "Question close?", MessageBoxButton.YesNo))
            {
                ((Window)obj).Close();
            }
        }

        public ICommand CancelButtonCommand { get => cancelButtonCommand; set => cancelButtonCommand = value; }
        public ICommand DeleteButtonCommand { get => deleteButtonCommand; set => deleteButtonCommand = value; }

        public SinhVien SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if (_selectedItem != value)
                {
                    NotifyPropertyChanging("selectedItem");
                    _selectedItem = value;
                    NotifyPropertyChanged("selectedItem");
                }
            }
        }

        public SinhVien SelectedSinhVienSieuCup
        {
            get
            {
                return _selectedSinhVienSieuCup;
            }
            set
            {
                if (_selectedSinhVienSieuCup != value)
                {
                    NotifyPropertyChanging("selectedSinhVienSieuCup");
                    _selectedSinhVienSieuCup = value;
                    NotifyPropertyChanged("selectedSinhVienSieuCup");
                }
            }
        }

        public void DeleteCommand(object obj)
        {
            if(_selectedItem == null && _selectedSinhVienSieuCup == null)
            {
                MessageBox.Show("Please choose record for edit!");
                return;
            }
            if(MessageBoxResult.Yes == MessageBox.Show("Do you want delete record?", "Question delete?", MessageBoxButton.YesNo))
            {
                if(_selectedItem != null)
                {
                    DanhSachSinhVienChuyen.Remove(_selectedItem);
                    _selectedItem = null;
                }
                if(_selectedSinhVienSieuCup !=null)
                {
                    DanhSachSinhVienSieuCup.Remove(_selectedSinhVienSieuCup);
                }
            }
        }





    }
}
