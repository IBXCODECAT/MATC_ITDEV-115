using Schmitt_AccountInheritence.Accounts;
using System;

namespace Schmitt_AccountInheritence
{
    internal static class Bank
    {
        //Fields
        private static CheckingAccount checking;
        private static SavingsAccount savings;

        internal static void BankingApp()
        {
            Input.Introduction();

            SetupBankingAccounts();

            while(true)
            {
                const int TRANSFER_FUNDS = 1, LOG_TRANSACTIONS = 2, APPLICATION_QUIT = 3;

                int choice = Input.Menu();

                //Terminate the app with exit code 0 if the user chooses to quit
                if(choice == APPLICATION_QUIT) Environment.Exit(0);

                if(choice == TRANSFER_FUNDS)
                {
                    continue;
                }

                if(choice == LOG_TRANSACTIONS)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// Create a single account with known information
        /// </summary>
        /// <param name="holder">The account holder for this account</param>
        /// <param name="balance">The balance for this account</param>
        /// <param name="type">The type for this account</param>
        internal static void CreateAccount(string holder, decimal balance, Type type)
        {
            if(type == typeof(CheckingAccount))
            {
                checking = new CheckingAccount(holder, balance, type);
            }
            else
            {
                savings = new SavingsAccount(holder, balance, type);
            }
        }

        internal static void ModifyAccounts()
        {

        }

        /// <summary>
        /// Initial setup for banking accounts
        /// </summary>
        internal static void SetupBankingAccounts()
        {
            string holder = Input.AccountHolder();

            decimal c_balance = Input.StartingBalance(checking);
            decimal s_balance = Input.StartingBalance(savings);

            CreateAccount(holder, c_balance, typeof(CheckingAccount));
            CreateAccount(holder, s_balance, typeof(SavingsAccount));
        }
    }
}
