using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ジェネリックでランタイムエラーを回避 ***");
            List<int> myGenericList = new List<int>();
            myGenericList.Add(10);
            myGenericList.Add(20);
            // myGenericList.Add("無効");　// コンパイルエラー	CS1503 引数 1: は 'string' から 'int' へ変換することはできません。
            foreach (int myInt in myGenericList)
            {
                Console.WriteLine(myInt);
            }
            Console.ReadKey();
        }
    }
}
