using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceMethodDemo
{
    class Ex5
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***整数値を返すメソッドを１つ持つ簡単なクラス***\n\n");
            Ex5 ob = new Ex5();
            int result = ob.Sum(57, 63);
            Console.WriteLine("57と63の和は : " + result);
            Console.ReadKey();
        }
    }
}
