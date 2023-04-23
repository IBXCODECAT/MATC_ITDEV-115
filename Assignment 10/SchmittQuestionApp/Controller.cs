using System;
using System.Diagnostics;

namespace SchmittQuestionApp
{
    internal static class Controller
    {
        internal static void Play()
        {
            while(true)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Question {i + 1}: {QuestionBank.GetQuestion(i)}");

                    string[] ans = QuestionBank.GetAnswers(i);

                    Console.WriteLine("A: " + ans[0]);
                    Console.WriteLine("B: " + ans[1]);
                    Console.WriteLine("C: " + ans[2]);
                    Console.WriteLine("D: " + ans[3]);

                    Console.WriteLine("\nPlease select an answer: ");

                    bool invalid = true;

                    string input = null;

                    while (invalid)
                    {
                        input = Console.ReadLine().ToLower();

                        if (input.Equals("a") || input.Equals("b") || input.Equals("c") || input.Equals("d"))
                        {
                            invalid = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bad Input: Expected [A], [B], [C], [D}");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                    }

                    if(input.Equals("a"))
                    {
                        Console.WriteLine("CORRECT!");
                    }
                    else
                    {
                        Console.WriteLine("INCORRECT! (Correct answer was A)");
                        Console.WriteLine(QuestionBank.GetExplanation(i));
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("You finished the quiz!");

                if(PlayAgain() == 0)
                {
                    Environment.Exit(0);
                }
            }
        }

        internal static int PlayAgain()
        {
            Console.WriteLine("Do you want to take the quiz again (Y/N)? ");
            string input = Console.ReadLine();

            if (input.ToLower().Equals("y") || input.ToLower().Equals("yes"))
            {
                return -1;
            }
            else
            {
                return 0;
            }
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
