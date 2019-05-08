using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEx1
{
    class Program
    {
        // インデクサについて
        //   これまで学んだプロパティと似ているが、名前がthis
        //   thisに続く引数は配列と同じようにindexになっている
        // 
        //   インデクサを使うとクラスや構造体、インターフェースのインスタンスを配列として扱える
        //   thisキーワードは、そのインスタンスを参照するのに使う
        //   インデクサに使用可能な修飾子:
        //      private,public,protected,internal等(プロパティと同じ)
        // 
        //   戻り値の型はC#のデータ型であればすべて有効
        //   複数のインデクサを持つ1 つのデータ型を作ることができる
        //   それぞれのインデクサは、異なるデータ型のパラメータをとることが可能
        //
        //   構文としては、他の例と同様、setアクセサを定義しなければインデクサも読み取り専用になるが
        //   無理にインデクサを作るより、読み取りのメソッドを定義したほうが良い
        //   例.引数に従業員IDをとり、その人の情報を得るというケース
        //
        //   次のようなコードは避けるべきです。
        //　   // 推奨されないスタイル
        //　   Class Employee
        //　   {
        //　   　　//インデクサで従業員の詳細情報を取得
        //　   　　public string this[int empId]
        //　   　　{
        //　   　　    get
        //　   　　    {
        //　   　　        return Employee //オブジェクトの情報
        //　   　　    }
        //　   　　}
        //　   }

        class MySentence
        {
            string[] wordsArray;
            public MySentence(string mySentence)
            {
                wordsArray = mySentence.Split();
            }
            public string this[int index]
            {
                get
                {
                    return wordsArray[index];
                }
                set
                {
                    wordsArray[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*** インデクサの実装例 ***\n");
            string mySentence = "This is nice day.";
            MySentence sentenceObject = new MySentence(mySentence);
            for(int i = 0; i < mySentence.Split().Length;i++)
            {
                Console.WriteLine("\t sentenceObject[{0}]={1}",i,sentenceObject[i]);
            }
            Console.ReadKey();
        }
    }
}