using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{

    
    public abstract class Student1
    {
        protected string id;
        protected string name;
        public abstract bool IsPassed();

        public abstract void Student_Details();

        public virtual void getdetails()
        {
            Console.WriteLine($"the Student details  Name {this.name}, StudentID {this.id}");
        }
    }

   

    class UnderGraduate : Student1
    {
        public float grade;
        public override void Student_Details()
        {
            Console.WriteLine("enter the ungraduate student details");
            id = Console.ReadLine();
            name = Console.ReadLine();
            grade = Convert.ToSingle(Console.ReadLine());
        }

        public override bool IsPassed()
        {
            if(grade <70.0f)
            {
                return false;
            }
           return true;
        }
    }

    class Grduate : Student1
    {
        public float grade;
        public override void Student_Details()
        {
         
            Console.WriteLine("enter the Graduate student details");
            id = Console.ReadLine();
            name = Console.ReadLine();
            grade = Convert.ToSingle(Console.ReadLine());
        }
        public override bool IsPassed()
        {
            if (grade > 80)
                return true;
            return false;
        }
    }

   
    internal class Abstract
    {
        static void Main(string[] args)
        {
            // under graduate class
            UnderGraduate ug = new UnderGraduate();
            ug.Student_Details();
            ug.getdetails();
            Console.WriteLine(ug.IsPassed());
            // graduate class
            Grduate g = new Grduate();
            g.Student_Details();
            g.getdetails();
            Console.WriteLine(g.IsPassed());
            Console.ReadLine();
        }
    }
}
