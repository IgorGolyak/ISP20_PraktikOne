using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZlatoPOLSKI
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.14 в
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = Math.Pow(a, 2);
            Console.WriteLine("Ответ" + a2);
            //1.14 ж
            Console.WriteLine("Введите число");
            double b = Convert.ToDouble(Console.ReadLine());
            double b2 = -7.5*Math.Pow(b, 2);
            Console.WriteLine("Ответ" + b2);
            //1.14 м
            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y");
            double y = Convert.ToDouble(Console.ReadLine());
            double xy = -5 * Math.Sqrt(x + Math.Sqrt(y));
            Console.WriteLine("Ответ" + xy);
            



        }
    }
}
