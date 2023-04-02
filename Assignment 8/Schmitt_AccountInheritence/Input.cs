
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
                    string balance_formatted = string.Format("{0:C}", transaction.balance);

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
                            sb.Append(" | New Balance: ");
                            sb.Append(string.Format("{0:C}", transaction.balance));
                            sb.Append('\n');
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
                            sb.Append(" | New Balance: ");
                            sb.Append(string.Format("{0:C}", transaction.balance));
                            sb.Append('\n');
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

        /// <summary>
        /// Prompts for transfering funds betwen accounts
        /// </summary>
        /// <param name="savingsAccount">The savings account for this member</param>
        /// <param name="checkingAccount">The checking account for this member</param>
        internal static void Transfers(SavingsAccount savingsAccount, CheckingAccount checkingAccount)
        {
            Console.Clear();

            bool invalid_option = true;
            bool invalid_amount = true;

            string choice = string.Empty;
            decimal amount = 0;

            while(invalid_option)
            {
                Console.Write("Would you like to transfer savings to checking (s) or checking to savings (c)?\nSelect an option: ");
                string input = Console.ReadLine().ToUpper();

                //Check input validity
                if(input.Equals("S") || input.Equals("C"))
                {
                    choice = input;
                    invalid_option = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not an option. Expected [s], [c]!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            while(invalid_amount)
            {
                Console.Write("Please enter amount to transfer: ");

                string input = Console.ReadLine();

                try
                {
                    decimal ret = decimal.Parse(input);
                    amount = ret;
                    invalid_amount = false;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bad input, please enter a number!");
                }
            }

            StringBuilder sb = new StringBuilder();
            string amount_formatted = string.Format("{0:C}", amount);

            sb.Append("\n");

            if (choice.Equals("S"))
            {
                sb.Append("Widthdrawing ");
                sb.Append(amount_formatted);
                sb.Append(" from checking.\nDepositing ");
                sb.Append(amount_formatted);
                sb.Append(" from savings.");

                savingsAccount.TransferTo(checkingAccount, amount);
            }
            else
            {
                sb.Append("Widthdrawing ");
                sb.Append(amount_formatted);
                sb.Append(" from savings.\nDepositing ");
                sb.Append(amount_formatted);
                sb.Append(" from checking.");

                checkingAccount.TransferTo(savingsAccount, amount);
            }

            sb.Append('\n');
            sb.Append("Checking account balance: ");
            sb.Append(string.Format("{0:C}", checkingAccount.Balance));
            sb.Append('\n');
            sb.Append("Savings account balance: ");
            sb.Append(string.Format("{0:C}", savingsAccount.Balance));
            sb.Append('\n');
            sb.Append(PRESS_ANY_KEY);

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
            Console.Clear();
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
            sb.Append(PRESS_ANY_KEY);

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
