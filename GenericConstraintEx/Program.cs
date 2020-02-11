using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraintEx
{
    interface IEmployee
    {
        string Position();
    }

    class Employee : IEmployee
    {
        public string name;
        public int yearOfExp;
        public Employee(string name,int years)
        {
            this.name = name;
            this.yearOfExp = years;
        }

        public string Position()
        {
            if(yearOfExp < 5) { return "若手社員"; }
            return "ベテラン社員";
        }
    }

    //↓where Employee : IEmployeeがないとエラー
    class EmployeeStoreHouse<Employee> where Employee : IEmployee
    {
        private List<Employee> MyStore = new List<Employee>();
        public void AddToStore(Employee element)
        {
            MyStore.Add(element);
        }
        public void DisplayStore()
        {
            Console.WriteLine("保管されている内容は以下の通り");
            foreach(Employee e in MyStore)
            {
                Console.WriteLine(e.Position());
            }
        }
    }

    //EmployeeStoreHouseは↓の書き方も可能
    //class EmployeeStoreHouse<T> where T : IEmployee
    //{
    //    private List<T> MyStore = new List<T>();
    //    public void AddToStore(T element)
    //    {
    //        MyStore.Add(element);
    //    }
    //    public void DisplayStore()
    //    {
    //        Console.WriteLine("保管されている内容は以下の通り");
    //        foreach (T e in MyStore)
    //        {
    //            Console.WriteLine(e.Position());
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ジェネリックの制約を確かめる ***");

            // 複数のEmployeeオブジェクト
            Employee e1 = new Employee("Amit",2);
            Employee e2 = new Employee("Bob", 5);
            Employee e3 = new Employee("Jon", 7);

            // Employeeオブジェクトの保管場所
            EmployeeStoreHouse<Employee> myEmployeeStore = new EmployeeStoreHouse<Employee>();
            myEmployeeStore.AddToStore(e1);
            myEmployeeStore.AddToStore(e2);
            myEmployeeStore.AddToStore(e3);

            //保管されているEmployeeオブジェクトの情報を表示
            myEmployeeStore.DisplayStore();
            Console.ReadKey();
        }
    }
}
