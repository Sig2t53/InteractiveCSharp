using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsEx1
{
    class NonStaticClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("非静的クラスの静的メソッド");
        }
        public void NonStaticMethod()
        {
            Console.WriteLine("非静的クラスの非静的(インスタンス)メソッド");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 静的メソッドの実装例 その１ ***\n");
            NonStaticClass anObject = new NonStaticClass();
            anObject.NonStaticMethod();
            //anObject.StaticMethod(); //エラー CS0176  インスタンス参照でメンバー 'NonStaticClass.StaticMethod()' にアクセスできません。代わりに型名を使用してください
            NonStaticClass.StaticMethod();
            Console.ReadKey();
        }
    }
}
