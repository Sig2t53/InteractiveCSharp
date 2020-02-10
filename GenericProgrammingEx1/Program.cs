using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProgrammingEx1
{
    class MyGenericClass<T>
    {
        public T Show(T value)
        {
            return value;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** ジェネリック入門 **");
            MyGenericClass<int> myGenericClassIntOb = new MyGenericClass<int>();
            Console.WriteLine("Showの戻り値は{0}",myGenericClassIntOb.Show(100));
            MyGenericClass<string> myGenericClassStringOb = new MyGenericClass<string>();
            Console.WriteLine("Showの戻り値は{0}",myGenericClassStringOb.Show("ジェネリックなメソッドが呼ばれました。"));
            MyGenericClass<double> myGenericClassDoubleOb = new MyGenericClass<double>();
            Console.WriteLine("Showの戻り値は{0}",myGenericClassDoubleOb.Show(100.5));
            Console.ReadKey();
        }
    }
}
