using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Wpf_BaiTap002.Model;
using Wpf_BaiTap002.View;

namespace Wpf_BaiTap002.ViewModel
{
    class MainViewModel
    {
        private ThiSinh _detailItem;
        private ThiSinh _selectedSinhVienSieuCup;
        private ThiSinh _selectedSinhVienChuyen;

        private ICommand addButtonCommand;
        private ICommand editButtonCommand;
        private ICommand saveButtonCommand;
        private ICommand cancelButtonCommand;
        private ICommand deleteButtonCommand;

        private bool isEdit = true;
        private bool canExecute = true;

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public ObservableCollection<ThiSinh> DanhSachThiSinhChuyen
        {
            get;
            set;
        }

        public ObservableCollection<ThiSinh> DanhSachThiSinhSieuCup
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

        public ThiSinh DetailItem
        {
            get => _detailItem;
            set
            {
                NotifyPropertyChanging("DetailItem");
                _detailItem = value;
                NotifyPropertyChanged("DetailItem");
            }
        }

        public void LoadDanhSachSinhVien()
        {
            ObservableCollection<ThiSinh> thiSinhChuyens = new ObservableCollection<ThiSinh>();
            thiSinhChuyens.Add(new ThiSinh { SoBaoDanh = 1, HoTen = "Nguyen Van A", DiemBai01 = 10, DiemBai02 = 10, DiemBai03 = 10, DiemTiengAnh = 10, ThiSinhChuyen = true });
            thiSinhChuyens.Add(new ThiSinh { SoBaoDanh = 2, HoTen = "Nguyen Van B", DiemBai01 = 9, DiemBai02 = 8, DiemBai03 = 9, DiemTiengAnh = 10, ThiSinhChuyen = true });
            thiSinhChuyens.Add(new ThiSinh { SoBaoDanh = 3, HoTen = "Nguyen Van C", DiemBai01 = 10, DiemBai02 = 9, DiemBai03 = 9, DiemTiengAnh = 10, ThiSinhChuyen = true });
            thiSinhChuyens.Add(new ThiSinh { SoBaoDanh = 4, HoTen = "Nguyen Van D", DiemBai01 = 9, DiemBai02 = 9, DiemBai03 = 10, DiemTiengAnh = 10, ThiSinhChuyen = true });
            thiSinhChuyens.Add(new ThiSinh { SoBaoDanh = 5, HoTen = "Nguyen Van E", DiemBai01 = 9, DiemBai02 = 10, DiemBai03 = 10, DiemTiengAnh = 10, ThiSinhChuyen = true });
            DanhSachThiSinhChuyen = thiSinhChuyens;

            ObservableCollection<ThiSinh> thiSinhSieuCups = new ObservableCollection<ThiSinh>();
            thiSinhSieuCups.Add(new ThiSinh { SoBaoDanh = 6, HoTen = "Nguyen Van F", DiemBai01 = 10, DiemBai02 = 10, DiemBai03 = 10, DiemCSDL = 10, ThiSinhSieuCup = true });
            thiSinhSieuCups.Add(new ThiSinh { SoBaoDanh = 7, HoTen = "Nguyen Van H", DiemBai01 = 9, DiemBai02 = 8, DiemBai03 = 9, DiemCSDL = 10, ThiSinhSieuCup = true });
            thiSinhSieuCups.Add(new ThiSinh { SoBaoDanh = 8, HoTen = "Nguyen Van I", DiemBai01 = 10, DiemBai02 = 9, DiemBai03 = 9, DiemCSDL = 10, ThiSinhSieuCup = true });
            thiSinhSieuCups.Add(new ThiSinh { SoBaoDanh = 9, HoTen = "Nguyen Van K", DiemBai01 = 9, DiemBai02 = 9, DiemBai03 = 10, DiemCSDL = 10, ThiSinhSieuCup = true });
            thiSinhSieuCups.Add(new ThiSinh { SoBaoDanh = 10, HoTen = "Nguyen Van L", DiemBai01 = 9, DiemBai02 = 10, DiemBai03 = 10, DiemCSDL = 10, ThiSinhSieuCup = true });
            DanhSachThiSinhSieuCup = thiSinhSieuCups;
        }

        public MainViewModel()
        {
            addButtonCommand = new RelayCommand.RelayCommand(ShowFormAddCommand, param => this.canExecute);
            editButtonCommand = new RelayCommand.RelayCommand(ShowFormEditCommand, param => this.canExecute);
            deleteButtonCommand = new RelayCommand.RelayCommand(DeleteCommand, param => this.canExecute);
            saveButtonCommand = new RelayCommand.RelayCommand(SaveCommand, param => this.canExecute);
            cancelButtonCommand = new RelayCommand.RelayCommand(CloseCommand, param => this.canExecute);
        }

        #region EditButtonCommand
        public ICommand EditButtonCommand { get => editButtonCommand; set => editButtonCommand = value; }
        public void ShowFormEditCommand(object obj)
        {
            ChiTietSinhVien chiTietSinhVien;
            if (_selectedSinhVienChuyen != null)
            {
                chiTietSinhVien = new ChiTietSinhVien();
                chiTietSinhVien.textBlockTitle.Text = "Cập Nhật Thí Sinh";
                _detailItem = new ThiSinh
                {
                    SoBaoDanh = _selectedSinhVienChuyen.SoBaoDanh,
                    HoTen = _selectedSinhVienChuyen.HoTen,
                    DiemBai01 = _selectedSinhVienChuyen.DiemBai01,
                    DiemBai02 = _selectedSinhVienChuyen.DiemBai02,
                    DiemBai03 = _selectedSinhVienChuyen.DiemBai03,
                    DiemCSDL = _selectedSinhVienChuyen.DiemCSDL,
                    DiemTiengAnh = _selectedSinhVienChuyen.DiemTiengAnh,
                    TongDiem = _selectedSinhVienChuyen.TongDiem,
                    ThiSinhChuyen = _selectedSinhVienChuyen.ThiSinhChuyen,
                    ThiSinhSieuCup = _selectedSinhVienChuyen.ThiSinhSieuCup,
                };
                chiTietSinhVien.DataContext = this;
                isEdit = true;
                chiTietSinhVien.Show();
            }
            else if (_selectedSinhVienSieuCup != null)
            {
                chiTietSinhVien = new ChiTietSinhVien();
                chiTietSinhVien.textBlockTitle.Text = "Cập Nhật Thí Sinh";
                _detailItem = new ThiSinh
                {
                    SoBaoDanh = _selectedSinhVienSieuCup.SoBaoDanh,
                    HoTen = _selectedSinhVienSieuCup.HoTen,
                    DiemBai01 = _selectedSinhVienSieuCup.DiemBai01,
                    DiemBai02 = _selectedSinhVienSieuCup.DiemBai02,
                    DiemBai03 = _selectedSinhVienSieuCup.DiemBai03,
                    DiemCSDL = _selectedSinhVienSieuCup.DiemCSDL,
                    DiemTiengAnh = _selectedSinhVienSieuCup.DiemTiengAnh,
                    TongDiem = _selectedSinhVienSieuCup.TongDiem,
                    ThiSinhChuyen = _selectedSinhVienSieuCup.ThiSinhChuyen,
                    ThiSinhSieuCup = _selectedSinhVienSieuCup.ThiSinhSieuCup,
                };
                chiTietSinhVien.DataContext = this;
                isEdit = true;
                chiTietSinhVien.Show();
            }
            else
            {
                MessageBox.Show("Please choose record for edit!");
            }
        }
        #endregion

        #region AddButtonCommand
        public ICommand AddButtonCommand { get => addButtonCommand; set => addButtonCommand = value; }
        public void ShowFormAddCommand(object obj)
        {
            ChiTietSinhVien chiTietSinhVien = new ChiTietSinhVien();
            _detailItem = new ThiSinh();
            chiTietSinhVien.DataContext = this;
            isEdit = false;
            chiTietSinhVien.Show();
        }
        #endregion

        #region SaveButtonCommand
        public ICommand SaveButtonCommand { get => saveButtonCommand; set => saveButtonCommand = value; }

        public void SaveCommand(object obj)
        {
            if (isEdit)
            {
                if (_selectedSinhVienChuyen != null)
                {
                    _selectedSinhVienChuyen.SoBaoDanh = _detailItem.SoBaoDanh;
                    _selectedSinhVienChuyen.HoTen = _detailItem.HoTen;
                    _selectedSinhVienChuyen.DiemBai01 = _detailItem.DiemBai01;
                    _selectedSinhVienChuyen.DiemBai02 = _detailItem.DiemBai02;
                    _selectedSinhVienChuyen.DiemBai03 = _detailItem.DiemBai03;
                    _selectedSinhVienChuyen.DiemCSDL = _detailItem.DiemCSDL;
                    _selectedSinhVienChuyen.DiemTiengAnh = _detailItem.DiemTiengAnh;
                    _selectedSinhVienChuyen.TongDiem = _detailItem.TongDiem;
                    _selectedSinhVienChuyen = null;
                }
                if (_selectedSinhVienSieuCup != null)
                {
                    _selectedSinhVienSieuCup.SoBaoDanh = _detailItem.SoBaoDanh;
                    _selectedSinhVienSieuCup.HoTen = _detailItem.HoTen;
                    _selectedSinhVienSieuCup.DiemBai01 = _detailItem.DiemBai01;
                    _selectedSinhVienSieuCup.DiemBai02 = _detailItem.DiemBai02;
                    _selectedSinhVienSieuCup.DiemBai03 = _detailItem.DiemBai03;
                    _selectedSinhVienSieuCup.DiemCSDL = _detailItem.DiemCSDL;
                    _selectedSinhVienSieuCup.DiemTiengAnh = _detailItem.DiemTiengAnh;
                    _selectedSinhVienSieuCup.TongDiem = _detailItem.TongDiem;

                    _selectedSinhVienSieuCup = null;
                }
            }
            else
            {
                ThiSinh sinhVienChuyen = DanhSachThiSinhChuyen.Where(x => x.SoBaoDanh == _detailItem.SoBaoDanh).FirstOrDefault();
                ThiSinh sinhVienSieuCup = DanhSachThiSinhSieuCup.Where(x => x.SoBaoDanh == _detailItem.SoBaoDanh).FirstOrDefault();

                if (sinhVienChuyen == null && sinhVienSieuCup == null)
                {
                    if (_detailItem.ThiSinhChuyen)
                    {
                        if (_detailItem.SoBaoDanh == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Số báo danh");
                            return;
                        }
                        if (string.IsNullOrEmpty(_detailItem.HoTen))
                        {
                            MessageBox.Show("Bạn chưa nhập họ tên");
                            return;
                        }
                        if (_detailItem.DiemBai01 == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm bài 01");
                            return;
                        }
                        if (_detailItem.DiemBai02 == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm bài 02");
                            return;
                        }
                        if (_detailItem.DiemBai03 == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm bài 03");
                            return;
                        }
                        if (_detailItem.DiemTiengAnh == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm tiếng anh");
                            return;
                        }

                        _detailItem.DiemCSDL = 0;
                        DanhSachThiSinhChuyen.Add(_detailItem);
                        _detailItem = null;
                    }
                    else if (_detailItem.ThiSinhSieuCup)
                    {
                        if (_detailItem.SoBaoDanh == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Số báo danh");
                            return;
                        }
                        if (string.IsNullOrEmpty(_detailItem.HoTen))
                        {
                            MessageBox.Show("Bạn chưa nhập họ tên");
                            return;
                        }
                        if (_detailItem.DiemBai01 == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm bài 01");
                            return;
                        }
                        if (_detailItem.DiemBai02 == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm bài 02");
                            return;
                        }
                        if (_detailItem.DiemBai03 == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm bài 03");
                            return;
                        }
                        if (_detailItem.DiemCSDL == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Điểm cở sở dữ liệu");
                            return;
                        }
                        _detailItem.DiemTiengAnh = 0;
                        DanhSachThiSinhSieuCup.Add(_detailItem);
                        _detailItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Ban không thêm sinh viên nào!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Sinh vien đã tồn tại!");
                    return;
                }
            }
            ((Window)obj).Close();
        }
        #endregion

        #region CancelButtonCommand
        public ICommand CancelButtonCommand { get => cancelButtonCommand; set => cancelButtonCommand = value; }
        public void CloseCommand(object obj)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Do you want close window?", "Question close?", MessageBoxButton.YesNo))
            {
                if (_selectedSinhVienChuyen != null)
                {
                    _selectedSinhVienChuyen = null;
                }
                if (_selectedSinhVienSieuCup != null)
                {
                    _selectedSinhVienSieuCup = null;
                }
                ((Window)obj).Close();
            }
        }
        #endregion

        #region DeleteButtonCommand
        public ICommand DeleteButtonCommand { get => deleteButtonCommand; set => deleteButtonCommand = value; }

        public void DeleteCommand(object obj)
        {
            if (_selectedSinhVienChuyen == null && _selectedSinhVienSieuCup == null)
            {
                MessageBox.Show("Please choose record for edit!");
                return;
            }
            if (MessageBoxResult.Yes == MessageBox.Show("Do you want delete record?", "Question delete?", MessageBoxButton.YesNo))
            {
                if (_selectedSinhVienChuyen != null)
                {
                    DanhSachThiSinhChuyen.Remove(_selectedSinhVienChuyen);
                    _selectedSinhVienChuyen = null;
                }
                if (_selectedSinhVienSieuCup != null)
                {
                    DanhSachThiSinhSieuCup.Remove(_selectedSinhVienSieuCup);
                    _selectedSinhVienSieuCup = null;
                }
            }
        }
        #endregion

        #region SelectedSinhVienChuyen
        public ThiSinh SelectedSinhVienChuyen
        {
            get
            {
                return _selectedSinhVienChuyen;
            }
            set
            {
                if (_selectedSinhVienChuyen != value)
                {
                    NotifyPropertyChanging("selectedSinhVienChuyen");
                    _selectedSinhVienChuyen = value;
                    NotifyPropertyChanged("selectedSinhVienChuyen");
                }
            }
        }
        #endregion

        #region SelectedSinhVienSieuCup
        public ThiSinh SelectedSinhVienSieuCup
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
        #endregion
    }
}
