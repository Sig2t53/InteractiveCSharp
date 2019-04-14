using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCallSequenceTest
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("私はParentのコンストラクタにいます。");
        }
    }

    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("私はChildのコンストラクタにいます。");
        }    
    }

    class GrandChild : Child
    {
        public GrandChild()
        {
            Console.WriteLine("私はGrandChildのコンストラクタにいます。");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** コンストラクタの呼び出す順序をテスト ***");
            GrandChild grandChild = new GrandChild();
            Console.ReadKey();
        }
    }
}
