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

namespace LenhTuTao
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

        #region DeleteCustomer_CanExecute
        private void DeleteCustomer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = lsbCustomers.SelectedItem != null;
        }
        #endregion

        #region DeleteCustomer_Executed
        private void DeleteCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            lsbCustomers.Items.Remove(lsbCustomers.SelectedItem);
        }
        #endregion

        #region DeleteProduct_CanExecute
        private void DeleteProduct_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = lsbProducts.SelectedItem != null;
        }
        #endregion

        #region DeleteProduct_Executed
        private void DeleteProduct_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            lsbProducts.Items.Remove(lsbProducts.SelectedItem);
        }
        #endregion

        #region InsertCustomer_CanExecute
        private void InsertCustomer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        #endregion

        #region InsertCustomer_Executed
        private void InsertCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = "New Customer";
            lsbCustomers.Items.Add(item);
        }
        #endregion
    }
}
