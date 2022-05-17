using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebasedTest2
{
    delegate int CalucaltorFun(int a,  int b);
    internal class Program
    {
        
        public static int Add(int p, int q)
        {
            int add = p+q;
            return add;
        }

        public static int Multiply(int p,int q)
        {
            int multi = p*q;
            return multi;
        }
        public static int Subtract(int p, int q)
        {
            int sub = p - q;
            return sub;
        }
        static void Main(string[] args)
        {
            CalucaltorFun cf1 = new CalucaltorFun(Add);
            CalucaltorFun cf2 = new CalucaltorFun(Multiply);
            CalucaltorFun cf3 = new CalucaltorFun(Subtract);

            Console.WriteLine($"The Adding calculator p+q is {cf1(10, 20)}");
            Console.WriteLine($"the Multiplication of p*q is {cf2(10, 20)}");
            Console.WriteLine($"the subtraction of p-q is {cf3(30,20)}");
            Console.Read();
        }
    }
}
