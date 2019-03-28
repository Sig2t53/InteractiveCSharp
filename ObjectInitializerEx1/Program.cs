using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerEx1
{
    class Employee
    {
        public string Name;
        public int Id;
        public double Salary;
        // 明示的なパラメータなしのコンストラクタ
        public Employee() { }
        // 引数を1つとるコンストラクタ
        public Employee(string name) { this.Name = name; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** オブジェクトの初期化サンプル１ ***");

            // その１ オブジェクトを初期値を与えずに初期化する
            // 明示的なパラメータなしのコンストラクタを用いる
            Employee emp1 = new Employee();
            emp1.Name = "Amit";
            emp1.Id = 1;
            emp1.Salary = 10000.23;
            // 引数を１つとるコンストラクタを用いる
            Employee emp2 = new Employee("Sumit");
            emp2.Id = 2;
            emp2.Salary = 20000.32;

            // その２ オブジェクトに初期値を与えて初期化する
            // 明示的なパラメータなしのコンストラクタを用いる
            Employee emp3 = new Employee { Name = "Bob", Id = 3, Salary = 15000.53 };
            // 引数を１つ取るコンストラクタを用いる
            Employee emp4 = new Employee("Robin") { Id=4 , Salary = 25000.35 };

            Console.WriteLine("従業員の詳細:");
            Console.WriteLine("Name = {0} Id={1} Salary={2}", emp1.Name, emp1.Id, emp1.Salary);
            Console.WriteLine("Name = {0} Id={1} Salary={2}", emp2.Name, emp2.Id, emp2.Salary);
            Console.WriteLine("Name = {0} Id={1} Salary={2}", emp3.Name, emp3.Id, emp3.Salary);
            Console.WriteLine("Name = {0} Id={1} Salary={2}", emp4.Name, emp4.Id, emp4.Salary);
            Console.ReadKey();
        }
    }
}
