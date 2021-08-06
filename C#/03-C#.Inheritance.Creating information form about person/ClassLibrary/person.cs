using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public DateTime Birthdate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Person(string firstname, string lastname, DateTime birthdate)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
        }

        public Person() : this("Ivan", "Ivanov", new DateTime(1992, 1, 1)) { }
        public Person(string firstname, string lastname) : this(firstname, lastname, new DateTime(1992,1,1))
        {
          
        }
        public Person(Person obj)
        {
            Firstname = obj.Firstname;
            Lastname = obj.Lastname;
            Birthdate = obj.Birthdate;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nІм'я:{Firstname}");
            Console.WriteLine($"Прізвище:{Lastname}");
            Console.WriteLine($"Дата народження: {Birthdate.ToShortDateString()}");
        }
    }
    
}
