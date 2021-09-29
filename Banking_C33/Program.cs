using System;

namespace Banking_C33
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav1 = new Savings()
            {
                Id = 10,
                Description = "My First Savings"
            };
            sav1.InterestRate = 0.12m;
            sav1.Print();
            sav1.Deposit(5000);
            sav1.Withdraw(2000);
            sav1.CalculateAndPayInterest(1);
            sav1.Print();

            

        //    var acct1 = new Account()
        //    {
        //        Id = 1, Description = "Test Account"
        //    };
        //    acct1.Print();
        //    acct1.Deposit(9500);
        //    acct1.Print();
        //    acct1.Withdraw(6000);
        //    acct1.Print();
        //    acct1.Withdraw(4000);
        //    acct1.Print();

        //    var acct2 = new Account()
        //    {
        //        Id = 2,
        //        Description = "New Account"
        //    };
        //    acct1.Transfer(1500, acct2);
        //    acct1.Print();
        //    acct2.Print();

        //    acct1.Withdraw(-1000);
        //    acct1.Print();
        //    acct1.Deposit(-5000);
        //    acct1.Print();
        }
    }
}
