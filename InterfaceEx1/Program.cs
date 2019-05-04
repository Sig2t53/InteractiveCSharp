using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx1
{
    interface IMyInterface
    {
        void Show();
    }

    class MyClass : IMyInterface
    {
        //インターフェースの実装においてメソッドシグネチャは一致している必要がある
        public void Show()
        {
            Console.WriteLine("MyClass.Show()を実装しました");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** インターフェースを研究する例 その1 ***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.Show();
            Console.ReadKey();
        }
    }
}
