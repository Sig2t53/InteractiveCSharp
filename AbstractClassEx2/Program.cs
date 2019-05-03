using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx2
{
    abstract class MyAbstractClass
    {
        protected int myInt = 25;
        public abstract void ShowMe();
        public virtual void CompleteMethod1()
        {
            Console.WriteLine("MyAbstractClass.CompleteMethod1()");
        }
        public void CompleteMethod2()
        {
            Console.WriteLine("MyAbstractClass.CompleteMethod2()");
        }
    }

    class MyConcreteClass : MyAbstractClass
    {
        public override void ShowMe()
        {
            Console.WriteLine("私は実装のあるクラスから来ました");
            Console.WriteLine("私のShowMeメソッドの内容は完結しています");
            Console.WriteLine("myIntの値は{0}です",myInt);
        }
        public override void CompleteMethod1()
        {
            Console.WriteLine("MyConcreteClass.CompleteMethod1()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 抽象クラスの例 その2 ***\n");
            //↓エラー抽象クラスからインスタンスの作成はできない
            //MyAbstractClass abstractOb = new MyAbstractClass();
            MyConcreteClass concreteOb = new MyConcreteClass();
            concreteOb.ShowMe();
            concreteOb.CompleteMethod1();
            concreteOb.CompleteMethod2();
            Console.WriteLine("\n\n*** 親クラスを介してメソッドを呼んでいます ***\n");
            MyAbstractClass absRef = concreteOb;
            absRef.ShowMe();
            absRef.CompleteMethod1();
            absRef.CompleteMethod2();
            Console.ReadKey();
        }
    }
}
