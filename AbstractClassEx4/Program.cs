using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx4
{
    abstract class MyAbstractClass
    {
        public abstract void InCompleteMethod1();
        public abstract void InCompleteMethod2();
    }

    // InCompleteMethod1は実装したが、InCompleteMethod2は実装していないため、
    // classにabstractキーワードがついていないと
    // 「'ChildAbstractClass' は継承抽象メンバー 'MyAbstractClass.InCompleteMethod2()' を実装しません。	」
    // が発生する
    //
    // 補足:メソッドにabstractとsealedの両方を指定することはできない(相反する制約のため)
    abstract class ChildAbstractClass : MyAbstractClass
    {
        public override void InCompleteMethod1()
        {
            Console.WriteLine("InCompleteMethod1を完成させようとしています");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 抽象クラスを継承した結果、未実装が残る場合 ***\n");
            Console.ReadKey();
        }
    }
}
