using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEx2
{
    //インターフェースのインデクサには内容を書かない
    // 以下のデモではgetとsetがあるがそれぞれセミコロンをつけるだけ
    // インターフェースのインデクサには修飾子をつけない
    interface IMyInterface
    {
        int this[int index] { get;set; }
    }
    class MyClass : IMyInterface
    {
        //private int[] myIntergerArray;
        private int[] myIntegerArray = new int[4];

        public int this[int index]
        {
            get
            {
                return myIntegerArray[index];
            }
            set
            {
                myIntegerArray[index] = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** インターフェースのインデクサの実験 ***\n");
            MyClass obMyClass = new MyClass();
            // インデクサを用いて0,1,3番目の要素を初期化
            obMyClass[0] = 10;
            obMyClass[1] = 20;
            obMyClass[3] = 30;
            for(int i = 0; i < 4; i++)
            {
                //Console.WriteLine("\t obMyClass[{0}] = {1}",i ,obMyClass[i]);
                Console.WriteLine("{0}番目の要素は{1}"  ,i ,obMyClass[i]);
            }
            Console.ReadKey();
        }
    }
}
