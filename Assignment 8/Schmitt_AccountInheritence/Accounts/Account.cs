using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schmitt_AccountInheritence.Accounts
{
    internal class Account
    {
        //Propreties
        internal string AccountType { get; set; }
        internal decimal Balance { get; set; }
        internal string Name { get; set; }
        internal ArrayList TransactionList { get; set; }

        //Fields
        private string accountType;
        private decimal balance;
        private string name;
        private ArrayList transactionList;

        /// <summary>
        /// Account Constructor
        /// </summary>
        /// <param name="name">This account's name</param>
        /// <param name="balance">This account's balance</param>
        /// <param name="accountType">This account's type</param>
        internal Account(string name, decimal balance, string accountType)
        {
            this.name = name;
            this.balance = balance;
            this.accountType = accountType;
        }

        internal void Deposit(decimal amount)
        {

        }

        internal void LogTransaction(string transaction)
        {

        }

        internal virtual void TransferTo(Account account, decimal amount)
        {

        }

        internal virtual bool Widthdraw(Account account)
        {

        }
    }
}
