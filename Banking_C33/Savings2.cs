using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C33
{
    
    //This class will demonstrate creating all of the same functions in the Savings class but using the 
    //Composition technique instead of the Inheritance technique.  For the purposes of demonstrating this
    //how to use Composition this class will be written as if the Savings class had never been created.
    class Savings2
    {
        //this creates property(variable) 'account' in which the data type is not primitive but
        //a complex data type which is an actual instance of the Account class.  So once an Account
        //instance is created in the Constructor than variable 'account' receives all of the properties
        //and methods available to the Account class.  This is similar to inheritance which is displayed
        //in the Savings class of this project.  However, the technique being displayed in this class is
        //not inheritance but an example of the Composition ability.  Also this property was set to 'private'
        //so that it cannot be accessed or called outside of this class.
        private Account account { get; set; }

        //This property pulls the value stored in 'account.Id' which would pull the
        //Id from the Account class and passes it into 'Id' of this class.  So if a user creates a
        //Savings2 instance and wants to query the Id they will actually pull the Id from the Account instance.
        public int Id => account.Id;
        
        //Like with Id above this property will pull the value stored in 'account.Balance' which would pull the
        //Balance from the Account class and passes it into 'Balance' of this class.
        public decimal Balance => account.Balance;
        
        //This creates the string-type property 'Description'.  The user can read the Description which would
        //return the Description from the Account class (represented by the 'account' variable).  The user
        //can also set the Description in which whatever string they enter will be stored in the keyword
        //'value'.  This string value would then be passed into the 'account.Description'
        public string Description
        {
            get { return account.Description; }
            set { account.Description = value; }
        }
        
        //since Account class did not contain a property or method involving interest rate we have to 
        //create that in this class like we did in the Savings class.  The 'InterestRate' property is 
        //created below as a decimal-type and default value set to 0.01.
        public decimal InterestRate { get; set; } = 0.01m;

        //creates method to calculate interest accrued and add it to the account balance.  This must
        //return a decimal value. Integer variable 'months' is created which the user will enter when
        //calling this method.  Months will be the number of months an interest deposit interval.
        public decimal CalculateAndPayInterest(int months)
        {
            
            //creates the interest decimal-type variable and sets it the value calculated in the formula
            //below.  The syntax for the formula is almost identical to that used in the Savings class.
            //However, since we are not using inheritance in this class than we have to reference the 
            //'Balance' property as being part of the Account or 'account' class in order to call it.
            var interest = this.account.Balance * (InterestRate / 12) * months;
            
            //This calls the Deposit method from Account('account') class and adds the value of the 
            //interest variable to the account balance.
            this.account.Deposit(interest);
            
            //returns the necessary decimal value
            return interest;
        }
        
        //allows the 'Deposit' method to be used in this class identically to how it is used in the 
        //Account class.
        public bool Deposit(decimal amount)
        {
            
            //since 'account' is the same as the Account class we can call the method by referencing
            //it using the syntax below.  This prevents the need to rewrite all the code that was used
            //to create the 'Deposit' method in the Account class.
            return this.account.Deposit(amount);
        }
        //See notes above regarding 'Deposit' method.  Same situation here.
        public bool Withdraw(decimal amount)
        {
            
            //see notes above regarding 'Deposit' syntax.
            return this.account.Withdraw(amount);
        }

        //same as above
        public bool Transfer(decimal amount, Account ToAccount)
        {
            
            //same as above
            return this.account.Transfer(amount, ToAccount);
        }
        
        //same as above
        public void Print()
        {
            
            //same as above
            this.account.Print();
        }

        //This creates a Constructor which will initialize the values of the properties in this class. So
        //the property 'account' will be set to the value of a new instance of the Account class which allows
        //to make use of all of the properties and methods available in the Account class.  When creating a
        //'Savings2' instance the user will enter a value for the integer variable id.  This value will then
        //be passed to the property 'account.Id' which is the same as the Id property from 'Account' class.
        //The 'account.Description' (i.e. Account.Description) property will be initialized to the string
        //shown below.  This can be set to something else by the user when creating a new Savings2 instance.
        public Savings2(int id)
        {
            this.account = new Account();
            this.account.Id = id;
            this.account.Description = "New Savings2";            
        }
    }
}
