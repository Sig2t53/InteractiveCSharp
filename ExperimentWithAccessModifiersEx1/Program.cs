using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentWithAccessModifiersEx1
{
    abstract class IncompleteClass
    {
        public abstract void ShowMe();
    }

    class CompleteClass : IncompleteClass
    {
        // 親クラスがpublicなので↓をpublicからprotectedを指定すると
        //「'CompleteClass.ShowMe()': 'public' の継承メンバー 'IncompleteClass.ShowMe()' をオーバーライドするときに、アクセス修飾子を変更できません。」
        // が発生する
        // 親子ともにprotectedを指定した場合はmainでエラーになる。(protectedは実際に定義されたクラスと、その子クラスのインスタンスしか使用できない)
        public override void ShowMe()
        {
            Console.WriteLine("私は完全です");
            Console.WriteLine("私はShowMe()のメソッド本体を記述するものです");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 問題:アクセス修飾子の実験 ***\n");
            IncompleteClass myRef = new CompleteClass();
            myRef.ShowMe();
            Console.ReadKey();
        }
    }
}
