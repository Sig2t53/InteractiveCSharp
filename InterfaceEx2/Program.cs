using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx2
{
    interface IMyInterface
    {
        void Show1();
        void Show2();
    }


    // MyClassはインターフェース;IMyInterfaceのShow2メソッドを実装していないので抽象クラスになる
    abstract class MyClass : IMyInterface
    {
        public void Show1()
        {
            Console.WriteLine("MyClass.Show1()が実装されている");
        }

        abstract public void Show2();
    }

    class ChildClass : MyClass
    {
        public override void Show2()
        {
            Console.WriteLine("ChildClass.Show2()を実装したので完璧");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** インターフェースを研究する例 その2 ***\n");
            // MyClassは抽象クラス
            // MyClass myClassOb = new MyClass();
            MyClass myOb = new ChildClass();
            myOb.Show1();
            myOb.Show2();
            Console.ReadKey();
        }
    }
}
