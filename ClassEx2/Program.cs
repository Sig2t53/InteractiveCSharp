using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx2
{
    class ClassA
    {
        public int i;
        public ClassA(int i)
        {
            this.i = i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***２つのオブジェクトを作成するデモ***");
            ClassA obA = new ClassA(10);
            ClassA obB = new ClassA(20);
            Console.WriteLine("obA.i =" + obA.i);
            Console.WriteLine("obB.i =" + obB.i);
            Console.ReadKey();
        }
    }
}
