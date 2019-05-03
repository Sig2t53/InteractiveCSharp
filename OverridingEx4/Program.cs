using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEx4
{
    class ParentClass
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("Parent.ShowMeの中にいます");
        }
    }
    class ChildClass1 : ParentClass
    {
        public override void ShowMe()
        {
            Console.WriteLine("Child1.ShowMeの中にいます");
        }
    }
    class ChildClass2 : ParentClass
    {
        public new void ShowMe()
        {
            Console.WriteLine("Child2.ShowMeの中にいます");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ChildClass2で定義したShowMeはポリモーフィズムに含まれない
            // ChildClass2クラスのオブジェクトを生成してParentClass型の変数に代入しているため、
            // コンパイラがParentClassのメソッドしか見つけることができない。
            // このため、Parent.ShowMeの内容が出力される
            Console.WriteLine("*** メソッドをオーバーライドする際にnewキーワードを用いる例 その2 ***");
            ParentClass parentOb;
            parentOb = new ParentClass();
            parentOb.ShowMe();
            parentOb = new ChildClass1();
            parentOb.ShowMe();
            parentOb = new ChildClass2();
            parentOb.ShowMe();
            Console.ReadKey();

        }
    }
}
