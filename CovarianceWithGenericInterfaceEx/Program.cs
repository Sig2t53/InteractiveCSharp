using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceWithGenericInterfaceEx
{
    //共変性
    //  もとの指定型から派生した型も使用可能
    // 
    //数学的な観点からの共変性(※整数の領域についてだけ考えた場合)
    //  すべてのxに対して、関数f(x) = x + 2 を定義します。
    //  xがy以下ならば、すべてのxについてf(x)はf(y)以下であると言えるので、射影(関数f)は大小関係を保存しています。

    class Parent
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("私はParentから来ています。私のHashCodeは{0}",GetHashCode());
        }
    }

    class Child : Parent
    {
        public override void ShowMe()
        {
            Console.WriteLine("私はChildから来ています。私のHashCodeは{0}", GetHashCode());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 共変性の例
            Console.WriteLine("*** ジェネリックインターフェースで共変性を実現する例 ***");
            Console.WriteLine("*** IEnumerable<T>には共変性があります ***");
            // クラスParentのオブジェクトをいくつか
            Parent pob1 = new Parent();
            Parent pob2 = new Parent();
            // クラスChildのオブジェクトをいくつか
            Child cob1 = new Child();
            Child cob2 = new Child();
            //Childオブジェクトのリストを作成
            List<Child> childList = new List<Child>();
            childList.Add(cob1);
            childList.Add(cob2);
            IEnumerable<Child> childEnumerable = childList;
            /* 基本型であるParentクラスとして初期化されているオブジェクトに *
             * 派生型Childのインスタンスを代入。代入互換性はここで維持される
             */
            IEnumerable<Parent> parentEnumerable = childEnumerable;
            foreach(Parent p in parentEnumerable)
            {
                p.ShowMe();
            }
            Console.ReadKey();
        }
    }
}
