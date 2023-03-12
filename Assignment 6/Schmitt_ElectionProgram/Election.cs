using System;

namespace Schmitt_ElectionProgram
{
    internal class Election
    {
        private const int NUMBER_OF_CANADATES = 5;

        private string[] canadatesNames = new string[NUMBER_OF_CANADATES];
        private int[] votes = new int[NUMBER_OF_CANADATES];

        internal int P_NUMBER_OF_CANADATES { get { return NUMBER_OF_CANADATES; } }

        /// <summary>
        /// Blank Constrcutor added in assignment reqs (this does nothing)
        /// </summary>
        internal Election() { }

        internal string FindWinner()
        {
            string winner = string.Empty;
            int currentMaxVotes = 0;

            for(int i = 0; i < NUMBER_OF_CANADATES; i++)
            {
                if (votes[i] > currentMaxVotes)
                {
                    currentMaxVotes = votes[i];
                    winner = canadatesNames[i];
                }
            }

            return winner;
        }

        internal string GetCanadateName(int index)
        {
            return canadatesNames[index];
        }

        internal int GetCanadateVotes(int index)
        {
            return votes[index];
        }

        internal void SetCanadateName(string name, int index)
        {
            canadatesNames[index] = name;
        }

        internal void SetVote(int cVotes, int index)
        {
            votes[index] = cVotes;
        }

        internal int TotalVotes()
        {
            int totalVotes = 0;

            foreach(int voteCount in votes)
            {
                totalVotes += voteCount;
            }

            return totalVotes;
        }
    }
}
