using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // student marks program
            Student student = new Student(1234, "abcd", "Btech", "1stsem", "cse");
            student.displaydata();
            student.displayresult();

            // car program

            Car car = new Car(9999, "BMW", "SUV");
            car.displaycardetails();
            Car car2 = new Car(500000);

            // Loan amount calculator

            InterestAmount ia = new InterestAmount();
            ia.loanCalculator(200000);
            Console.ReadLine();
        }
    }
}
