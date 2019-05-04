using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx3
{
    interface IMyInterface3A
    {
        void Show3A();
    }

    interface IMyInterface3B
    {
        void Show3B();
    }
    class MyClass3 : IMyInterface3A, IMyInterface3B
    {
        public void Show3A()
        {
            Console.WriteLine("MyClass3.Show3A()が実装されました");
        }

        public void Show3B()
        {
            Console.WriteLine("MyClass3.Show3B()が実装されました");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** インターフェースを研究する例 その3 ***\n");
            MyClass3 myClassOb = new MyClass3();
            myClassOb.Show3A();
            myClassOb.Show3B();
            Console.ReadKey();
        }
    }
}
