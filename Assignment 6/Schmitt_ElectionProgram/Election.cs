using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schmitt_ElectionProgram
{
    internal class Election
    {
        private const int NUMBER_OF_CANADATES = 2;

        private string[] canadatesNames;
        private int[] votes;

        internal int P_NUMBER_OF_CANADATES { get; }

        internal Election()
        {

        }

        internal string FindWinner()
        {
            if (votes[0] > votes[1])
            {
                return canadatesNames[0];
            }

            return canadatesNames[1];
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
