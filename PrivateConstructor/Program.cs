using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{

    // ParentClassのコンストラクタがprivateになっているため、子クラスを作成できない
    // ChildClassのコメントを外すとエラーになる
    // ⇒ singleton(※)デザインパターンを作るときに使える
    //    ※singletonデザインパターン:システム内に不要なオブジェクトを作れない(newできない)ようにするパターン
    //'ParentClass.ParentClass()' はアクセスできない保護レベルになっています PrivateConstructor

    class ParentClass
    {
        private ParentClass() { }
        public void ShowClassName()
        {
            Console.WriteLine("Parent.ShowClassNameの中にいます");
        }
    }

    //class ChildClass : ParentClass
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
