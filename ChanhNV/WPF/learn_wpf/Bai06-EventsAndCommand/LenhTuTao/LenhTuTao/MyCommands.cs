using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LenhTuTao
{
    public class MyCommands
    {
        static MyCommands()
        {
            InsertCustomer = new RoutedUICommand(
            "Insert Customer", "InsertCustomer",
            typeof(MyCommands));
        }
        public readonly static RoutedUICommand InsertCustomer;
       
    }
}
