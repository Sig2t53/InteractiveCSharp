using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceError
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("私はParentクラスにいます");
        }
    }

    class Child1 : Parent
    {
        public void Show()
        {
            Console.WriteLine("私はChild-1クラスにいます");
        }
    }

    class Child2 : Parent
    {
        public void Show()
        {
            Console.WriteLine("私はChild-2クラスにいます");
        }
    }

    class GrandChild : Child1,Child2 //菱形継承問題によってエラーとなる
    {
        public void Show()
        {
            Console.WriteLine("私はGrandChildクラスにいます");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
