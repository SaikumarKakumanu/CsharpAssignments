using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public abstract class Students
    {

        int studentid;
        string studentname;
        public abstract bool IsPassed(float grade);

        public void getdatails()
        {
            Console.WriteLine("Enter the student details id and name : ");
            studentid = int.Parse(Console.ReadLine());
            studentname = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine($"The student details is studentid is {studentid}, studentname is {studentname}");
        }

    }

    class Graduate : Students
    {
        public override bool IsPassed(float grade)
        {
           float result = grade;

            if (result > 70.0f)
                return true;
            return false;
        }
    }

    class Undergraduate : Students
    {
        public override bool IsPassed(float grade)
        {
            float res = grade;
            if(res > 80.0f)
                return true ;
            return false;
        }
    }
    internal class AbstractEg
    {
        static void Main(String[] args)
        {
            Graduate g = new Graduate();
            g.getdatails();
            g.show();
            Console.WriteLine(g.IsPassed(70.0f));

            // under graduate details
            Undergraduate ug = new Undergraduate();
            ug.getdatails();
            ug.show();
            Console.WriteLine(ug.IsPassed(85.0f));
            Console.Read();
        }
    }
}
