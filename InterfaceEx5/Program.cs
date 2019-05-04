using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx5
{
    interface Interface5A
    {
        void ShowInterface5A();
    }

    interface Interface5B
    {
        void ShowInterface5B();
    }

    interface Interface5C : Interface5A,Interface5B
    {
        void ShowInterface5C();
    }

    class MyClass5 : Interface5C
    {
        public void ShowInterface5A()
        {
            Console.WriteLine("ShowInterface5A()が実装されました");
        }

        public void ShowInterface5B()
        {
            Console.WriteLine("ShowInterface5B()が実装されました");
        }

        public void ShowInterface5C()
        {
            Console.WriteLine("ShowInterface5C()が実装されました");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** インターフェースを研究する例 その5 ***");
            Console.WriteLine("*** インターフェースで多重継承をする考え方 ***\n");
            MyClass5 myClassOb = new MyClass5();
            Interface5A ob5A = myClassOb;
            ob5A.ShowInterface5A();
            Interface5B ob5B = myClassOb;
            ob5B.ShowInterface5B();
            Interface5C ob5C = myClassOb;
            ob5C.ShowInterface5C();
            Console.ReadKey();
        }
    }
}
