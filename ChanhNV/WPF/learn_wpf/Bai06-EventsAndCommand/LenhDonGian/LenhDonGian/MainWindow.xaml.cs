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

namespace LenhDonGian
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

        private void DeleteCustomer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = lsbCustomers.SelectedItem != null;
        }

        private void DeleteCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            lsbCustomers.Items.Remove(lsbCustomers.SelectedItem);
        }

        private void DeleteProduct_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = lsbProducts.SelectedItem != null;
        }
        private void DeleteProduct_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            lsbProducts.Items.Remove(lsbProducts.SelectedItem);
        }
    }
}
