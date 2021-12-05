using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_static
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 5, x = 2, y = 2;
            Console.WriteLine("Длина окружности = {0:f}\nПлощадь круга = {1:f}\nТочка в круге: {2}", Cyrcle.Lenght(r), Cyrcle.Square(r), Cyrcle.Conteins(r, x, y));
            Console.ReadKey();
        }
    }
    static class Cyrcle
    {
        public static double Lenght(double r)
        {
            double l = 2 * Math.PI * r;
            return l;
        }
        public static double Square(double r)
        {
            double s = Math.PI * r * r;
            return s;
        }
        public static bool Conteins(double r, double x, double y)
        {
            bool e = (Math.Sqrt((x * x) + (y * y)) <= r) ? true : false;
            return e;
        }
    }
}
