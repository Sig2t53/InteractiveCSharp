using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx3
{
    abstract class MyabstractClass
    {
        protected int myInt = 25;
        //public abstract void ShowMe();
        public virtual void CompleteMethod1()
        {
            Console.WriteLine("MyabstractClass.CompleteMethod1()");
        }
        public void CompleteMethod2()
        {
            Console.WriteLine("MyabstractClass.CompleteMethod2()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 未実装のない抽象クラスのコンパイル***");
            //↓抽象クラスはインスタンスを生成できない
            //「抽象クラスまたはインターフェイス 'MyabstractClass' のインスタンスを作成できません。」
            // が発生する
            //MyabstractClass abstractOb = new MyabstractClass();
            Console.ReadKey();
        }
    }
}
