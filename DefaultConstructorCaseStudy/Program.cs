using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructorCaseStudy
{
    class DefConsDemo
    {
        public int myInt;
        public float myFloat;
        public double myDouble;
        public DefConsDemo()
        {
            Console.WriteLine("意図的に初期化しています");
            myInt = 10;
            myFloat = 0.123456F;
            myDouble = 9.8765432;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ユーザ定義とC#既定のコンストラクタの比較 ***\n");
            DefConsDemo ObDef = new DefConsDemo();
            Console.WriteLine("myInt={0}",ObDef.myInt);
            Console.WriteLine("myFloat={0}",ObDef.myFloat);
            Console.WriteLine("myDouble={0}", ObDef.myDouble);
            Console.Read();
        }
    }
}