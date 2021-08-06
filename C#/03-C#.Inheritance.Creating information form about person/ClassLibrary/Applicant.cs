using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Applicant : Person
    {
        public Dictionary<string, int> Marks_ZNO { get; set; }
        public int Mark { get; set; }
        public string Educ_name { get; set; }

        public Applicant() : this(null, 0,  "-", "-", "-", new DateTime(1992, 1, 1)) { }


        public Applicant(Dictionary<string, int> marks_ZNO, int mark, string educ_name, string firstname, string lastname, DateTime birthdate) : base(firstname, lastname, birthdate)
        {
            Marks_ZNO = marks_ZNO;
            Mark = mark;
            Educ_name = educ_name;
        }
        public Applicant(Dictionary<string, int> marks_ZNO, int mark, string firstname, string lastname, DateTime birthdate) : this(marks_ZNO, mark, "-", firstname, lastname, birthdate)
        {
        }
            public Applicant(Applicant obj)
        {
            Marks_ZNO = new Dictionary<string, int>(obj.Marks_ZNO);
            Mark = obj.Mark;
            Educ_name = obj.Educ_name;
            Firstname = obj.Firstname;
            Lastname = obj.Lastname;
            Birthdate = obj.Birthdate;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            foreach (var zno in Marks_ZNO)
                //Console.WriteLine($"Предмет: {Ma}")
                Console.WriteLine($"Середній бал: {Mark}");
            Console.WriteLine($"Назва закладу: {Educ_name}");
        }

    }
}
