using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingWithMultipleClasses
{
    // C#のメソッドは既定ではvirtualになっていない(Javaはvirtualが既定)
    // C#では親クラスでvirtualを指定したメソッドに、子クラスでoverrideを指定して
    // 意図的に再定義を発生させる
    class Parent
    {
        public void ShowMe()
        {
            Console.WriteLine("Parent.ShowMe その１:引数なし");
        }
        public void ShowMe(int a)
        {
            Console.WriteLine("Parent.ShowMe その２:整数型の引数１つ");
        }
    }
    class Child : Parent
    {
        // 子クラスや派生クラスにおけるオーバーロード型
        public void ShowMe(int a, int b)
        {
            Console.WriteLine("Chld.ShowMe その３:整数型の引数２つ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 複数のクラスにまたがるオーバーロード ***\n");
            Child childOB = new Child();
            //3つのオーバーロード型をすべて呼び出す
            childOB.ShowMe();
            childOB.ShowMe(1);
            childOB.ShowMe(1, 2);
            Console.ReadKey();
        }
    }
}
