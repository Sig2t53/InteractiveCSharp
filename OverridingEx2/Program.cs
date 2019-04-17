using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEx2
{
    // リスト4-11:怪しいコード
    // ⇒ エラー:オーバーライドされたメンバーに対応するために戻り値の型は 'int' でなければなりません。	
    //     修正案①:子クラスの該当メソッドの戻り値をintに変える
    // 
    //     修正案②:voidの戻り値の型を持つメソッドに変える
    //              この形ではメソッドのオーバーロードとして扱われる
    //
    //class ParentClass
    //{
    //    public virtual int ShowMe(int i)
    //    {
    //        Console.WriteLine("私はParentクラスの中にいます");
    //        return i;
    //    }
    //}
    //class ChildClass : ParentClass
    //{
    //    public override void ShowMe(int i)
    //    {
    //        Console.WriteLine("私はChildクラスの中にいます");
    //    }
    //}

    class ParentClass
    {
        public virtual int ShowMe(int i)
        {
            Console.WriteLine("私はParentClassの中にいます");
            return i;
        }
    }
    class ChildClass : ParentClass
    {
        public override int ShowMe(int i)
        {
            Console.WriteLine("私はChildClassの中にいます");
            Console.WriteLine("iを5増やします");
            return i + 5; //戻り値はintでなければならない
        }
        public void ShowMe()
        {
            Console.WriteLine("Child.ShowMeメソッドの中にいます");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** オーバーロードとオーバーライドを併用するデモ ***\n\n");
            ChildClass childOb = new ChildClass();
            Console.WriteLine(childOb.ShowMe(5)); // 10
            childOb.ShowMe();
            Console.ReadKey();
        }
    }
}
