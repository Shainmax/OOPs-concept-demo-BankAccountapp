using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountapp
{
    public  class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }  //encapsulation

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber=Guid.NewGuid();
            Balance = 0;

        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit $" + amount;

            if (amount > 2000)
                return "deposit limit reached";

            Balance = Balance + amount;
            return "Deposit successfully";
            
                
        }

        public string Withdraw(decimal amount) 
        {
            if(amount <= 0)
                return " you cannot withdraw $"+amount;
            if (amount > Balance)
                return "insufficient Balance";

            Balance = Balance - amount;
            return " withdraw completed  successfully";
        }

    }
}
