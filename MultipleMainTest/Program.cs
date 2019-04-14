using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleMainTest
{
    // 下記のような複数のMainメソッドが存在するとエラーになる(※)が、
    // プロジェクトのプロパティでエントリポイントを指定することでエラーを回避できる。
    // (プロパティを開き、アプリケーション⇒スタートアップオブジェクトで指定する)
    // 
    // ※「プログラムで複数のエントリ ポイントが定義されています。
    //     エントリ ポイントを含む型を指定するには、/main でコンパイルしてください。」
    //   が表示される
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program1.Main()の中にいます");
            Console.ReadKey();
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program2.Main()の中にいます");
            Console.ReadKey();
        }
    }
}
