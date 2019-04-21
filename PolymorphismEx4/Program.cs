using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismEx4
{

    // 子クラスによる継承の禁止のサンプル
    // ChildClassのコメントを外すと
    // 「'ChildClass': シールド型 'ParentClass' から派生することはできません。」が発生する
    sealed class ParentClass
    {
        public void ShowClassName()
        {
            Console.WriteLine("Parent.ShowClassNameの中にいます");
        }
    }

    //class ChildClass : ParentClass
    //{
    //    //何かのコード
    //}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
