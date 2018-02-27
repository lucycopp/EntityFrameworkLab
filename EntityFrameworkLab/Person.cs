using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLab
{
    public class Person
    {
        public int PersonID { get; set; }
        public string First_Name { get; set; }
        public int Age { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public Address Address { get; set; }
        public Person() { }
    }
}
