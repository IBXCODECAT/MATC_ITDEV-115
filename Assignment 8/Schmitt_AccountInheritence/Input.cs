
using Schmitt_AccountInheritence.Accounts;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace Schmitt_AccountInheritence
{
    internal static class Input
    {
        const string PRESS_ANY_KEY = "Press any key to continue...";

        /// <summary>
        /// Requestst the name of the account holder
        /// </summary>
        /// <returns>The name of the account holder</returns>
        internal static string AccountHolder()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter your name: ");

                string input = Console.ReadLine();

                if (input.Length > 0)
                {
                    Console.Clear();
                    return input;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid name, length may not be less than or equal to zero!");
            }
        }

        /// <summary>
        /// Displays an introductory message to the user
        /// </summary>
        internal static void Introduction()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Welcome to Nathan Town Bank!");
            sb.Append("\n");
            sb.AppendLine("This applicaiton will allow you to transfer funds between your checking and savings accounts.");
            sb.Append("\n");
            sb.AppendLine("To begin using our services you will need to create an account. Please enter the required information as requested.\n");
            sb.Append(PRESS_ANY_KEY);

            Console.WriteLine(sb.ToString());

            //Wait for user Input
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Displays the transaction menu to the user
        /// </summary>
        /// <returns>The number for the option the user chose [1] = transfer, [2] = Print, [3] = Quit</returns>
        internal static int Menu()
        {
            Console.Clear();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*******************");
            sb.AppendLine("Transfer Funds..[1]");
            sb.AppendLine("Print History...[2]");
            sb.AppendLine("Quit............[3]");
            sb.AppendLine("*******************");

            string menu = sb.ToString();

            while (true)
            {
                Console.Clear();

                Console.WriteLine(menu);
                Console.Write("Enter an option: ");

                string input = Console.ReadLine();

                try
                {
                    int ret = int.Parse(input);

                    //Is the number entered a valid option?
                    if (ret >= 1 && ret <= 3)
                    {
                        Console.Clear();
                        return ret;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid menu item, expected [1], [2], [3]!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(PRESS_ANY_KEY);
                        Console.ReadKey();
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid menu item, expected [1], [2], [3]!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(PRESS_ANY_KEY);
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Prints a list of all transactions associated with an account
        /// </summary>
        /// <param name="account">The account to print the transactiosn for</param>
        internal static void PrintTransactions(Account account)
        {
            StringBuilder sb = new StringBuilder();
            Type accountType = account.GetType();

            if (account.Transactions.Count <= 0)
            {
                sb.Append("There are no transactions listed on ");
                sb.Append(account.AccountHolder);
                sb.Append("'s ");
                sb.Append(accountType.Name);
                sb.Append('\n');
            }
            else
            {
                //For each transaction logged on this account...
                foreach (Account.Transaction transaction in account.Transactions)
                {
                    string transferAmount_formatted = string.Format("{0:C}", transaction.amount);

                    sb.Append(accountType.Name);
                    sb.Append(": ");

                    //If both the sending and recieving accounts were null, we know that this was an instantiation
                    if (transaction.to == null && transaction.from == null)
                    {
                        sb.Append("A ");
                        sb.Append(accountType.Name);
                        sb.Append(" was created for ");
                        sb.Append(account.AccountHolder);
                        sb.Append(" with a starting balance of ");
                        sb.Append(transferAmount_formatted);
                        sb.Append('\n');
                    }
                    else if(transaction.amount <= 0)
                    {
                        sb.AppendLine("This transaction failed beacause the widthrawing account has insufficient funds or is hitting a set wdithdraw limit.");
                    }
                    else
                    {
                        //Is the account in question a CheckingAccount?
                        if (accountType == typeof(CheckingAccount))
                        {
                            //Is the widthdrawing account a CheckignAccount?
                            if (transaction.from is CheckingAccount)
                            {
                                sb.Append("Widthdraw ");
                                sb.Append(transferAmount_formatted);
                                sb.Append(" from ");
                            }
                            else
                            {
                                sb.Append("Deposit ");
                                sb.Append(transferAmount_formatted);
                                sb.Append(" into ");
                            }

                            sb.Append(account.AccountHolder);
                            sb.Append("'s ");
                            sb.Append(accountType.Name);
                            sb.Append(".\n");
                        }
                        else
                        {
                            //Is the widthdrawing acount a SavingsAccount?
                            if (transaction.from is SavingsAccount)
                            {
                                sb.Append("Widthdraw ");
                                sb.Append(transferAmount_formatted);
                                sb.Append(" from ");
                            }
                            else
                            {
                                sb.Append("Deposit ");
                                sb.Append(transferAmount_formatted);
                                sb.Append(" into ");
                            }

                            sb.Append(account.AccountHolder);
                            sb.Append("'s ");
                            sb.Append(accountType.Name);
                            sb.Append(".\n");
                        }
                    }
                }
            }

            sb.Append("\n\n");
            sb.AppendLine(PRESS_ANY_KEY);

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }

        
        /// <summary>
        /// Let's the user set a starting balance for their account
        /// </summary>
        /// <param name="account">The account to set a starting balance for</param>
        /// <returns>The amount the user has entered</returns>
        internal static decimal StartingBalance(Account account)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if(account is SavingsAccount)
                {
                    Console.Write("Please enter starting amount for savings: ");
                }
                else
                {
                    Console.Write("Please enter starting amount for checking: ");
                }

                string input = Console.ReadLine();

                try
                {
                    decimal ret = decimal.Parse(input);
                    Console.Clear();
                    return ret;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bad input, please enter a number!");
                }
            }
        }


        internal static void Transfers(SavingsAccount savingsAccount, CheckingAccount checkingAccount)
        {
            savingsAccount.TransferTo(checkingAccount, 220);
            savingsAccount.TransferTo(checkingAccount, 12);
            checkingAccount.TransferTo(savingsAccount, 5);
        }

        /// <summary>
        /// Prints a message welcoming a member to the application
        /// </summary>
        /// <param name="member">The name of the member to welcome</param>
        internal static void WelcomeMember(string member)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Welcome to Nathan Town Bank ");
            sb.Append(member);
            sb.Append("!");
            sb.Append("\n");
            sb.Append("Your accounts have been created and are ready for transactions!");
            sb.Append("\n");
            sb.Append("Press [ENTER] to continue...");

            Console.WriteLine(sb.ToString());
        }
    }
}
