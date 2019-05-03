using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentWithConstructorEx1
{
    class MyTestClass
    {
        //↓Constructorに abstract,sealedなどのキーワードはつけられない
        //「修飾子 'abstract' がこの項目に対して有効ではありません。」
        //「修飾子 'sealed' がこの項目に対して有効ではありません。」
        //が発生する
        //
        // ・コンストラクタは上書きできない ⇒ sealedに指定されている  
        //
        // ・コンストラクタを抽象にできないのではなく
        //     - コンストラクタはオブジェクトの初期化を目的としている
        //     - 抽象クラスからはオブジェクトを生成できない
        //   という点から、抽象にしない設計になっている
        public MyTestClass()
        {
            Console.WriteLine("abstractなコンストラクタ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***問題:コンストラクタを用いた実験 ***\n");
            MyTestClass testOb = new MyTestClass();
            Console.ReadKey();
        }
    }
}
