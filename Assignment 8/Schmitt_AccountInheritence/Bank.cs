using Schmitt_AccountInheritence.Accounts;
using System;

namespace Schmitt_AccountInheritence
{
    internal static class Bank
    {
        //Fields
        private static CheckingAccount checking;
        private static SavingsAccount savings;

        /// <summary>
        /// The entry point to the banking application
        /// </summary>
        internal static void BankingApp()
        {
            Input.Introduction();
            
            SetupBankingAccounts();
            ModifyAccounts();
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

        /// <summary>
        /// Contains the code for the Account Interactions Loop
        /// </summary>
        internal static void ModifyAccounts()
        {
            //We will run this code forever until the application is terminated
            while (true)
            {
                //This should probably be a preloaded enum, but I am too lazy to implement that for a homework assignment where it isn't required
                const int TRANSFER_FUNDS = 1, LOG_TRANSACTIONS = 2, APPLICATION_QUIT = 3;

                int choice = Input.Menu();

                //Terminate the app with exit code 0 if the user chooses to quit
                if (choice == APPLICATION_QUIT) Environment.Exit(0);

                if (choice == TRANSFER_FUNDS)
                {
                    Input.Transfers(savings, checking);
                    continue; //Continues are usaully a bad programming practice, but for this method's scope and delimeter depth, they make the code neater
                }

                if (choice == LOG_TRANSACTIONS)
                {
                    Input.PrintTransactions(checking);
                    Input.PrintTransactions(savings);

                    continue; //Continues are usaully a bad programming practice, but for this method's scope and delimeter depth, they make the code neater
                }
            }
        }

        /// <summary>
        /// Initial setup for banking accounts
        /// </summary>
        internal static void SetupBankingAccounts()
        {
            //Request account holder name
            string holder = Input.AccountHolder();

            //Request starting balances
            decimal c_balance = Input.StartingBalance(checking);
            decimal s_balance = Input.StartingBalance(savings);

            //Create accounts for this member
            CreateAccount(holder, c_balance, typeof(CheckingAccount));
            CreateAccount(holder, s_balance, typeof(SavingsAccount));

            //Welcome the member
            Input.WelcomeMember(holder);
        }
    }
}
