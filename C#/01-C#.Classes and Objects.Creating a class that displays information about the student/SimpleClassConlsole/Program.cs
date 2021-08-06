using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleClassLibrary;

namespace SimpleClassConlsole
{
    class Program
    {

        public static int SortEntrantByCompMark(Entrant a, Entrant b)
        {
            double CompA = a.GetCompMark(), CompB = b.GetCompMark();
            if (CompA > CompB)
                return -1;
            if (CompA < CompB)
                return 1;
            return 0;
        }
        static void PrintEntrants(Entrant[] entrant)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  №|      Прізвище|  Ідентифікаційний код| Підготовчі курси| Бал атестату|  Предмет №1| Оцінка №1|  Предмет №2| Оцінка №2|  Предмет №3| Оцінка №3| Предмет №4|Оцінка №4");
            for (int i = 0; i < entrant.Length; i++)
            {

                Console.Write($"{i + 1,3}|{entrant[i].Name,14}|{entrant[i].IdNum,22}|{entrant[i].CoursePoints,17}|{entrant[i].AvgPoints,13}|");
                for (int j = 0; j < entrant[i].ZNOResults.Length; j++)
                {

                    Console.Write($"{entrant[i].ZNOResults[j].Subject,12}|{entrant[i].ZNOResults[j].Points,10}|");
                }
                Console.Write("\n");
            }
        }
        static void PrintEntrant(Entrant entrant)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|      Прізвище|  Ідентифікаційний код| Підготовчі курси| Бал атестату|  Предмет №1| Оцінка №1|  Предмет №2| Оцінка №2|  Предмет №3| Оцінка №3| Предмет №4|Оцінка №4");
            Console.Write($"|{entrant.Name,14}|{entrant.IdNum,22}|{entrant.CoursePoints,17}|{entrant.AvgPoints,13}|");
            for (int j = 0; j < entrant.ZNOResults.Length; j++)
            {

                Console.Write($"{entrant.ZNOResults[j].Subject,12}|{entrant.ZNOResults[j].Points,10}|");
            }

        }
        static void PrintEntrantBudgets(Entrant[] entrant, int n)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|      Прізвище| плата за місяць| за рік | за весь період навчання ");
            for (int i = 0; i < entrant.Length; i++)
            {
                Console.Write($"|{entrant[i].Name,14}|{entrant[i].budgetmonth}|{entrant[i].budgetyear,8}|{entrant[i].budgetall,14} |");
                Console.Write("\n");
            }
        }
        static Entrant[] ReadEntrantsArray(int n)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            string name, idnum;
            bool flag = false;
            double course_points, avg_points;
            Entrant[] entrants = new Entrant[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введіть прізвище та ініціали:");
                name = Console.ReadLine();
                Console.WriteLine("Введіть індентифікаційний код:");
                idnum = Console.ReadLine();
                Console.WriteLine("Введіть бали за підготовчі курси:");
                do
                {
                    if (double.TryParse(Console.ReadLine(), out course_points))
                        flag = false;
                    else
                    {
                        Console.WriteLine(" Помилка введення балу за підготовчі курси. Будь-ласка введіть повторно!");
                        flag = true;
                    }
                } while (flag);
                Console.WriteLine("Введіть бал атестату:");
                do
                {
                    if (double.TryParse(Console.ReadLine(), out avg_points) && avg_points > 0 && avg_points <= 12)
                        flag = false;
                    else
                    {
                        Console.WriteLine(" Помилка введення балу атестату. Будь-ласка введіть повторно!");
                        flag = true;
                    }
                } while (flag);
                Console.WriteLine("Введіть кількість предметів:");
                int subject_numb;
                do
                {
                    if (int.TryParse(Console.ReadLine(), out subject_numb) && subject_numb <= 4 && subject_numb > 0)
                        flag = false;
                    else
                    {
                        Console.WriteLine(" Помилка введення кількості предметів. Будь-ласка введіть повторно!");
                        flag = true;
                    }
                } while (flag);
                ZNO[] subjects = new ZNO[subject_numb];
                for (int j = 0; j < subjects.Length; j++)
                {
                    Console.WriteLine("Введіть назву предмета:");
                    string subject = Console.ReadLine();
                    double points;
                    Console.WriteLine("Кількість балів:");
                    do
                    {
                        if (double.TryParse(Console.ReadLine(), out points) && points > 0 && points <= 200)
                            flag = false;
                        else
                        {
                            Console.WriteLine(" Помилка введення кількості балів. Будь-ласка введіть повторно!");
                            flag = true;
                        }
                    } while (flag);

                    subjects[j] = new ZNO(subject, points);
                }
                int budget;

                int choice;
                do
                {
                    Console.WriteLine("Оберіть параметр для оплати навчання\n 1. за місяць \n2.за рік(у році оплачується 10 місяців); \n3.за весь період навчання(за весь період навчання оплачується 40 місяців).");
                   
                        if (int.TryParse(Console.ReadLine(), out choice) && choice <= 3 && choice > 0)
                        flag = false;
                    else
                    {
                        Console.WriteLine(" Помилка вибору. Будь-ласка введіть повторно!");
                        flag = true;
                    }
                } while (flag);
                do
                {
                    Console.WriteLine("Вартість оплати навчання :");
                    if (int.TryParse(Console.ReadLine(), out budget) && budget > 0)
                        flag = false;
                    else
                    {
                        Console.WriteLine(" Помилка вартості оплати навчання. Будь-ласка введіть повторно!");
                        flag = true;
                    }
                } while (flag);
                entrants[i] = new Entrant(name, idnum, course_points, avg_points, subject_numb, budget, choice);
                entrants[i].ZNOResults = subjects;
                entrants[i].BudgetAll(choice);
                Console.Clear();
            }
            return entrants;
        }
        static void GetEntrantsInfo(Entrant[] arr, out double x, out double y)
        {
            double min = double.MaxValue, max = double.MinValue;
            double k, j;
            for (int i = 0; i < arr.Length; i++)
            {
                k = arr[i].GetCompMark();
                if (k > max)
                    max = k;
                if (k < min)
                    min = k;
            }
            if (arr[0].GetCompMark() > max)
                max = arr[0].GetCompMark();
            if (arr[0].GetCompMark() < min)
                min = arr[0].GetCompMark();
            x = min;
            y = max;
        }
        static void Main(string[] args)
        {
            Console.Title = "Лабораторна робота #5";
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            bool flag1 = true;
            Console.WriteLine("Введіть кількість записів: ");
            int n;
            do
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    flag1 = false;
                else
                {
                    Console.WriteLine(" Помилка введення кількості предметів. Будь-ласка введіть повторно!");
                    flag1 = true;
                }
            } while (flag1);
            bool flag = true;
            Entrant[] arr = new Entrant[n];
            do
            {
                Console.WriteLine(" \nМеню:\n 1 - Ввести дані\n 2 - Найкращий предмет абітурієнта\n 3 - Найгірший предмет абітурієнта\n 4 - Конкурсний бал абітурієнта\n 5 - Вивести на екран список абітурієнтів\n 6 - Вивести на екран абітурієнта\n 7 - Найвищий конкурсний бал серед всіх\n 8 - Сортування за спаданням конкурсного бала абітурієнта\n 9 - Сортування за прізвищем\n 10 Вивести бюджет кожного з абітурієнтів \n- Завершити роботу\n");
                Console.WriteLine("Виберіть з меню: ");
                int k = int.Parse(Console.ReadLine());
                if (k == 0)
                    flag = false;
                switch (k)
                {
                    case 1:
                        Console.Clear();
                        arr = ReadEntrantsArray(n);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введіть номер абітурієнта:");
                        int l = int.Parse(Console.ReadLine());
                        string str = arr[l - 1].GetBestSubject();
                        Console.WriteLine($"Найкращий предмет: {str}");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введіть номер абітурієнта:");
                        int l_2 = int.Parse(Console.ReadLine());
                        string str_2 = arr[l_2 - 1].GetWorstSubject();
                        Console.WriteLine($"Найгірший предмет: {str_2}");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Введіть номер абітурієнта:");
                        int z = int.Parse(Console.ReadLine());
                        double v = arr[z - 1].GetCompMark();
                        if (v != 0)
                            Console.WriteLine($"Конкурсний бал: {v}");
                        else
                            Console.WriteLine("Недостатньо предметів");
                        break;
                    case 5:
                        Console.Clear();
                        PrintEntrants(arr);
                        break;
                    case 6:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Введіть номер абітурієнта:");
                        int p = int.Parse(Console.ReadLine());
                        PrintEntrant(arr[p - 1]);
                        break;
                    case 7:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                        double x, y;
                        GetEntrantsInfo(arr, out x, out y);
                        Console.WriteLine($"Найвищий конкурсний бал: {y}\nНайнищий конкурсний бал: {x}");
                        break;
                    case 8:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Array.Sort(arr, SortEntrantByCompMark);
                        PrintEntrants(arr);
                        break;
                    case 9:
                        Console.Clear();
                        Array.Sort(arr,
                            (c, m) =>
                            {
                                int resLastName = c.Name.CompareTo(m.Name);
                                int resComp = c.GetCompMark().CompareTo(m.GetCompMark());
                                if (resLastName == 0)
                                    return resComp;
                                return resLastName;
                            }
                            );
                        PrintEntrants(arr);
                        break;
                    case 10:
                        PrintEntrantBudgets(arr, n);
                        break;
                }
            } while (flag);
        }
    }
}
