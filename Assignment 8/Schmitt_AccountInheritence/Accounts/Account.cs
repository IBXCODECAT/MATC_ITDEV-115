using System;
using System.Collections.Generic;

namespace Schmitt_AccountInheritence.Accounts
{
    internal abstract class Account
    {
        //
        /// <summary>
        /// Instead of a string for the account type as explained in the instructions I have opted for a Type. This keeps code clean and less prone to error
        /// especially in any control structures where comparing strings
        /// </summary>
        internal Type AccountType { get { return accountType; } private set { accountType = value; } }
        internal decimal Balance { get { return balance; } set { balance = value; } }
        internal string AccountHolder { get { return accountHolder; } set { accountHolder = value; } }

        /// <summary>
        /// Instead of an ArrayList of strings, I am using a List of Transactions (a custom data structure contianing information about the transaction)
        /// </summary>
        internal List<Transaction> Transactions { get { return transactionList; } private set { transactionList = value; } }

        //Fields
        private Type accountType;
        private decimal balance;
        private string accountHolder;

        /// <summary>
        /// Instead of a string for the account type as explained in the instructions I have opted for a Type. This keeps code clean and less prone to error
        /// especially in any control structures where comparing strings
        /// </summary>
        private List<Transaction> transactionList = new List<Transaction>();

        /// <summary>
        /// Transaction data structure containing the amount and the accounts involved in the transfer
        /// 
        /// This struct was not required in the assignment, but I am using it to keep my data more organized.
        /// This struct will take the place of any transaction strings in the transactions list as explained in the assignment instructions.
        /// </summary>
        internal struct Transaction
        {
            internal Account from;      //Account sending money
            internal Account to;        //Account recieving money
            internal decimal amount;    //Amount sent in transaction
            internal decimal balance;   //The balance after the transaction was completed
        }

        /// <summary>
        /// Account Constructor
        /// </summary>
        /// <param name="accountHolder">This account's name</param>
        /// <param name="balance">This account's balance</param>
        /// <param name="accountType">This account's type</param>
        internal Account(string accountHolder, decimal balance, Type accountType)
        {
            this.accountHolder = accountHolder;
            this.balance = balance;
            this.accountType = accountType;
        }

        /// <summary>
        /// Deposits money into this account
        /// </summary>
        /// <param name="amount">The amount of money to deposit</param>
        internal void Deposit(decimal amount)
        {
            //Add money to this account's balance
            balance += amount;
        }

        /// <summary>
        /// Log a transaction in an account's transactions list
        /// 
        /// This method's parameters have been modified to acomidate the data struct (Transaction) I made.
        /// I did this to make the code more organized because strings are easy to mess up, especially in if statments.
        /// </summary>
        /// <param name="from">The account being widthdrawn from</param>
        /// <param name="to">The account recieving a deposit</param>
        /// <param name="amount">The sum of the transfer</param>
        internal void LogTransaction(Account from, Account to, decimal amount)
        {
            Transaction transaction;
            transaction.from = from;
            transaction.to = to;
            transaction.amount = amount;
            transaction.balance = balance;

            transactionList.Add(transaction);
        }

        /// <summary>
        /// Transfer funds between two accounts
        /// </summary>
        /// <param name="account">The account to transfer funds too</param>
        /// <param name="amount">The amount to transfer</param>
        internal abstract void TransferTo(Account account, decimal amount);

        /// <summary>
        /// Widthdraw money from this account
        /// </summary>
        /// <param name="amount">The amount of money to widthdraw</param>
        /// <returns>True if the operation succeeded</returns>
        internal virtual bool Widthdraw(decimal amount)
        {
            //If this widthdraw would make our balance go bellow zero, skip execution and return false
            if (balance - amount < 0) return false;

            //Subtract money from this account's balance
            balance -= amount;

            //Return true when the operation succeeds
            return true;
        }
    }
}
