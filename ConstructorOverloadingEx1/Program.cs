using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadingEx1
{
    class ConsOverloadEx
    {
        public ConsOverloadEx()
        {
            Console.WriteLine("引数なしのコンストラクタ");
        }
        public ConsOverloadEx(int a)
        {
            Console.WriteLine("1つの整数の引数をとるコンストラクタ 引数 {0}",a);
        }
        public ConsOverloadEx(int a, double b)
        {
            Console.WriteLine("1個の整数型の引数{0}と1個のdouble型の引数{1}をコンストラクタに渡しました",a,b);
        }
    }

    // ↓Java8では通るがC#のコンパイラでは
    //   エラー「メンバー名をそれを囲む型の名前と同じにすることはできません。」になる
    //class ConsOverloadEx_List_4_5
    //{
    //    public ConsOverloadEx_List_4_5()
    //    {
    //        Console.WriteLine("引数なしのコンストラクタ");
    //    }
    //
    //    public void ConsOverloadEx_List_4_5()
    //    {
    //        Console.WriteLine("メソッド");
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** コンストラクタのオーバーロードのデモ ***");
            ConsOverloadEx ob1 = new ConsOverloadEx();
            ConsOverloadEx ob2 = new ConsOverloadEx(25);
            ConsOverloadEx ob4 = new ConsOverloadEx(10,25.5);
            //ConsOverloadEx ob4 = new ConsOverloadEx(25.5); //エラー
            Console.ReadKey();
        }
    }
}
