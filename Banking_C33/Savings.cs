using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C33
{
    class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.01m;

        public decimal CalculateAndPayInterest (int months)
        {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
            return interest;
        }
    }
}
