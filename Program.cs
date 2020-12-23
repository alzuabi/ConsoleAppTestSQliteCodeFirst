using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                var person = new Person() { Name = "TestJohn" };
                //WriteToFile("Person");
                db.Persons.Add(person);
                //WriteToFile("Person");
                db.SaveChanges();
            }
        }
    }
}
