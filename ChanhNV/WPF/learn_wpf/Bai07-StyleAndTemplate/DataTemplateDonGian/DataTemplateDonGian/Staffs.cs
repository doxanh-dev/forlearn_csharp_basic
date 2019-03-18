using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateDonGian
{
    public class Staffs
    {
        public List<Person> staffs;

        public IEnumerable<Person> StaffList
        {
            get { return staffs; }
        }

        public Staffs()
        {
            staffs = new List<Person>();
            staffs.Add(new Person("Mary", @"C:/Users/Computer/Desktop/staff/mary.png"));
            staffs.Add(new Person("Johny", @"C:/Users/Computer/Desktop/staff/johny.png"));
            staffs.Add(new Person("Olaf", @"C:/Users/Computer/Desktop/staff/olaf.png"));
            staffs.Add(new Person("Scooby Doo", @"C:/Users/Computer/Desktop/staff/scooby_doo.png"));
        }
    }
}
