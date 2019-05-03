using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEx3
{
    class ParentClass
    {
        public virtual void ShowMe()
        {
            Console.WriteLine("Parent.ShowMeの中にいます");
        }
    }
    class ChildClass : ParentClass
    {

        // C#のメソッドは既定ではvirtualではない(Javaは既定がvirtual)
        // C#では親クラスでvirtualを指定したメソッドを子クラスでoverrideを指定して再定義する
        // メソッドがoverrideではないと明示するためにnewを使う
        //
        // ↓にnewをつけないと
        // 警告「'ChildClass.ShowMe()' は継承されたメンバー 'ParentClass.ShowMe()' を非表示にします。現在のメンバーでその実装をオーバーライドするには、override キーワードを追加してください。オーバーライドしない場合は、new キーワードを追加してください。」
        // が発生する
        //
        // C#では基本的にポリモーフィズムでオーバーライドする思想なので、
        // それをしないメソッドは明示することになっている
        public new void ShowMe()
        {
            Console.WriteLine("Child.ShowMeの中にいます");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** メソッドをオーバーライドする際にnewキーワードを用いる例 ***\n");
            ParentClass parentOb = new ParentClass();
            parentOb.ShowMe();
            ChildClass childOb = new ChildClass();
            childOb.ShowMe();
            Console.ReadKey();
        }
    }
}
