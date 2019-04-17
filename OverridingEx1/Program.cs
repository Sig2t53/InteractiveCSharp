using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEx1
{
    // オーバーライド: 親クラスのメソッドを子クラスで再定義する方法
    //                 (親クラスのメソッドは上書きされてなかったものになる)
    //                 親クラス、子クラスのメソッドはシグネチャと戻り値、アクセス性が一致している必要がある
    //                 再定義できるようにするためには、
    //                    親クラスでvirtual
    //                    子クラスでoverride
    //                 をメソッドにつける
    //
    // 親クラスのメソッドにvirtualをつけない
    //   ⇒　エラー:継承されたメンバーは virtual、abstract または override に設定されていないためオーバーライドできません
    //
    // 親クラス側にvirtualキーワードをつけて子クラス側にoverrideキーワードをつけない
    //   ⇒  警告:継承されたメンバーを非表示にします。現在のメンバーでその実装をオーバーライドするには、override キーワードを追加してください。
    //            オーバーライドしない場合は、new キーワードを追加してください。
    //       ※実行は可能
    //
    // 親クラス側にvirtualキーワードと子クラス側にoverrideキーワードを共に省略
    //   ⇒  警告:継承されたメンバーを非表示にします。非表示にする場合は、キーワード new を使用してください。

    class ParetntClass
    {
        public virtual void ShowMe() 
        {
            Console.WriteLine("Parent.ShowMeの中にいます");
        }
        public void DoNotChangeMe()
        {
            Console.WriteLine("Parent.DoNotChangeMeの中にいます");
        }
    }
    class ChildClass : ParetntClass
    {
        public override void ShowMe()
        {
            Console.WriteLine("Child.ShowMeの中にいます");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** メソッドのオーバーロードのデモ ***\n\n");
            ChildClass childOb = new ChildClass();
            childOb.ShowMe(); //子クラスのメソッドを呼び出す
            childOb.DoNotChangeMe();
            Console.ReadKey();
        }
    }
}
