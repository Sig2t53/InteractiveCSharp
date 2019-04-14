using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfbaseKeywordEx2
{
    // 言語仕様で、基本クラスへのアクセスは
    //   - コンストラクタ内部
    //   - インスタンスメソッド内部
    //   - インスタンスプロパティへのアクセス時
    // にのみ許可される。
    // 静的メソッドの中でbaseキーワードを使った処理はできない。
    class Parent
    {
        public void ParentMethod()
        {
            Console.WriteLine("私はParenetのメソッドにいます。");
        }
    }
    class Child : Parent
    {
        public void ChildMethod()
        {
            Console.WriteLine("私はChildのメソッドにいます");
            Console.WriteLine("今 Parentのメソッドを呼び出しています。");
            base.ParentMethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** baseキーワードの使い方の確認例 その2 ***\n");
            Child obChild = new Child();
            obChild.ChildMethod();
            Console.ReadKey();
        }
    }
}
