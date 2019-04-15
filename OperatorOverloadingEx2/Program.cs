using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingEx2
{
    class ComplexNumber
    {
        public double real, imaganinary;
        public ComplexNumber()
        {
            this.real = 0;
            this.imaganinary = 0;
        }
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaganinary = imaginary;
        }
        // 二項演算子+をオーバーロード
        //  ※演算子の関数にはpublicとstaticの修飾子が必要
        //    記載がない場合、「ユーザー定義の演算子は static および public として宣言されなければなりません。」というエラーになる
        public static ComplexNumber operator + (ComplexNumber cnumber1,ComplexNumber cnumber2)
        {
            ComplexNumber temp = new ComplexNumber();
            temp.real = cnumber1.real + cnumber2.real;
            temp.imaganinary = cnumber1.imaganinary + cnumber2.imaganinary;
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 演算子のオーバーロードのデモその２ " + "二項演算子+ ***\n");
            ComplexNumber cNumber1 = new ComplexNumber(2.1, 3.2);
            Console.WriteLine("複素数1:{0} + {1}i",cNumber1.real,cNumber1.imaganinary);
            ComplexNumber cNumber2 = new ComplexNumber(1.1, 2.1);
            Console.WriteLine("複素数2:{0} + {1}i", cNumber2.real, cNumber2.imaganinary);
            //複素数(ComplexNumber)に+演算子を適用する
            ComplexNumber cNumber3 = cNumber1 + cNumber2;
            Console.WriteLine("+演算子を適用して{0}+{1}iを得ました",cNumber3.real,cNumber3.imaganinary);
            Console.ReadKey();
        }
    }
}
