using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Library_user : Person
    {
        public int Number_of_ticket { get; set; }
        public DateTime RegDate{get; set; }
        public int MonthPay { get; set; }
        public Library_user(): this (0, new DateTime(1992,1,1),0, "-", "-", new DateTime(1992,1,1)) { }
       public Library_user(int number_of_ticket, DateTime regDate, int monthPay, string firstName, string lastName,DateTime birthday):base(firstName, lastName, birthday)
        {
            Number_of_ticket = number_of_ticket;
            RegDate = regDate;
            MonthPay = monthPay;
        }
            public Library_user(Library_user obj)
        {
            Number_of_ticket = obj.Number_of_ticket;
            RegDate = obj.RegDate;
            MonthPay = obj.MonthPay;
            Firstname = obj.Firstname;
            Lastname = obj.Lastname;
            Birthdate = obj.Birthdate;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер чит. кв.: {Number_of_ticket}");
            Console.WriteLine($"Дата видачі: {RegDate.ToShortDateString()}");
            Console.WriteLine($"Членський внесок: {MonthPay}");
        }
    }
}
