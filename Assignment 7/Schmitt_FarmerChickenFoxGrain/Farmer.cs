using System;
using System.Collections;
using System.Data.SqlTypes;

namespace Schmitt_FarmerChickenFoxGrain
{
    internal class Farmer
    {
        internal enum Direction { North, South };

        private Direction farmer;
        private ArrayList northBank = new ArrayList(3);
        private ArrayList southBank = new ArrayList(3);

        internal ArrayList NorthBank { get { return northBank; } }
        internal ArrayList SouthBank { get { return southBank; } }
        internal Direction FarmerDirection { get { return farmer; } }

        internal Farmer()
        {
            bool keepPlaying = true;

            while(keepPlaying)
            {
                northBank.Clear();
                northBank.Add("FOX");
                northBank.Add("CHICKEN");
                northBank.Add("GRAIN");

                SouthBank.Clear();

                while (true)
                {
                    FarmerUI.DisplayNorthBank();
                    FarmerUI.DisplayRiver();
                    FarmerUI.DisplaySouthBank();

                    FarmerUI.DisplayGameState(this);

                    string move = FarmerUI.PromptForMove();

                    Move(move);
                }
            }
        }

        internal string AnimalAteFood()
        {
            return "";
        }

        internal bool DetermineWin()
        {
            return false;
        }

        internal string Move(string item)
        {
            switch(item)
            {
                case "fox":

                    break;

                case "chicken":
                    break;

                default:

                    break;
            }


            if(farmer == Direction.North)
            {
                farmer = Direction.South;
            }
            else
            {
                farmer = Direction.North;
            }

            return "";
        }
    }
}
