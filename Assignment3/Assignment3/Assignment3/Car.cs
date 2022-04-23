using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Car
    {
        int carno;
        string carName;
        string carType;
        readonly double carcost=1000000;

        public Car(int carno, string carName, string carType)
        {
            this.carno = carno;
            this.carName = carName;
            this.carType = carType;
            //this.carcost = carcost;

            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");
        }

        public Car(double cost)
        {
            carcost = cost;
            Console.WriteLine("After changing");
            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");
        }
        public void displaycardetails()
        {
            Console.WriteLine("Before changing");
            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");
           
        }
    }
    
}
