using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(2, 3);
            Console.WriteLine($"{a + b}");
            Console.WriteLine($"{a - b}");
            Console.WriteLine($"{a * b}");
            Console.WriteLine($"{b/a}");
            Console.WriteLine($"{+a}"); a = new Fraction(1, 2);
            Console.WriteLine($"{-a}"); a = new Fraction(1, 2);
            Console.WriteLine($"{++a}"); a = new Fraction(1, 2);
            Console.WriteLine($"{--a}"); a = new Fraction(1, 2); 
            Console.WriteLine($"{a>b}");
            Console.WriteLine($"{a < b}");
            Console.WriteLine($"{a >= b}");
            Console.WriteLine($"{a <= b}");
            Console.WriteLine(a);

        }
    }


}
