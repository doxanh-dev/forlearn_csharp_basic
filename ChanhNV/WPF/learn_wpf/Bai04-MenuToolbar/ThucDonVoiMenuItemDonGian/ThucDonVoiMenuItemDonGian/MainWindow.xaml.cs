﻿using System;
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

namespace ThucDonVoiMenuItemDonGian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Hàm xử lý sự kiện nhấn Menu "Thực đơn 211"
        private void MenuItem211_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 211");
        }

        //Hàm xử lý sự kiện nhấn Menu "Thực đơn 212"
        private void MenuItem212_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 212");
        }

        //Hàm xử lý sự kiện nhấn Menu "Thực đơn 22"
        private void MenuItem22_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 22");
        }

        //Hàm xử lý sự kiện nhấn Menu "Thực đơn 3"
        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 3");
        }

        //Hàm xử lý sự kiện khi Menu "Thực đơn 23" được đánh dấu chọn
        private void Menu23_Checked(object sender, RoutedEventArgs e)
        {
            this.labelThayDoi.FontWeight = FontWeights.Bold;
        }

        //Hàm xử lý sự kiện khi Menu "Thực đơn 23" được bỏ dấu chọn
        private void Menu23_Unchecked(object sender, RoutedEventArgs e)
        {
            //Thiết lập thuộc tính chữ thường cho textBox1
            this.labelThayDoi.FontWeight = FontWeights.Normal;
        }
    }
}
