using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Schmitt_FarmerChickenFoxGrain
{
    internal static class FarmerUI
    {
        private static int BANK_HEIGHT = 8;
        private static int RIVER_HEIGHT = 7;

        const int EDGE_ITEM_OFFSET = 10;

        const int ITEM_SPACING = 5;

        /// <summary>
        /// Display the game state
        /// </summary>
        /// <param name="f">A reference to the current farmer</param>
        internal static void DisplayGameState(Farmer f)
        {
            //Set our cursor position for overlaying the items on the north bank
            Console.SetCursorPosition(EDGE_ITEM_OFFSET, BANK_HEIGHT / 2);
            Console.BackgroundColor = ConsoleColor.Green;

            //For each item on the north bank...
            for (int i = 0; i < f.NorthBank.Count; i++)
            {
                //Write them on the north bank
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(f.NorthBank[i]);

                //If this is not the last item in the list...
                if (i != f.NorthBank.Count - 1)
                {
                    //Write a "grass" patch
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int j = 0; j < ITEM_SPACING; j++) Console.Write("|");
                }
            }

            //If the farmer is on the north bank...
            if (f.FarmerDirection == Farmer.Direction.North)
            {
                //Print a "grass" patch
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int j = 0; j < ITEM_SPACING; j++) Console.Write("|");

                //Print the farmer
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("FARMER JOHN");
            }

            //Set our cursor position for overlaying the items on the south bank
            Console.SetCursorPosition(10, BANK_HEIGHT + RIVER_HEIGHT + (BANK_HEIGHT / 2));

            //For each item on the south bank...
            for(int i = 0; i < f.SouthBank.Count; i++)
            {
                //Write them on the north bank
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(f.SouthBank[i]);

                //If this is not the last item in the list...
                if (i != f.SouthBank.Count - 1)
                {
                    //Write a "grass" patch
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int j = 0; j < ITEM_SPACING; j++) Console.Write("|");
                }
            }

            //If the farmer is on the south bank...
            if (f.FarmerDirection == Farmer.Direction.South)
            {
                //Print a "grass" patch
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int j = 0; j < ITEM_SPACING; j++) Console.Write("|");

                //Print the farmer
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("FARMER JOHN");
            }

            //Set cursor position for printing items bellow the river and river banks and reset colors
            Console.SetCursorPosition(0, BANK_HEIGHT + RIVER_HEIGHT + BANK_HEIGHT + 1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Writes the north bank and sets the global BANK_HEIGHT scalable to window size
        /// </summary>
        internal static void DisplayNorthBank()
        {
            //Dynamiclly change bank and river height based on window size
            BANK_HEIGHT = Console.WindowHeight / 4;
            RIVER_HEIGHT = (Console.WindowHeight / 4) - 1;

            //If the returned value is less than 1, clamp it to 1
            if (BANK_HEIGHT < 1) BANK_HEIGHT = 1;
            if (RIVER_HEIGHT < 1) RIVER_HEIGHT = 1;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for(int y = 0; y < BANK_HEIGHT; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    Console.Write("|");
                }

                Console.Write("\n");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Writes the river
        /// </summary>
        internal static void DisplayRiver()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (int y = 0; y < RIVER_HEIGHT; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    Console.Write("~");
                }

                Console.Write("\n");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Writes the south bank
        /// </summary>
        internal static void DisplaySouthBank()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int y = 0; y < BANK_HEIGHT; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    Console.Write("|");
                }

                Console.Write("\n");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void DisplayWelcome()
        {
            Console.Clear();
        }

        internal static void Play()
        {

        }

        internal static void PlayGame()
        {

        }

        internal static string PromptForMove()
        {
            Console.WriteLine("Choose the next item the farmer should move. If you wish to choose nothing, press the enter key: ");

            SystemSounds.Exclamation.Play();
            
            bool invalid = true;
            string choice = string.Empty;

            while(invalid)
            {
                choice = Console.ReadLine().ToLower();

                if (choice == string.Empty || choice == "chicken" || choice == "fox" || choice == "grain")
                {
                    invalid = false;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Unexpected '" + choice + "' @ \\n<<<HERE! | (Expected: [\"Chicken\", \"Fox\", \"Grain\"] @ <<<HERE");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            return choice;
        }
    }
}
