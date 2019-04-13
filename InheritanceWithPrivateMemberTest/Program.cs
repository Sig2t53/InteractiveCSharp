using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithPrivateMemberTest
{
    class A
    {
        private int a;
    }
    class B : A { }

    class Program
    {
        static void Main(string[] args)
        {
            B obB = new B();
            A obA = new A();
            ////これはaも継承されている証拠を示すものです。エラーメッセージを見てください
            //Console.WriteLine(obB.a);
            //// 「A.aはアクセスできない保護レベル」というメッセージが出る
            //Console.WriteLine(obB.b);
            //// 「Bにbの定義が含まれておらず…」というメッセージが出る
            //Console.WriteLine(obA.b);
            //// 「Aにbの定義が含まれておらず…」というメッセージが出る
        }
    }
}
