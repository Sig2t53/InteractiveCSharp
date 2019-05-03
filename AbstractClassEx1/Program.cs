using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEx1
{
    //抽象メソッドを1つでも含むクラスは抽象クラスであることを明記しなくてはならない
    abstract class MyAbstractClass
    {
        public abstract void ShowMe();
    }

    class MyConcreteClass : MyAbstractClass
    {
        public override void ShowMe()
        {
            Console.WriteLine("私は実装のあるクラスから来ました");
            Console.WriteLine("私のShowMe()メソッドの内容は完結しています");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 抽象クラスの例 その1 ***\n");
            //↓ エラー 抽象クラスからはインスタンス作成できない
            //「抽象クラスまたはインターフェイス 'MyAbstractClass' のインスタンスを作成できません。」
            // MyAbstractClass abstractOb = new MyAbstractClass();
            MyConcreteClass concreteOb = new MyConcreteClass();
            concreteOb.ShowMe();
            Console.ReadKey();
        }
    }
}
