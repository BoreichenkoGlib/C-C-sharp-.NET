using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student:Person
    {
        public byte Course;
        public string Group;
        public string Faculty;
        public string Institution_Name;
        public Student(): this(1,"","","","","",new DateTime(1992, 1, 1)) { }
public Student(byte course, string group, string faculty, string institution_Name, string firstName, string lastName,DateTime birthday) : base(firstName, lastName,birthday)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            Institution_Name = institution_Name;
        }
        public Student(Student obj)
        {
            Course = obj.Course;
            Group = obj.Group;
            Faculty = obj.Faculty;
            Institution_Name = obj.Institution_Name;
            Firstname = obj.Firstname;
            Birthdate = obj.Birthdate;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"Група: {Group}");
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Назва навч. закладу: {Institution_Name}");
        }
        public Student(string faculty,string institution_Name, string firstName, string lastName, DateTime birthday): this(1, "-", faculty, institution_Name, firstName,lastName, birthday)
        { }
           
    }
}
