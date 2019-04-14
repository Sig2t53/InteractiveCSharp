using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfbaseKeywordEx1
{
    class Parent
    {
        private int a;
        private int b;
        public Parent(int a, int b)
        {
            Console.WriteLine("私はParentのコンストラクタにいます。");
            Console.WriteLine("インスタンス変数のaとbの値を設定");
            this.a = a;
            this.b = b;
            Console.WriteLine("a={0}", this.a);
            Console.WriteLine("b={0}", this.b);
        }
    }

    class Child : Parent
    {
        private int c;
        public Child(int a, int b, int c) : base(a,b)
        {
            Console.WriteLine("私はChildのコンストラクタにいます。");
            Console.WriteLine("インスタンス変数cの値を設定");
            this.c = c;
            Console.WriteLine("c={0}",this.c);
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** baseキーワードの使い方の確認例 その1 ***\n\n");
            Child obChild = new Child(1, 2, 3);
            // Console.WriteLine("a in ObB2={0}",obChild.a);
            // aはprivateなのでChild.aにはアクセスできない
            Console.ReadKey();
        }
    }
}
