using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerQuiz1
{
    // 同じクラスに複数のインデクサを持たせることは可能(メソッドのシグネチャの重複は不可)
    // インデクサのオーバーロードは可能
    // インデクサと配列は類似しているが以下の点で異なる
    //   - インデクサには数字以外の添字が使用可能
    //   - インデクサはオーバーロード可能、配列はオーバーロード不可
    //   - インデクサのそれぞれの値は変数ではないので、refやoutのパラメータとして使えないが、配列は可能
    class EmployeeRecord
    {
        Dictionary<string, double> employeeWithSalary;
        public EmployeeRecord()
        {
            employeeWithSalary = new Dictionary<string, double>();
            employeeWithSalary.Add("Amit" ,20125.87);
            employeeWithSalary.Add("Sam"  ,56785.21);
            employeeWithSalary.Add("Rohit",33785.21);
        }
        public bool this[string index,int predicatedSalary]
        {
            get
            {
                double salary = 0.0;
                bool foundEmployee = false;
                bool predication = false;
                foreach(string s in employeeWithSalary.Keys)
                {
                    if(s.Equals(index))
                    {
                        foundEmployee = true;
                        salary = employeeWithSalary[s];
                        if(salary > predicatedSalary)
                        {
                            //何かのコード
                            predication = true;
                        }
                        else
                        {
                            //何かのコード
                        }
                        break;    
                    }
                }
                if(foundEmployee == false)
                {
                    Console.WriteLine("従業員{0}はデータベースに見つかりません。",index);
                }
                return predication;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** インデクサの問題 ***\n");
            EmployeeRecord employeeSalary = new EmployeeRecord();
            Console.WriteLine("Rohitの給与は25000ドルより多いですか？ - {0}",employeeSalary["Rohit",25000]);
            Console.WriteLine("Amitの給与は25000ドルより多いですか？  - {0}",employeeSalary["Amit", 25000]);
            Console.WriteLine("Jasonの給与は25000ドルより多いですか？ - {0}",employeeSalary["Jason", 25000]);
            Console.ReadKey();
        }
    }
}
