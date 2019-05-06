using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Property
{
    class MyClass
    {
        // フィールドを public にしないで、public のプロパティを使う理由
        // プロパティがオブジェクト指向プログラミングの特徴である、カプセル化を促進するため
        //
        // 読み取り専用プロパティを使う場面はイミュータブル型を作成するとき
        //
        // //読み取り専用プロパティの書き方
        // private int myInt;
        // public int MyInt
        // {
        //     get
        //     {
        //         return myInt;
        //     }
        //     //set アクセサを書かない
        // }
        // //書き込み専用プロパティの書き方
        // private int myInt;
        // public int MyInt
        // {
        //     //get アクセサを書かない
        //     set
        //     {
        //         myInt = value;
        //     }
        // }

        //C#3.0以降は↓のコードが自動プロパティ宣言で記載可能
        //private myInt:
        //public int MyInt
        //{
        //    get
        //    {
        //        return myInt;
        //    }
        //    set
        //    {
        //        myInt = value;
        //    }
        //}

        public int MyInt
        {
            //自動プロパティ宣言
            get;set;
        }

        // プロパティのsetアクセサをprivateに設定すると、プロパティは読み取り専用のように動作する
        // protectedに設定すれば、他の型からは隠すことができる
        int myInt2 = 102;
        public int MyInt2
        {
            get
            {
                return myInt2;
            }
            private set
            {
                myInt2 = value;
            }
        }
    }

    //C#6.0から式形式のプロパティを使用することで、
    //コメントアウトしたMyClss2を下記の形で書き直し可能
    //class MyClass2
    //{
    //    private double radius = 10;
    //    public double Radius
    //    {
    //        get { return radius; }
    //    }
    //}
    class MyClass2
    {
        private double radius = 10;
        public double Radius => radius;
    }

    //C#6.0以降では下記の初期化が可能
    class MyClass3
    {
        public int MyInt
        {
            set; get;
        } = 106; // 自動プロパティ初期化子
    }

    //C#7.0ではMyClassの内容をMyClass4の形式で記載可能
    class MyClass4
    {
        private int myInt;
        public int MyInt
        {
            get => myInt;
            set => myInt = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** プロパティの実装例 その1 ***");

            MyClass ob = new MyClass();
            // 新しい値を設定
            //ob.myInt = 106; // エラー:myIntにはアクセスできない
            ob.MyInt = 106; //正しく106を設定できる
            // 値の読み取り
            Console.WriteLine("\nMyClass.MyIntの値は{0}", ob.MyInt);
            //ob.MyInt2 = 106; //setがprivateに設定されているため、コメントを外すとエラーになる
            Console.WriteLine("\nMyClass.MyInt2の値は{0}", ob.MyInt2);// 値の読み取りは可能

            MyClass2 ob2 = new MyClass2();
            Console.WriteLine("\nMyClass2.Radiusの値は{0}", ob2.Radius);

            MyClass3 ob3 = new MyClass3();
            Console.WriteLine("\nMyClass3.MyIntの値は{0}", ob3.MyInt);

            Console.ReadKey();
        }
    }
}
