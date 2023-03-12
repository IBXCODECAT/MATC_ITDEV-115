using System;
using System.Text;

namespace Schmitt_ElectionProgram
{
    internal class ElectionUI
    {
        private int canidates;
        private Election theElection = new Election();

        /// <summary>
        /// Entry point for this class
        /// </summary>
        internal void MainMethod()
        {
            canidates = theElection.P_NUMBER_OF_CANADATES;

            for(int i = 0; i < canidates; i++)
            {
                PromptForString(i);
                PromptInt(i);
            }

            DisplayResults();
        }
        
        /// <summary>
        /// Prompt for the canadates votes
        /// </summary>
        /// <param name="canadate">The index for this canadate</param>
        internal void PromptInt(int canadate)
        {
            Console.Write("Enter the votes for canadate " + (canadate + 1) + ": ");

            bool invalid = true;
            int input = -1;

            while(invalid)
            {
                try
                {
                    string res = Console.ReadLine()!;
                    input = int.Parse(res);
                    invalid = false;
                }
                catch(Exception)
                {
                    Console.WriteLine("Incorrect date entered. Please enter a numerical value.");
                }
            }

            theElection.SetVote(input, canadate);
        }


        /// <summary>
        /// Prompt for the canadates names
        /// </summary>
        /// <param name="canadate">The index of this canadate</param>
        internal void PromptForString(int canadate)
        {
            Console.Write("Enter name for canadate " + (canadate + 1) + ": ");
            string name = Console.ReadLine()!;

            theElection.SetCanadateName(name, canadate);
        }

        /// <summary>
        /// Display the results of the election
        /// </summary>
        internal void DisplayResults()
        {
            Console.Clear();

            StringBuilder sb = new StringBuilder();
            int totalvotes = theElection.TotalVotes();

            sb.Append("Name\t\t\tVotes\t\tPercentage\n");

            for(int i = 0; i < canidates; i++)
            {
                string name = theElection.GetCanadateName(i);
                int votes = theElection.GetCanadateVotes(i);

                double percentage = Math.Round(((double)votes / (double)totalvotes) * 100, 2);

                sb.Append(name).Append("\t\t\t").Append(votes).Append("\t\t").Append(percentage).Append("%\n");
            }

            string winner = theElection.FindWinner();

            sb.Append("\n\nThe winner is: ").Append(winner).Append("!");

            Console.WriteLine(sb.ToString());
        }
    }
}
