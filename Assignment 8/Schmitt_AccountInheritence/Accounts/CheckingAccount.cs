using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schmitt_AccountInheritence.Accounts
{
    internal class CheckingAccount : Account
    {
        /// <summary>
        /// Checking account constructor
        /// </summary>
        /// <param name="accountHolder">The name of this checking acount</param>
        /// <param name="balance">The balance of this checking account</param>
        /// <param name="accountType">The type of this checking account</param>
        internal CheckingAccount(string accountHolder, decimal balance, Type accountType) : base(accountHolder, balance, accountType) 
        {
            //When the from and too accounts are both null, we know this Transaction was an instantiation
            LogTransaction(null, null, balance);
        }

        /// <summary>
        /// Transfer funds to another account
        /// </summary>
        /// <param name="other">The account to transfer funds to</param>
        /// <param name="amount">The amount to transfer</param>
        internal override void TransferTo(Account other, decimal amount)
        {
            //Were able to remove money from this account?
            if (base.Widthdraw(amount))
            {
                //Add money to the account recieving a deposit
                other.Deposit(amount);

                //Log the transaction
                LogTransaction(this, other, amount);
                other.LogTransaction(this, other, amount);
            }
            else
            {
                //Log a failed transaction
                LogTransaction(this, other, 0);
                other.LogTransaction(this, other, 0);
            }
        }
    }
}
