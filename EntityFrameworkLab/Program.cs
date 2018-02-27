using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyContext())
            {
                Address addr = new Address()
                {
                    House_Name_or_Number = "1076",
                    Street =
               "Some Street",
                    City = "Some City",
                    County = "Some County",
                    Postcode = "Some Postcode",
                    Country = "UK",
                    People = new List<Person>()
                };
                Person prsn = new Person()
                {
                    First_Name = "Jane",
                    Last_Name = "Doe",
                    Date_of_Birth = new DateTime(2010, 10, 1),
                    Address = addr,
                    Age = 40
                };
                ctx.Addresses.Add(addr);
                ctx.People.Add(prsn);
                ctx.SaveChanges();
            }

        }
    }
}
