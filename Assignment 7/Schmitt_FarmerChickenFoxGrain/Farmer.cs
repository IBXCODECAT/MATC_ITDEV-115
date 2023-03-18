using System;
using System.Collections;
using System.Data.SqlTypes;

namespace Schmitt_FarmerChickenFoxGrain
{
    internal class Farmer
    {
        //Define game data
        const string FOX = "fox", CHICKEN = "chicken", GRAIN = "grain";

        internal enum Direction { North, South };

        private Direction farmer;
        private ArrayList northBank = new ArrayList(3);
        private ArrayList southBank = new ArrayList(3);

        internal ArrayList NorthBank { get { return northBank; } }
        internal ArrayList SouthBank { get { return southBank; } }
        internal Direction FarmerDirection { get { return farmer; } }

        /// <summary>
        /// Instantiate the farmer object and setup game data
        /// </summary>
        internal Farmer()
        {
            farmer = Direction.North;

            //Configure north bank data
            northBank.Clear();
            northBank.Add(FOX);
            northBank.Add(CHICKEN);
            northBank.Add(GRAIN);

            //Configure south bank data
            southBank.Clear();

            //Wipe the screen
            Console.Clear();
        }

        internal string AnimalAteFood()
        {
            if(farmer == Direction.North)
            {
                if(southBank.Contains(FOX) && southBank.Contains(CHICKEN))
                {
                    return "Oh No! The FOX ate the CHICKEN on the south bank of the river!";
                }

                if(southBank.Contains(CHICKEN) && southBank.Contains(GRAIN))
                {
                    return "Oh No! The CHICKEN ate the GRAIN on the sourth bank of the river!";
                }

                return "";
            }
            else
            {
                if(northBank.Contains(FOX) && NorthBank.Contains(CHICKEN))
                {
                    return "Oh No! The FOX ate the CHICKEN on the north bank of the river!";
                }

                if(northBank.Contains(CHICKEN) && northBank.Contains(GRAIN))
                {
                    return "Oh No! The CHICKEN ate the GRAIN on the north bank of the river!";
                }

                return "";
            }
        }

        internal bool DetermineWin()
        {
            if(farmer == Direction.South) 
            {
                if(southBank.Contains(FOX) && southBank.Contains(CHICKEN) && southBank.Contains(GRAIN))
                {
                    return true;
                }
            }

            return false;
        }

        internal string Move(string item)
        {
            if(farmer == Direction.North)
            {
                if(item != string.Empty)
                {
                    if(northBank.Contains(item))
                    {
                        northBank.Remove(item);
                        southBank.Add(item);
                    }
                    else
                    {
                        return "invalid";
                    }
                }

                farmer = Direction.South;
            }
            else
            {
                if(item != string.Empty)
                {
                    if(southBank.Contains(item))
                    {
                        northBank.Add(item);
                        southBank.Remove(item);
                    }
                    else
                    {
                        return "invalid";
                    }
                }

                farmer = Direction.North;
            }

            return "valid";
        }
    }
}
