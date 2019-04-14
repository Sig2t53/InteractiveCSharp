using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMainEx
{
    class Program
    {
        // 本ソースコードはコンパイル・実行はできるが、
        // 「Program.Main(int)' で間違った認証が使われています。エントリ ポイントとして使用することはできません。」
        // という警告が出力される

        static void Main(string[] args)
        {
            Console.WriteLine("*** Main()のオーバーロードのテスト ***");
            Console.WriteLine("Main(string[] args)の中にいます");
            Console.WriteLine("オーバーロードされたMainを呼び出しています");
            Main(5);
            Console.WriteLine("*** メソッドオーバーロードの考え方 ***\n\n");
            Console.ReadKey();
        }
        static void Main(int a)
        {
            Console.WriteLine("Main(int a)の中にいます");
        }

        // ↓は追加するとエラーになる
        //   プログラムのエントリポイントにはMain()またはMain(string[] args)を使うことができるが
        //   両方が存在するとコンパイラがどちらを使うか判断できなくなるため。
        //static void Main()
        //{
        //    Console.WriteLine("Main()の中にいます。");
        //}
    }
}
