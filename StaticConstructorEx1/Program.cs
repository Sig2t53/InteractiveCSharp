using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorEx1
{
    class A
    {
        // 静的コンストラクタは下記のいづれかの状況で呼び出される。
        //   1.型のインスタンスが生成される前
        //   2.プログラムの中で静的メンバを参照するとき

        static int staticCount = 0;
        static int instanceCount = 0;
        static A()
        {
            staticCount++;
            Console.WriteLine("静的コンストラクタ Count={0}",staticCount);
        }

        public A()
        {
            instanceCount++;
            Console.WriteLine("インスタンスコンストラクタ Count={0}", instanceCount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** コンストラクタの実験 ***");
            A obA = new A(); // staticCount=1,instanceCount=1
            A obB = new A(); // staticCount=1,instanceCount=2
            A obC = new A(); // staticCount=1,instanceCount=3
            Console.ReadKey();
        }
    }
}
