using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    public class Program
    {
        

        struct edge_t
        {
            public int x, y;
            public int w;               
        }
        static int[] nodes = new int[100];
        static int last_n = 0;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            edge_t[] edges = new edge_t[100];
            int NV;             
            int NE;           
            int i;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("START");
            Console.ResetColor();
            Console.WriteLine("_____________________________");
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Кількість вершин-> ");
            NV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість ребер-> ");
            NE = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.Yellow;

            for (i = 0; i < NV; i++)
            {
                nodes[i] = -1 - i;
            }
            Console.WriteLine("Матриця вершин та ребер:");
            for (i = 0; i < NE; i++)
            {
                Console.Write("x" + (i + 1) + "-> ");
                edges[i].x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y" + (i + 1) + "-> ");
                edges[i].y = Convert.ToInt32(Console.ReadLine());
                Console.Write("w" + (i + 1) + "-> ");
                edges[i].w = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----->");

            }
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Мінімальний шлях: ");
            int sum = 0;
            var sVes = from h in edges orderby h.w select h;
            foreach (var s in sVes)
            {
                for (i = 0; i < NE; i++)
                {
                    int c = getColor(s.y);
                    if (getColor(s.x) != c)
                    {
                        nodes[last_n] = s.y;
                        Console.Write("-> ("+s.x + ";" + s.y+")" + "=" + s.w);
                        Console.WriteLine("");
                        sum += s.w;
                    }
                }
            }
            Console.WriteLine("Мінімальна сума шляхів: "+sum);
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_____________________________");
            //Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("START");
            Console.ReadLine();
        }

        static public int getColor(int n)
        {
            int c;
            if (nodes[n] < 0)
            {
                return nodes[last_n = n];
            }
            c = getColor(nodes[n]);
            nodes[n] = last_n;
            return c;
        }
    }
}