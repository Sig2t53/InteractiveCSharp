using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesEx1
{
    //•MyIntプロパティを使ってプライベートフィールドmyIntの値の取得や設定が自由に行える。
    //•プロパティは読みやすく理解しやすいように命名する
    // このサンプルではprivate なフィールドの名前の先頭文字を対応する大文字に置き換えるルールとした
    // (myIntのm⇒Mに変更)
    //•プログラムの中に書かれているvalueはプロパティが持つ暗黙のパラメータで値を設定する際に使う
    //•publicなプロパティによって公開されているデータを格納するprivate なフィールドを
    // バッキングストア(backing store)やバッキングフィールド(backing field)と呼ぶことがある
    // この例ではmyInt がprivate なバッキングフィールド
    //•プロパティでは、以下の修飾子が使用可能
    //    public
    //    private
    //    internal
    //    protected
    //    new
    //    virtual
    //    abstract
    //    override
    //    sealed
    //    static
    //    unsafe
    //    extern
    class MyClass
    {
        private int myInt;
        public int MyInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }

        private int restrictedInt;
        public int RestrictedInt
        {
            get
            {
                return restrictedInt;
            }
            set
            {
                if((value >= 10) && (value < 25))
                {
                    restrictedInt = value;
                }
                else
                {
                    Console.WriteLine("新しい値value{0}を設定できません",value);
                    Console.WriteLine("10から25の間の値を選んでください。");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** プロパティの実験例 その1 ***\n");
            MyClass ob = new MyClass();
            //新しい値の設定
            //↓myIntはprivateが指定されているためアクセスできないので
            //  「'MyClass.myInt' はアクセスできない保護レベルになっています」
            //  が発生する
            //ob.myInt = 10; 
            ob.MyInt = 10;
            //値の読み取り
            Console.WriteLine("\nmyIntの値は{0}",ob.MyInt);
            //MyIntを用いてmyIntに別の値を設定
            ob.MyInt = 100;
            Console.WriteLine("myIntの新しい値は{0}",ob.MyInt);
            
            //制限付きの値を使った例
            ob.RestrictedInt = 10;
            Console.WriteLine("myIntの値は{0}", ob.RestrictedInt);
            ob.RestrictedInt = 100;
            Console.WriteLine("myIntの新しい値は{0}", ob.RestrictedInt);

            Console.ReadKey();
        }
    }
}
