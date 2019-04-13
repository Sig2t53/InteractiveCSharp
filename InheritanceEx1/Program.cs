using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx1
{
    class ParentClass
    {
        public void ShowParent()
        {
            Console.WriteLine("親クラスの内容");
        }
    }
    class ChildClass : ParentClass
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 継承のテスト ***\n\n");
            ChildClass child1 = new ChildClass();
            //ChildClassオブジェクトを通じてShowParent()を呼び出す
            child1.ShowParent();
            Console.ReadKey();
        }
    }
}
