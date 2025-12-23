using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountapp
{
    public class SavingAccount: BankAccount // inheritance
    {
        public decimal InterestRate { get; private set; }

        public SavingAccount(string owner,decimal interestRate):base(owner + "("+ interestRate+ "%)") 
        {
            InterestRate=interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit $" + amount;

            if (amount > 2000)
                return "deposit limit reached";

            decimal interestAmount= (InterestRate/100) * amount;

            Balance = Balance + amount + InterestRate;
            return "Deposit successfully";


        }


    }
}
