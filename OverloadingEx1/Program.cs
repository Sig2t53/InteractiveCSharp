using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingEx1
{
    class OverloadEx1
    {
        public int Add(int x,int y)
        {
            return x + y;
        }

        public double Add(double x,double y)
        {
            return x + y;
        }

        public string Add(string s1, string s2)
        {
            return string.Concat(s1,s2);

        }
    }

    class OverloadEx1_List4_2
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Add(int x, int y,int z)
        {
            return x + y + z;
        }
    }


    // ↓誤ったオーバーロードの例 戻り値の型はメソッドシグネチャの一部とはみなされない
    //class OverloadEx1_List4_3
    //{
    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //
    //    public double Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** メソッドのオーバーロードという考え方 ***");
            OverloadEx1 ob = new OverloadEx1();
            Console.WriteLine("2+3={0}",ob.Add(2,3));
            Console.WriteLine("20.5+30.7={0}",ob.Add(20.5, 30.7));
            Console.WriteLine("Amit + Bose={0}",ob.Add("Amit","Bose"));
            Console.ReadKey();
        }
    }
}
