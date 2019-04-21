using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismEx5
{
    // メソッドのオーバーライドの禁止のサンプル
    // GrandChildClassのShowClassNameのコメントを外すと
    // 「'GrandChildClass.ShowClassName()': 継承されたメンバー 'ChildClass.ShowClassName()' はシールドされているため、オーバーライドできません。」が発生する
    class ParentClass
    {
        public virtual void ShowClassName()
        {
            Console.WriteLine("Parent.ShowClassNameの中にいます");
        }
    }

    class ChildClass : ParentClass
    {
        sealed public override void ShowClassName()
        {
            Console.WriteLine("ChildClass.ShowClassNameの中にいます");
        }
    }

    class GrandChildClass : ChildClass
    {
        //public override void ShowClassName()
        //{
        //    Console.WriteLine("GrandChildClass.ShowClassNameの中にいます");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
