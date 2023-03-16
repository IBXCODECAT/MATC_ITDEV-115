using System.Collections;

namespace Schmitt_FarmerChickenFoxGrain
{
    internal class Farmer
    {
        internal enum Direction { North, South };

        private Direction farmer;
        private ArrayList northBank;
        private ArrayList southBank;

        internal ArrayList NorthBank { get { return northBank; } }
        internal ArrayList SouthBank { get { return southBank; } }
        internal Direction FarmerDirection { get { return farmer; } }

        internal string AnimalAteFood()
        {

        }

        internal bool DetermineWin()
        {

        }

        internal string Move(string item)
        {

        }
    }
}
