using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ジェネリックで実行時エラーを回避 ***");
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add(20);
            myList.Add("invalid");

            // コンパイルエラーはないが、実行時エラーが生じる
            foreach(int myInt in myList)
            {
                Console.WriteLine((int)myInt); //ダウンキャスト
            }
            Console.ReadKey();
        }
    }
}
