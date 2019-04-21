using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOnSealedEx1
{
    //Class2はClass1の直接の子クラスではないため、問題が発生しない
    //同様に同じ親クラスから派生しているのでTestMe()メソッドのオーバーライドも可能
    //
    //※sealedはメンバ変数には適用できない
    //  変更不可にしたいのであれば、readonlyまたはconstを使う
    //  constは定数のように宣言でき、宣言後の変更は不可
    //  readonlyはフィールドの宣言時、およびコンストラクタでの値割り当てが可能
    //  また、定数は暗黙的にstaticになる

    class QuizOnSealed
    {
        public virtual void TestMe()
        {
            Console.WriteLine("私はClass-1にいます");
        }
    }
    class Class1 : QuizOnSealed
    {
        public sealed override void TestMe()
        {
            Console.WriteLine("私はClass-1にいます");
        }
    }
    class Class2 : QuizOnSealed
    {
        public override void TestMe()
        {
            Console.WriteLine("私はClass-2にいます");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** キーワードsealedの使い方に関する問題 ***");
            Class2 obClass2 = new Class2();
            obClass2.TestMe();
            Console.ReadKey();
        }
    }
}
