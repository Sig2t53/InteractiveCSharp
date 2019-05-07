using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOnPrivateSetProperty
{
    //プロパティに使用可能な修飾子の例
    //   継承演算子                             : abstract,virtual,override,new,sealed
    //   すべてのアクセス修飾子                 : public,private,protected,internal
    //   静的であることを示す修飾子             : static
    //   管理されていないことを示すコード修飾子 : unsafe,extern
    abstract class Shape
    {
        public abstract double Area
        {
            get;
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

    class MyClass
    {
        private double radius = 10;
        public double Radius => radius;
        public double Area => 3.14 * radius * radius;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** プロパティの問題 ***");
            MyClass ob = new MyClass();
            Console.WriteLine("円の面積は{0}平方単位",ob.Area);

            Circle circle = new Circle(10);
            Console.WriteLine("抽象プロパティで実装");
            Console.WriteLine("円の半径は{0}",circle.Radius);
            Console.WriteLine("円の面積は{0}",circle.Area);

            Console.ReadKey();
        }
    }
}
