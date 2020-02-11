using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MyStoreHouse<T>
    {
        T[] myStore = new T[3];
        int position = 0;
        public MyStoreHouse()
        {
            for(int i = 0; i < myStore.Length;i++)
            {
                myStore[i] = default(T);
            }
        }
        public void AddToStore(T value)
        {
            if (position >= myStore.Length)
            {
                Console.WriteLine("保管場所はもう一杯です");
                return;
            }

            myStore[position] = value;
            position++;
        }

        public void RetrieveFromStore()
        {
            foreach(T t in myStore)
            {
                Console.WriteLine(t);
            }
            //以下の書き方でも可
            //for(int i = 0;i < myStore.Length;i++)
            //{
            //    Console.WriteLine(myStore[i]);
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ジェネリックプログラムでキーワードdefaultを用いる事例 ***");
            Console.WriteLine("*** 変数の保管場所を作成 ***");
            MyStoreHouse<int> intStore = new MyStoreHouse<int>();
            intStore.AddToStore(45);
            intStore.AddToStore(75);
            Console.WriteLine("*** 今の整数保管場所の状況 ***");
            intStore.RetrieveFromStore();

            Console.WriteLine("*** 文字列の保管場所を作成 ***");
            MyStoreHouse<string> strStore = new MyStoreHouse<string>();
            strStore.AddToStore("abc");
            strStore.AddToStore("def");
            strStore.AddToStore("ghi");
            strStore.AddToStore("jkl"); // 保管場所はもう一杯です
            Console.WriteLine("*** 今の文字列の保管場所の状況 ***");
            strStore.RetrieveFromStore();
            Console.ReadKey();
        }
    }
}
