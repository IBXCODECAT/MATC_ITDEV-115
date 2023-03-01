namespace Schmitt_MagicPCApp
{
    internal static class MagicPCUI
    {
        /// <summary>
        /// ?
        /// </summary>
        internal static void Start()
        {
            bool programActive = true;

            while (programActive)
            {
                UserInstructions();
                string test = GetUserQuestion();

                if (test != string.Empty) RespondToQuestion();
                else programActive = false;
            }

            Console.WriteLine("Program Exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Display the instructions
        /// </summary>
        internal static void UserInstructions()
        {
            Console.Clear();
            Console.WriteLine("Enter your question, if you dare!\n\n");
        }

        /// <summary>
        /// Get the question from a user
        /// </summary>
        /// <returns>User Question</returns>
        internal static string GetUserQuestion()
        {
            string question = Console.ReadLine()!;

            return question;
        }

        /// <summary>
        /// Responds to the user's question
        /// </summary>
        internal static void RespondToQuestion()
        {
            string output = MagicPC.GetUserAnswer();

            Console.WriteLine(output);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
