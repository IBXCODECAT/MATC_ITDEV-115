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
        /// <param name="name">The name of this checking acount</param>
        /// <param name="balance">The balance of this checking account</param>
        /// <param name="accountType">The type of this checking account</param>
        internal CheckingAccount(string name, decimal balance, Type accountType) : base(name, balance, accountType)
        {

        }

        internal override void TransferTo(Account account, decimal amount)
        {
            base.TransferTo(account, amount);
        }
    }
}
