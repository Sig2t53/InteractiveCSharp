using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPropertyEx1
{
    class Shape
    {
        public virtual double Area
        {
            get
            {
                return 0;
            }
        }
    }

    class Circle : Shape
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public int Radius
        {
            get
            {
                return radius;
            }
        }
        public override double Area
        {
            get
            {
                return 3.14 * radius * radius;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** virtualなプロパティのケーススタディ ***");
            Circle myCircle = new Circle(10);
            Console.WriteLine("\n円の半径は{0}単位",myCircle.Radius);
            Console.WriteLine("円の面積は{0}兵法単位",myCircle.Area);
            Console.ReadKey();
        }
    }
}
