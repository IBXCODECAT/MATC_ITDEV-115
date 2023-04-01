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


        internal SavingsAccount(string name, decimal balance, string accountType)
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
