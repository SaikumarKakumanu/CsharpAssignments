﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        public class Bank
        {
            float Amount = 10000.00f;
            float Balance;
            string Acc_Name;
            string Acc_Number;

            public Bank()
            {
                Console.WriteLine("Enter the Account Number : ");
                Acc_Number =Console.ReadLine();
                Console.WriteLine("Enter the Account holder Name :");
                Acc_Name =Console.ReadLine();

                Console.WriteLine($"The Account details is : AccountNum {Acc_Number}, Acount Namer {Acc_Name}, Amount is {Amount}");

            }


            public void DepositeAmount()
            {
                Console.WriteLine("Enter the Deposited Amount : ");
                float DepAmount = Convert.ToSingle(Console.ReadLine());

                if(DepAmount == 0)
                {
                    Console.WriteLine("Deposite the minimum amount above 1000.00 ");

                }
                else
                {
                    Balance = Amount+DepAmount;
                    Console.WriteLine("Your Account Balance is After amount deposite : "+Balance);
                }
            }

            public void Amount_Withdrawn()
            {

                try
                {
                    Console.WriteLine("Enter the WithDrawn Amount : ");
                    float Withdrawn_Amount = Convert.ToSingle(Console.ReadLine());
                   // Balance = Balance - Withdrawn_Amount;

                    if( Withdrawn_Amount> Balance)
                    {
                        Console.WriteLine("insufficent balance");
                    }
                    else
                    {
                        Balance = Balance - Withdrawn_Amount;
                        Console.WriteLine("Your Account Balance is After With Draw the amount :"+Balance);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Formate Exception Enter only numbers :",ex);
                }
            }
        }


        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.DepositeAmount();
            bank.Amount_Withdrawn();
            Console.Read();
        }
    }
}
