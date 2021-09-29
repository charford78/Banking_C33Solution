using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C33
{
    class Savings2
    {
        //this creates property(variable) 'account' in which the data type is not primitive but
        //a complex data type which is an actual instance of the Account class.  So once an Account
        //instance is created in the Constructor than variable 'account' receives all of the properties
        //and methods available to the Account class.  This is similar to inheritance which is displayed
        //in the Savings class of this project.
        private Account account { get; set; }

        //This property allows pulls the value stored in 'account.Id' which would pull the
        //Id from the Account class and passes it into 'Id'.
        public int Id => account.Id;
        public decimal Balance => account.Balance;
        public string Description
        {
            get { return account.Description; }
            set { account.Description = value; }
        }
        public decimal InterestRate { get; set; } = 0.01m;

        public decimal CalculateAndPayInterest(int months)
        {
            var interest = this.account.Balance * (InterestRate / 12) * months;
            this.account.Deposit(interest);
            return interest;
        }
        public bool Deposit(decimal amount)
        {
            return this.account.Deposit(amount);
        }

        public bool Withdraw(decimal amount)
        {
            return this.account.Withdraw(amount);
        }

        public bool Transfer(decimal amount, Account ToAccount)
        {
            return this.account.Transfer(amount, ToAccount);
        }
        public void Print()
        {
            this.account.Print();
        }

        public Savings2(int id)
        {
            this.account = new Account();
            this.account.Id = id;
            this.account.Description = "New Savings2";            
        }
    }
}
