using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx4
{
    interface IMyInterface4A
    {
        void Show();
    }
    interface IMyInterface4B
    {
        void Show();
    }

    //↓インターフェースのメソッドを実装する際に、
    //    明示的に実装する場合 : publicをつけていない
    //    暗黙的に実装する場合 : publicが必要
    //  MSDNによれば、
    //    「明示的なインターフェイスメンバを実装する際、
    //      アクセス修飾子もしくは修飾子abstract、virtual、override、static を含めると、
    //      コンパイルエラーとなる」
    //  ため
    class MyClass4 : IMyInterface4A, IMyInterface4B
    {
        public void Show()
        {
            Console.WriteLine("MyClass4.Showが実装されました");
        }
        void IMyInterface4A.Show()
        {
            Console.WriteLine("明示的なインターフェース実装:IMyInterface4A.Show()");
        }
        void IMyInterface4B.Show()
        {
            Console.WriteLine("明示的なインターフェース実装:IMyInterface4B.Show()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** インターフェースを研究する例 その4 ***\n");
            //次の3通りのメソッド呼び出しはうまくいく
            MyClass4 myClassOb = new MyClass4();
            myClassOb.Show();
            IMyInterface4A inter4a = myClassOb;
            inter4a.Show();
            IMyInterface4B inter4b = myClassOb;
            inter4b.Show();
            Console.ReadKey();
        }
    }
}
