using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsEx2
{
    class ConsEx2
    {
        int i;
        public ConsEx2(int i)
        {
            this.i = i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***コンストラクタを使った実験***");
            ConsEx2 ob2 = new ConsEx2();
        }
    }
}
