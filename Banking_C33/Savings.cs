using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C33
{
    
    //this Savings class demonstrates how to use inheritance functions.  This class inherits the Account class
    //using the syntax below.  This means that everything that is part of the Account class (all of it's properties
    //and methods) become a part of this class as well.
    class Savings : Account
    {
        
        //since the Account class did not contain a property or method related to interest rate that has to be
        //created in this class.  This makes sense since the theoretical bank only offers an interest rate
        //on savings accounts.
        //Below the InterestRate property is created as a decimal type and setting it a default value of 0.01.
        //When creating an instance of Savings the user would be able to enter a different value for 'InterestRate'.
        public decimal InterestRate { get; set; } = 0.01m;

        //this creates the CalculateAndPayInterest method which will calculate how much interest would accrue
        //on the balance of a particular account and deposit the interest amount to the account balance.
        //The method requires the user to pass in the number of months for each interval in which interest would
        //calculated and deposited.
        public decimal CalculateAndPayInterest (int months)
        {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
            return interest;
        }
    }
}
