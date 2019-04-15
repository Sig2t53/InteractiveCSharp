using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingEx
{
    class Rectangle
    {
        public double length, breadth;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public double AreaOfRectangle()
        {
            return length * breadth;
        }
        public static Rectangle operator ++ (Rectangle rect)
        {
            rect.length++;
            rect.breadth++;
            return rect;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("*** 演算子のオーバーロードのデモ。" + "++演算子をオーバーロード***\n");
            Rectangle rect = new Rectangle(5,7);
            Console.WriteLine("長さは{0}ユニット、幅は{1}ユニット", rect.length,rect.breadth);
            Console.WriteLine("長方形の面積は{0}平方ユニット",rect.AreaOfRectangle());
            rect++;
            Console.WriteLine("修正された長さは{0}ユニット、幅は{1}ユニット",rect.length, rect.breadth);
            Console.WriteLine("新しい長方形の面積は{0}平方ユニット",rect.AreaOfRectangle());
            Console.ReadKey();
        }
    }
}
// 下記の単項演算子はオーバーロード可能
// +,-,!,~,++,--,true,false
//
// 下記の二項演算子はオーバーロード可能
// +,-,*,/,%,&,|,~,<<,>>
//
// 下記の比較演算子はオーバーロード可能
// ==,!=,<,>,<=,>=
//
// 下記の条件論理演算子はオーバーロード不可
// ただし、&,|はオーバーロードできるので、それらの評価には使われる
// &&,||
//
// 下記の配列のインデックス記述演算子はオーバーロード不可
// ただし、インデクサは定義できる
// []
//
// キャスト演算子はオーバーロード不可
// (T)x
//
// 下記の代入演算子はオーバーロード不可
// ただし、+はオーバーロードできるので、それを用いて+=;などの評価は可能
// +=,-=,*=,/=,%=,&=,|=,~=,<<=,>>=
//
// これらの演算子はオーバーロード不可
// =..,?:,??,->,=>,f(x),as,checked,unchecked,default,delegate,is,new,sizeof,typeof

