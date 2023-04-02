using System;

namespace Schmitt_AccountInheritence.Accounts
{
    internal class SavingsAccount : Account
    {
        const int MAX_WIDTHDRAWS = 5;

        //Fields
        private int widthdrawCount;

        /// <summary>
        /// Savings account contructor
        /// </summary>
        /// <param name="accountHolder">The name for this account</param>
        /// <param name="balance">The balance for this account</param>
        /// <param name="accountType">The type for this account</param>
        internal SavingsAccount(string accountHolder, decimal balance, Type accountType) : base(accountHolder, balance, accountType)
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
            //Were we able to remove money from this account?
            if(Widthdraw(amount))
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

        /// <summary>
        /// An overriden version of the base widthdraw method that limits the maximum amount of widthdrawls
        /// </summary>
        /// <param name="amount">The amount to widthdraw</param>
        /// <returns>True if the operation succeeded</returns>
        internal override bool Widthdraw(decimal amount)
        {
            //Incrmenet our widthdraw count by one
            widthdrawCount++;

            if(widthdrawCount > MAX_WIDTHDRAWS)
            {
                return false;
            }

            //Run he base widthraw method
            return base.Widthdraw(amount);
        }
    }
}
