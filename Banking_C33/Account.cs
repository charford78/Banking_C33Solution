using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C33
{
    class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }

        public bool Deposit(decimal amount)
        {
            this.Balance = this.Balance + amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                Console.WriteLine("Insufficient funds!");
                return false;
            }
            this.Balance = this.Balance - amount;
            return true;
        }
        public bool Transfer(decimal amount, Account ToAccount)
        {
            var success = Withdraw(amount);
            if(success == true)
            {
                ToAccount.Deposit(amount);
            }
            return true;
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}
