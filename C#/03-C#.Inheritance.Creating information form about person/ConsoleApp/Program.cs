using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choice;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.WriteLine("Додати інформацію про:\n 1. Людину\n 2. Абітурієнта\n 3. Студента\n4. Викладача\n5. Користувача бібліотеки\n 0. Вихід. \n Ваш вибір:");
                choice = Convert.ToByte(Console.ReadLine());
                if (choice > 6)
                    Console.WriteLine("\nСпробуйте ще ");
                else if (choice == 0)
                    return;
                else
                {
                    Person person = CreatePerson();
                    switch (choice)
                    {
                        case 1:
                            person.ShowInfo();
                            break;
                        case 2:
                            Applicant applicant = CreateApplicant(person); applicant.ShowInfo(); break;
                        case 3:
                            Student student = CreateStudent(person); student.ShowInfo(); break;
                        case 4:
                            Teacher teacher = CreateTeacher(person); break;
                        case 5:
                            Library_user library_User = CreateLibrary_user(person);
                            library_User.ShowInfo(); break;
                    }
                    //Console.WriteLine("Натисніть що-небудь");
                    //Console.ReadKey();
                }
            } while (true);
        }

        public static Person CreatePerson()
        {
            Console.WriteLine("Ім'я");
            string firstName = Console.ReadLine();
            Console.WriteLine("Прізвище");
            string lastName = Console.ReadLine();
            Console.WriteLine("Дата народження(У форматі (день).(місяць).(рік.)): ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
          
            return new Person(firstName, lastName, birthday);
        }
        public static Teacher CreateTeacher(Person person)
        {
            Console.WriteLine("Посада");
            string position = Console.ReadLine();
            Console.WriteLine("Кафедра");
            string chair = Console.ReadLine();
            Console.WriteLine("Назва навч. закладу");
            string institution_Name = Console.ReadLine();
            return new Teacher(position, chair, institution_Name, person.Firstname, person.Lastname, person.Birthdate);
        }
        public static Library_user CreateLibrary_user(Person person)
        {
            Console.WriteLine("Номер чит. квитка");
            int number_of_ticket=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Дата реєстр.");
            DateTime regDate= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Плата за місяць");
            int monthPay= Convert.ToInt32(Console.ReadLine());
            return new Library_user(number_of_ticket, regDate, monthPay, person.Firstname, person.Lastname, person.Birthdate);
        }
        static Student CreateStudent(Person person)
        {
            Console.WriteLine("Курс");
            byte course = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Група");
            string group = Console.ReadLine();
            Console.WriteLine("Факультет");
            string faculty = Console.ReadLine();
            Console.WriteLine("Назва навч. закладу");
            string institution_Name = Console.ReadLine();
            return new Student(course, group, faculty, institution_Name, person.Firstname, person.Lastname, person.Birthdate);
        }
        static Applicant CreateApplicant(Person person)
        {
            Console.WriteLine("К-ть предметів");
            int count = Convert.ToInt32(Console.ReadLine());string key; int value;
            Dictionary<string, int> marks_ZNO = new Dictionary<string, int>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Предмет:");
                key = Console.ReadLine();
                Console.WriteLine("Оцінка:");
                value = Convert.ToInt16(Console.ReadLine());
                marks_ZNO.Add(key,value);
            }
            Console.WriteLine("Середній бал документа про освіту:");
            short mark = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Назва навч. закладу:");
            string educ_name = Console.ReadLine();
            return new Applicant(marks_ZNO,mark,educ_name,person.Firstname,person.Lastname,person.Birthdate);
        }

    }
}
