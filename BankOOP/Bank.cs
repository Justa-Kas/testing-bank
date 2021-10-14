using System;
using System.Collections.Generic;
using System.Text;

namespace BankOOP
{
    class Bank
    {

        //properties
        private double Money;
        public double money
        {
            get
            {  return Money; }
        }
        private double Interest;

        //constructor
        public Bank()
        {
            Money = 0;
            Interest = 0.06;
        }
        public Bank(double money)
        {
            Money = money;
            Interest = 0.06;
        }
        public Bank(double money, double interest)
        {
            Money = money;
            Interest = interest;
        }

        //methods
        public void Deposit(double value)
        {
            Money += value;
            CollectInterest();
        }
       
        public double Withdraw(double value)
        {
            if (value <= Money)
            {
                Money -= value;
                
            }
            else
            {
                Console.WriteLine("You don't have the funds for that transaction");
                value = 0;
            }
            CollectInterest();
            return value;
        }

        private void CollectInterest()
        {
            double result = Money * Interest;
            Money += result;
        }
    }
}
