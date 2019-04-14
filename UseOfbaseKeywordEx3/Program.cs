using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfbaseKeywordEx3
{
    // 親クラスと同名のメソッドを子クラスに実装した場合の動作のサンプル
    // コンパイルも実行もかのうだが、
    //「子クラスのメソッドが継承元の親クラスのメソッドを非表示にする」という警告がでる
    // 親クラスのメソッドを呼び出したい場合は"base.メソッド名"を記述して呼び出す
    class Parent
    {
        public void ShowMe()
        {
            Console.WriteLine("私はParentのメソッドにいます");
        }
    }
    class Child : Parent
    {
        public void ShowMe()
        {
            Console.WriteLine("私はChildのメソッドにいます");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** baseキーワードの使い方の確認例 その3 ***\n\n");
            Child obChild = new Child();
            obChild.ShowMe();
        }
    }
}
