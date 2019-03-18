using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateDonGian
{
    public class Person
    {
        public Person(string name, string imageRef)
        {
            this.Name = name;
            this.ImageRef = imageRef;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _imageRef;
        public string ImageRef
        {
            get { return _imageRef; }
            set { _imageRef = value; }
        }
    }
}
