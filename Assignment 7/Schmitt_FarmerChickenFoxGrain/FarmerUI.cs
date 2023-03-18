using System;
using System.Collections;
using System.Media;

namespace Schmitt_FarmerChickenFoxGrain
{
    internal static class FarmerUI
    {
        //Store graphic element heights dynamically (dynamic graphics settings)
        private static int BANK_HEIGHT = 8;
        private static int RIVER_HEIGHT = 7;

        //Define display settings
        const int EDGE_ITEM_OFFSET = 10, ITEM_SPACING = 5;

        //Define game data
        const string FOX = "fox", CHICKEN = "chicken", GRAIN = "grain";

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
        /// Displays the graphic element "north bank"
        /// </summary>
        private static void DisplayNorthBank()
        {
            //Dynamiclly change bank and river height based on window size
            BANK_HEIGHT = Console.WindowHeight / 4;
            RIVER_HEIGHT = (Console.WindowHeight / 4) - 1;

            //If the returned value is less than 1, clamp it to 1
            if (BANK_HEIGHT < 1) BANK_HEIGHT = 1;
            if (RIVER_HEIGHT < 1) RIVER_HEIGHT = 1;

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
        /// Displays the graphic element "river"
        /// </summary>
        private static void DisplayRiver()
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
        /// Displays the graphic element "south bank"
        /// </summary>
        private static void DisplaySouthBank()
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
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("GAME INSTRUCTIONS (PRESS <ENTER> TO CONTINUE!\n\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This game is known as \"the farmer game\". It is a popular logic puzzle for programmers to recreate.");
            Console.WriteLine("The object of the game is to get the farmer, fox, chicken, and grain to the south side of the river.");
            Console.WriteLine("Sounds easy right? Well this task is made very difficult for farmer john because of the following:\n");

            Console.WriteLine("- If the chicken and grain are left unsupervised, the chicken will eat the grain.");
            Console.WriteLine("- If the fox and chicken are left unsupervised, the fox will eat the chicken.");

            Console.WriteLine("\n\nYour task is to help farmer john bring all of his food and livestock across the river without incident.");

            SystemSounds.Exclamation.Play();

            Console.ReadKey();
        }

        /// <summary>
        /// Plays the game, sets the intial game state, and sets the global dynamic graphics settings
        /// </summary>
        internal static void Play()
        {
            Farmer farmer = new Farmer();
            
            while(true)
            {
                //Display Game Elements
                Console.Clear();
                DisplaySouthBank();
                DisplayRiver();
                DisplayNorthBank();
                DisplayGameState(farmer);

                //Play a sound when the board has finished buffering
                SystemSounds.Hand.Play();

                //Make a move
                bool moveInvalid = true;
                while(moveInvalid)
                {
                    //Get move info
                    string move = PromptForMove();
                    string moveTest = farmer.Move(move);

                    //Check move validity
                    if (moveTest.Equals("valid"))
                    {
                        moveInvalid = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Move \"" + move + "\". The farmer needs to be on the other side of the rvier to move this item.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                //Have animals eat food
                string ateFood = farmer.AnimalAteFood();

                //If the animals ate some sort of food
                if(!ateFood.Equals(string.Empty))
                {
                    //Redisplay the game state
                    Console.Clear();
                    DisplayNorthBank();
                    DisplayRiver();
                    DisplaySouthBank();
                    DisplayGameState(farmer);

                    //Display the loss message/condition
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(ateFood);

                    break;
                }

                //Did we win?
                if (farmer.DetermineWin())
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("YOU DID IT!");

                    break;
                }
            }
        }

        /// <summary>
        /// Handles the logic for the "Play - Play Again" loop
        /// </summary>
        internal static void PlayGame()
        {
            //Display the welcome message/instructions
            DisplayWelcome();

            //Game Loop
            bool playAgain = true;
            do
            {
                //Play the game
                Play();

                //Play again?
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Game Over, would you like to play again [default Y](Y/N)?: ");
                Console.BackgroundColor = ConsoleColor.Black;
                string input = Console.ReadLine().ToUpper();

                if (input.Equals("N"))
                {
                    playAgain = false;
                }

            }
            while (playAgain);
        }

        internal static string PromptForMove()
        {
            Console.SetCursorPosition(0, BANK_HEIGHT + RIVER_HEIGHT + BANK_HEIGHT + 2);

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
