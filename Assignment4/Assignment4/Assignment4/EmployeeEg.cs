using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{

   public  class Employee
    {
        int EmpId;
        string EmpName;
        float salary;


        public Employee()
        {
            Console.WriteLine("Enter the Emp details EmpId Emp Name Emp Salary : ");
            this.EmpId =int.Parse(Console.ReadLine());
            this.EmpName = Console.ReadLine();
            this.salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"the Employee details is empname {this.EmpId}, empname {EmpName}, Salary is {this.salary}");

            Console.WriteLine("--------------------------");
        }
    }


    class PartTimeEmployee: Employee
    {

        public PartTimeEmployee() : base()
        {
            Console.WriteLine("Enter the partime employee details : ");
            int EmpId = int.Parse(Console.ReadLine());
            string EmpName = Console.ReadLine();
            float salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"the employee deatils empid is {EmpId}, employeename {EmpName}, empSalary is {salary}");
        }
    }

    
    internal class EmployeeEg
    {
        static void Main(string[] args)
        {
            PartTimeEmployee pte = new PartTimeEmployee();
            Console.Read();
        }
       
    }
}
