using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivi la lunghezza lato1 del trinagolo...");
            int lato1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Scrivi la lunghezza lato2 del trinagolo...");
            int lato2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Scrivi la lunghezza lato3 del trinagolo...");
            int lato3 = Convert.ToInt16(Console.ReadLine());

            Triangolo triangolo1 = new Triangolo(lato1, lato2, lato3);
            string messaggio = triangolo1.checkTriangolo();
            Console.WriteLine(messaggio);
            Console.ReadLine();

            string messaggio2 = triangolo1.latoPiuLungo();
            Console.WriteLine(messaggio2);
            Console.ReadLine();

        }
    }
}
