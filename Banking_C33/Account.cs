using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C33
{
    class Account
    {
        //here are the Properties for Account class.  These are provided by the user when creating 
        //a new instance of Account class.
        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }

        //here is the Deposit method, public accessibility, made it a bool data type that returns either
        //'true' or 'false', amount of deposit needs to be passed into the amount variable.  Since we are 
        //dealing with monetary values (i.e. dollars and cents) the 'amount' data-type is a decimal so that 
        //decimals will be displayed.
        public bool Deposit(decimal amount)
        {
            //this if statement prevents 0's or negative numbers from being passed in.  As long as 
            //'amount' is a positive number it will execute the rest of the script inside the curly braces.
            if (amount > 0)
            {
                //adds 'amount' to current balance.
                this.Balance = this.Balance + amount;
                return true;
            }
            //This will execute if a negative number or 0 is entered as the amount.
            else Console.WriteLine("You cannot enter a negative number or 0!");
            return false;
        }
        //this creates the Withdraw method, public accessibility, also a bool data type, amount of withdrawal
        //needs to be passed into the amount variable.  Made 'amount' a decimal type like in Deposit.
        public bool Withdraw(decimal amount)
        {
            //like in the Deposit method this if statement will prevent negative numbers or 0's from
            //being passed into the amount.
            if (amount > 0)
            //this will be executed as long as 'amount' is a positive number.
            {
                //this if statement checks to make sure that the withdrawal amount does not exceed
                //the account balance.
                if (amount > this.Balance)
                //the following executes if the amount entered is greater than the balance.
                {
                    Console.WriteLine("Insufficient funds!");
                    return false;
                }
                //if the withdrawal amount is <= the balance than 'amount' is subtracted from 'Balance'.
                this.Balance = this.Balance - amount;
                return true;
            }
            //if 'amount' is 0 or a negative number this will execute
            else Console.WriteLine("You cannot enter a negative number or 0!");
            return false;
        }
        
        //this creates the Transfer method.  It allows transferring an 'amount' of money from one account to 
        //another.  The account that is currently being instanced will be the 'from' account that money is
        //transferred from.  The 'ToAccount' variable is a class instance data type set to the Account class.
        //An Account class instance name will have to be entered by the user along with the amount when using
        //the 'Transfer' method.  When Account instance name is entered than ToAccount becomes a copy of that
        //instance.
        public bool Transfer(decimal amount, Account ToAccount)
        {
            //variable 'success' is set to the return value of the 'Withdraw' method execution.  As long as
            //Withdraw successfully executed than it will return the bool value 'true' to variable success.
            //The 'amount' passed into the method will be withdrawn from the current account being used.
            var success = Withdraw(amount);
            
            //once it has been checked that the 'Withdraw' method executed successfully and 'success' value
            //has been set to true than the following if statement will execute.  Remember that '==' means 
            //the item on the left is actually equal to the item on the right. An '=' is just assigning a value
            //to the item on the left by reading whatever the value on the right is.
            if(success == true)
            {
                
                //the amount withdrawn from the current account being accessed is then deposited into the
                //target account assigned to the ToAccount variable by referencing the Deposit method existing
                //within the Account instance that is assigned to ToAccount.
                ToAccount.Deposit(amount);
            }
            return true;
        }
        
        //the following provides a printout showing the Account Id, Balance and Description.
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}
