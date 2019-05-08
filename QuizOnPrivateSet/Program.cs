using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOnPrivateSet
{
    class MyClass
    {
        private double radius = 10;
        public double Radius
        {
            get
            {
                return radius;
            }
            private set
            {
                radius = value;
            }
        }
        public double Area => 3.14 * radius * radius;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** プロパティの問題 ***");
            MyClass ob = new MyClass();
            // ↓setがprivateに設定されているため
            //  エラー「 set アクセサーにアクセスできないため、プロパティまたはインデクサー 'MyClass.Radius' はこのコンテキストでは使用できません。」
            //  が発生する
            // ob.Radius = 5;
            Console.WriteLine("円の半径は{0}単位",ob.Radius);
            Console.WriteLine("円の面積は{0}平方単位",ob.Area);
            Console.ReadKey();
        }
    }
}
