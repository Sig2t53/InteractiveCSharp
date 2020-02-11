using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx4
{
    interface ISampleEmployee<T>
    {
        string CheckForIdenticalEmployee(T obj);
    }

    class Employee : ISampleEmployee<Employee>
    {
        string deptName;
        int employeeID;
        public Employee(string deptName,int employeeId)
        {
            this.deptName = deptName;
            this.employeeID = employeeId;
        }

        public string CheckForIdenticalEmployee(Employee obj)
        {
            if(obj == null) { return "nullオブジェクトとの比較はできません"; }
            if(this.deptName ==obj.deptName && this.employeeID == obj.employeeID){ return "両者は同一人物です"; }
            return "両者は別人です";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Employeeクラスに属性deptNameとemployeeIDがあるとします ***");
            Console.WriteLine("*** 2つのEmployeeオブジェクトが同じかどうか調べます        ***");
            Console.WriteLine();
            Employee emp1 = new Employee("Maths", 1);
            Employee emp2 = new Employee("Maths", 2);
            Employee emp3 = new Employee("Comp. Sc.", 1);
            Employee emp4 = new Employee("Maths", 2);
            Employee emp5 = null;
            Console.WriteLine("Emp1とEmp3を比べると{0}",emp1.CheckForIdenticalEmployee(emp3));
            Console.WriteLine("Emp2とEmp4を比べると{0}",emp2.CheckForIdenticalEmployee(emp4));
            Console.WriteLine("Emp3とEmp5を比べると{0}",emp3.CheckForIdenticalEmployee(emp5));
            Console.ReadKey();
        }
    }
}
