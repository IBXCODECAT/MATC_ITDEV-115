using System;
using System.Collections.Generic;

namespace Schmitt_AccountInheritence.Accounts
{
    internal class Account
    {
        //
        /// <summary>
        /// Instead of a string for the account type as explained in the instructions I have opted for a Type. This keeps code clean and less prone to error
        /// especially in any control structures where comparing strings
        /// </summary>
        internal Type AccountType { get { return accountType; } private set { accountType = value; } }
        internal decimal Balance { get { return balance; } set { balance = value; } }
        internal string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Instead of an ArrayList of strings, I am using a List of Transactions (a custom data structure contianing information about the transaction)
        /// </summary>
        internal List<Transaction> Transactions { get { return transactionList; } set { transactionList = value; } }

        //Fields
        private Type accountType;
        private decimal balance;
        private string name;

        /// <summary>
        /// Instead of a string for the account type as explained in the instructions I have opted for a Type. This keeps code clean and less prone to error
        /// especially in any control structures where comparing strings
        /// </summary>
        private List<Transaction> transactionList;

        /// <summary>
        /// Transaction data structure containing the amount and the accounts involved in the transfer
        /// 
        /// This struct was not required in the assignment, but I am using it to keep my data more organized.
        /// This struct will take the place of any transaction strings in the transactions list as explained in the assignment instructions.
        /// </summary>
        internal struct Transaction
        {
            internal Account from;
            internal Account to;
            internal decimal amount;
        }

        /// <summary>
        /// Account Constructor
        /// </summary>
        /// <param name="name">This account's name</param>
        /// <param name="balance">This account's balance</param>
        /// <param name="accountType">This account's type</param>
        internal Account(string name, decimal balance, Type accountType)
        {
            this.name = name;
            this.balance = balance;
            this.accountType = accountType;
        }

        internal void Deposit(decimal amount)
        {

        }

        /// <summary>
        /// Log a transaction in an account's transactions list
        /// 
        /// This method's parameters have been modified to acomidate the data struct (Transaction) I made.
        /// I did this to make the code more organized because strings are easy to mess up, especially in if statments.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="amount"></param>
        internal void LogTransaction(Account from, Account to, decimal amount)
        {
            Transaction transaction;
            transaction.from = from;
            transaction.to = to;
            transaction.amount = amount;

            transactionList.Add(transaction);
        }

        internal virtual void TransferTo(Account account, decimal amount)
        {

        }

        internal virtual bool Widthdraw(Account account)
        {
            return true;
        }
    }
}
