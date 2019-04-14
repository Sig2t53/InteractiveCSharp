using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldInitializationOrderEx1
{
    class A
    {
        int x = 10;
        //↓のコメントを外すとエラーになることを確認する
        //int y = x + 2; //エラー
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** C#のフィールド初期化順序を理解する ***");
            int x = 10;
            int y = x + 2; //OK
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
        }
    }
}
