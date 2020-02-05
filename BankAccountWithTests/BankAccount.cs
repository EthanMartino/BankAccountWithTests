using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithTests
{
    public class BankAccount
    {
        private string accountNumber;

        public BankAccount(string accountNum)
        {
            AccountNumber = accountNum;
        }

        public string AccountNumber 
        { 
            get 
            { 
                return accountNumber; 
            } 
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Account Number cannot be null or whitespace.");
                }
                accountNumber = value; 
            }
        }

        public string Owner { get; private set; }

        public double Balance { get; private set; }

        /// <summary>
        /// Deposits a positive amount of money into the account and returns the new balance
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when amount is 0 or less</exception>
        /// <param name="amount">The amount of money to deposit</param>
        public double Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, "You must deposit a positive amount.");
            }
            Balance += amount;
            return Balance;
        }

        public double Withdrawl()
        {


            return Balance;
        }
    }
}
