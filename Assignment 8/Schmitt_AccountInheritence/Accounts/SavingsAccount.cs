using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schmitt_AccountInheritence.Accounts
{
    internal class SavingsAccount : Account
    {
        //Propreties

        //Fields
        private int widthdrawCount;

        /// <summary>
        /// Savings account contructor
        /// </summary>
        /// <param name="name">The name for this account</param>
        /// <param name="balance">The balance for this account</param>
        /// <param name="accountType">The type for this account</param>
        internal SavingsAccount(string name, decimal balance, Type accountType) : base(name, balance, accountType)
        {

        }


        internal override void TransferTo(Account account, decimal amount)
        {
            base.TransferTo(account, amount);
        }

        internal override bool Widthdraw(Account account)
        {
            return base.Widthdraw(account);
        }


    }
}
