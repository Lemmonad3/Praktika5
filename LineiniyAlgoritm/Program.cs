using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineiniyAlgoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите z");
            z = Convert.ToInt32(Console.ReadLine());

            double a = Math.Cos(2) * (x - Math.PI / 6);
            double k = 0.5 + Math.Pow(Math.Sin(y), 2);
            double b = (Math.Pow(z, 2));
            double m = 3 - (Math.Pow(z, 2) / 5);
            double l = 1 + (b / m);
            double t = (a / k) * l;
            string s = t.ToString("f2");
            Console.WriteLine(s); 
            Console.ReadKey();
        }
    }
}
