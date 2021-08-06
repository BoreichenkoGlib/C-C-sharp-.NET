using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher:Person
    {
        public string Position {get; set; }
        public string Chair { get; set; }
        public string Institution_Name { get; set; }

        public Teacher(string position, string chair, string institution_Name, string firstName, string lastName, DateTime birthdate) : base(firstName, lastName, birthdate)
        {
            Position = position;
            Chair = chair;
            Institution_Name = institution_Name;
        }
        public Teacher(string position, string chair,string firstName,string lastName, DateTime birthdate): this(position,chair, "", firstName,lastName,birthdate)
        { }
        public Teacher(Teacher obj)
        {
            Position = obj.Position;
            Chair = obj.Chair;
            Institution_Name = obj.Institution_Name;
            Firstname = obj.Firstname;
            Lastname = obj.Lastname;
            Birthdate = obj.Birthdate;
        }
        public Teacher() :this("","","","", new DateTime(1992,1,1)) {}
        public override void ShowInfo()
        {
            base.ShowInfo();
                Console.WriteLine($"Посада:{Position}");
            Console.WriteLine($"Кафедра:{Chair}");
            Console.WriteLine($"Назва навч. закладу:{Institution_Name}");
        }
    }
}
