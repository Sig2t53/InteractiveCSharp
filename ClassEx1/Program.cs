using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx1
{
    class ClassEx1
    {
        //フィールドの初期化は必須ではない
        public int MyInt = 25;
        //public int MyInt;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 2つのオブジェクトを作成するデモ ***");
            ClassEx1 obA = new ClassEx1();
            ClassEx1 obB = new ClassEx1();
            Console.WriteLine("obA.i = {0}" ,obA.MyInt);
            Console.WriteLine("obB.i = {0}" ,obB.MyInt);
            Console.ReadKey();
        }
    }
}