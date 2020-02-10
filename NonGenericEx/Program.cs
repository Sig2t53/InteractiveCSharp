using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericEx
{
    class NonGenericEx
    {
        public int ShowInteger(int i)
        {
            return 1;
        }
        public string ShowString(string s1)
        {
            return s1;
        }
        public double ShowDouble(double d)
        {
            return d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**ジェネリックを使わないプログラム**");
            NonGenericEx nonGenericOb = new NonGenericEx();
            Console.WriteLine("ShowIntegerの戻り値は{0}",nonGenericOb.ShowInteger(25));
            Console.WriteLine("ShowStringの戻り値は{0}",nonGenericOb.ShowString("ジェネリックではないメソッドが呼ばれました"));
            Console.WriteLine("ShowDoubleの戻り値は{0}", nonGenericOb.ShowDouble(100.5)); 
            Console.ReadKey();
        }
    }
}
