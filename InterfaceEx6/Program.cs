using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx6
{
    interface Interface6
    {
        void ShowInterface6();
    }

    class MyClass6 : Interface6
    {
        void Interface6.ShowInterface6()
        {
            Console.WriteLine("ShowInterface6が実装されました");
        }
    }


    // クラスとインターフェースを同時に継承することも可能
    // ※クラスは1つのみ
    // 記載するときはクラス、インターフェースの順で記述することを勧める
    interface Interface6A
    {
        void ShowInterface6();
    }

    class MyChildClass : MyClass6, Interface6A
    {
        void Interface6A.ShowInterface6()
        {
            Console.WriteLine("Interface6A.ShowInterface6()を呼び出しています"); ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass6 myClassOb = new MyClass6();
            myClassOb = new MyClass6();
            //MyClass6で明示的にInterface6.ShowInterface6を実装しているため、
            //↓を有効にするとコンパイルエラー
            // 「'MyClass6' に 'ShowInterface6' の定義が含まれておらず、
            //   型 'MyClass6' の最初の引数を受け付けるアクセス可能な拡張メソッド
            //  'ShowInterface6' が見つかりませんでした。
            //   using ディレクティブまたはアセンブリ参照が不足していないかを確認してください。」
            //が発生する
            //言語仕様で明示的に実装されたインターフェースのメンバにアクセスするには、
            //インターフェース型の変数を使って呼び出すことになっているため
            // myClassOb.ShowInterface6();

            //インターフェース型の変数を使って呼び出す例
            Interface6 ob6 = myClassOb;
            ob6.ShowInterface6();

            //キャストしても同様の結果が得られる
            ((Interface6)myClassOb).ShowInterface6();

            //明示的なインターフェースメソッドの実装が
            //  明示的なインターフェイスの真価
            //    2 つ以上の異なるインターフェイスに
            //    同じメソッドシグニチャがあるときに発揮される
            //  必要となるケース
            //    シグニチャは同じでも、目的が異なるような場合
            //    具体的には
            //      - ITriangle とIRectangle の2つのインターフェイスの両方に、
            //        同じシグネチャを持つメソッドBuildMe() が含まれている
            //      - ITriangle.BuildMe() …三角形を生成する
            //      - IRectangle.BuildMe()…四角形を生成する
            //    というような場合、
            //    状況に基づいて適切なBuildMe() メソッドを呼び出せるように、
            //    インターフェイス名を含めて記しておく

            MyChildClass childOb   = new MyChildClass();
            Interface6A ob6A = childOb;
            ob6A.ShowInterface6();
            Interface6 if6Ob = childOb;
            if6Ob.ShowInterface6();

            Console.ReadKey();
        }
    }
}
