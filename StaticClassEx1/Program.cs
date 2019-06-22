using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassEx1
{
    class Program
    {
        static class Rectangle
        {
            public static double Area(double len ,double bre)
            {
                return len * bre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*** クラス変数の例　その１ ***\n");
            double length = 25;
            double breadth = 10;
            Console.WriteLine("長方形の面積は{0}平方単位",Rectangle.Area(length,breadth));
            Console.ReadKey();
        }
    }
}
