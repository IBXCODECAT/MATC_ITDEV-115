using System;

namespace SchmittQuestionApp
{
    internal static class Controller
    {
        internal static void Play()
        {
            while(true)
            {

            }
        }

        internal static int PlayAgain()
        {
            return 0;
        }

        internal static void Welcome()
        {
            //Console stuff
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Minecraft quiz! Here we will ask you some questions and you should answer them as best as you can!");
            Console.WriteLine("Press any key to continue...");

            //initialize the question bank
            QuestionBank.ReadQuestionFile();

            //More console stuffs
            Console.ReadKey();
            Console.Clear();

            //Play the game
            Play();
        }
    }
}
