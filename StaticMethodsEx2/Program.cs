using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsEx2
{
    class NonStaticClass
    {
        static int myStaticVariable = 25; // 静的変数
        int myInstanceVariable = 50; // インスタンス変数

        //静的メソッド
        public static void StaticMethod()
        {
            Console.WriteLine("非静的クラスの静的メソッド");
            Console.WriteLine("myStaticValue={0}",myStaticVariable);
            //Console.WriteLine("StaticMethod->Instance Variable={0}",myInstanceVariable); //エラー CS0120  静的でないフィールド、メソッド、またはプロパティ 'NonStaticClass.myInstanceVariable' で、オブジェクト参照が必要です
        }
        public void NonStaticMethod()
        {
            Console.WriteLine("非静的クラスのインスタンスメソッド");
            Console.WriteLine("NonStaticMethod->static variable={0}",myStaticVariable );
            //Console.WriteLine("myStaticVariable={0}", this.myStaticVariable);//エラー CS0176  インスタンス参照でメンバー 'NonStaticClass.myStaticVariable' にアクセスできません。代わりに型名を使用してください
            Console.WriteLine("myInstanceVariable={0}",myInstanceVariable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***静的メソッドの実装例 その2 ***\n");
            NonStaticClass anObject = new NonStaticClass();
            anObject.NonStaticMethod();
            //anObject.StaticMethod(); //エラー CS0176  インスタンス参照でメンバー 'NonStaticClass.StaticMethod()' にアクセスできません。代わりに型名を使用してください
            NonStaticClass.StaticMethod();
            Console.ReadKey();
        }
    }
}
