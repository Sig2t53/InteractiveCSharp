using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassVsA_ClassWithPrivateCons
{
    //メンバ変数にはsealedは適用できない
    //⇒「コンパイルエラー 修飾子 'sealed' がこの項目に対して有効ではありません。」が発生する
    //  変更させたくない場合はreadonlyにする
    //class A
    //{
    //    sealed int a = 5;
    //}
    //Constructorにもsealedは適用できない
    //⇒「コンパイルエラー 修飾子 'sealed' がこの項目に対して有効ではありません。」が発生する
    //   子クラスから親クラスを呼び出せないようにしたいのであればprivateを使う
    //class A
    //{
    //    sealed A()
    //    {
    //
    //    }
    //}

    // 継承を防ぐためにはCase1,2どちらの書き方がよいか
    // ⇒何をしたいのか明確にする。
    //     Case1は少し手を加えれば新しい派生クラスの生成が可能
    //     Case2は派生クラスが作れない
    ////case1
    //class a1
    //{
    //    private a1() { }
    //}
    //
    ////case2
    //sealed class a2
    //{
    //    //何かのコード
    //}
    //
    // 継承を防ぐためにConstructorをprivateにするのは間違い
    // privateを適用したConstructorはstaticなメンバだけを含むクラスで使われる
    // ⇒singletonパターン(追加でのインスタンス化の防止)

    class A1
    {
        public int x;
        private A1() { }
        public A1(int x) { this.x = x; }
    }
    sealed class A2
    {
        // 何かのコード
    }
    class B1 : A1
    {
        public int y;
        public B1(int x,int y):base(x)
        {
            this.y = y;
        }
    }
    //キーワードsealedがついているA2型から子クラスは派生不可
    //↓を有効にするとコンパイルエラー「'B2': シールド型 'A2' から派生することはできません。」が発生する
    //class B2 : A2 { }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ケーススタディ : クラスにsealedをつけるかコンストラクタにprivateをつけるか ***\n");
            B1 obB1 = new B1(2, 3);
            Console.WriteLine("\t x={0}", obB1.x);
            Console.WriteLine("\t x={0}", obB1.y);
            Console.ReadKey();
        }
    }
}
