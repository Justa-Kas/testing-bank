using System;

namespace BankOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank Xhiradryl = new Bank(10);
            double x = Xhiradryl.money;
            //.money only has a getter, can't set.
            //Xhiradryl.money= x

            Console.WriteLine(Xhiradryl.money);
            Xhiradryl.Deposit(73);
            Console.WriteLine(Xhiradryl.money);
            double cash = Xhiradryl.Withdraw(148);
            Console.WriteLine($"I am holding {cash} after withdrawl");
            Console.WriteLine(Xhiradryl.money);
        }
    }
}
