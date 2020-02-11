using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyWithDefault
{

    class Program
    {
        static void Main(string[] args)
        {
            //ジェネリックプログラミングではdefaultを使って、ジェネリック型を既定値で初期化する
            // 参照型 → null、
            // 値型   → 各ビットがゼロ
            Console.WriteLine("*** キーワードdefaultのケーススタディ ***");
            Console.WriteLine("default(int)の値は{0}",default(int)); // 0
            bool b1 = (default(int) == null); // false
            Console.WriteLine("default(int)はnullか？答えは{0}",b1);
            Console.WriteLine("default(string)は{0}",default(string));
            bool b2 = (default(string) == null); // true
            Console.WriteLine("default(string)はnullか？答えは{0}", default(string));
            Console.ReadKey();
        }
    }
}
