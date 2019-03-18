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
using System.Windows.Shapes;

namespace Wpf_BaiTap002
{
    /// <summary>
    /// Interaction logic for ThemThiSinh.xaml
    /// </summary>
    public partial class ThemThiSinh : Window
    {
        ThiSinh thiSinh = new ThiSinh();
        public ThemThiSinh()
        {
            InitializeComponent();
        }
    }
}
