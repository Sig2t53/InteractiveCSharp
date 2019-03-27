using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx4
{
    class ClassA
    {
        public int i;
        public ClassA()
        {
            this.i = 5;
        }
        public ClassA(int i)
        {
            this.i = i;
        }
    }
    class ClassEx4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ２つの異なるコンストラクタを持つ単純なクラスのデモ ***");
            ClassA obA = new ClassA();
            ClassA obB = new ClassA(75);
            Console.WriteLine("obA.i =" + obA.i);
            Console.WriteLine("obB.i =" + obB.i);
            Console.ReadKey();
        }
    }
}
