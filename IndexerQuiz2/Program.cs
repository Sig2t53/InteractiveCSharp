using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerQuiz2
{
    interface IMyInterface
    {
        int this[int index] { get;set; }
    }
    class MyClass : IMyInterface
    {
        private int[] myIntegerArray = new int[4];

        // 明示的なインターフェース実装
        //   インデクサの明示的な実装はpublicにもvirtualにもしない⇒オーバーライドできない
        int IMyInterface.this[int index]
        {
            get => myIntegerArray[index];
            set => myIntegerArray[index] = value;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 明示的なインターフェースでインデクサを用いる問題 ***\n");
            MyClass obMyClass = new MyClass();
            IMyInterface interOb = (IMyInterface)obMyClass;

            // 明示的な実装のため、インターフェースのオブジェクトではなく
            // MyClassのオブジェクトであるobMyClassを使うとエラーになる
            // obMyClass[0] = 20;

            // インデクサを用いて、0,1,3番目の要素を初期化
            interOb[0] = 20;
            interOb[1] = 21;
            interOb[3] = 23;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t obMyClass[{0}]={1}",i,interOb[i]);
            }

            Console.ReadKey();
        }
    }
}
