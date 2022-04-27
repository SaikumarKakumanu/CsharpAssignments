using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    
    class Student
    {
        int id;
        string name;
       public double Fee;
        double examfee = 3000.00;
        public Student()
        {
            Console.WriteLine("Enter the Student id and name and fee : ");
            id=int.Parse(Console.ReadLine());
            name=Console.ReadLine();
            Fee=double.Parse(Console.ReadLine());

            Console.WriteLine($"The Student details are student id {id}, name {name}, examfee {Fee}");
        }

        //public void Display()
        //{
        //    Console.WriteLine($" The Student details are student id {id}, name {name}, examfee{ExamFee}");
        //}

        public virtual double payfee()
        {
            double remfee = examfee - Fee;
            return remfee;
        }
    }

    class DayScholar : Student
    {
        double TransportFee;

        public DayScholar():base()
        {
            this.TransportFee=7000;

            Console.WriteLine("transport fee is: "+TransportFee);
        }

        public override double payfee()
        {
            TransportFee = TransportFee-Fee;
           return TransportFee;
        }
    }

    class Hosteller : Student
    {
        double HostelFee;

        public Hosteller() : base()
        {
           this.HostelFee=10000.00;
            Console.WriteLine("The hostelfeee is : "+HostelFee);
        }

        public override double payfee()
        {
            HostelFee = HostelFee-Fee;
            return HostelFee;
        }
    }
    internal class RunClass
    {

        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.payfee());

            // Dayscholar fee

            DayScholar ds = new DayScholar();
            Console.WriteLine(ds.payfee());

            // Hostel fee

            Hosteller hs = new Hosteller();
            Console.WriteLine(hs.payfee());
            
            Console.Read();
        }
    }
}
