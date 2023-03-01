namespace Schmitt_MagicPCApp
{
    internal static class MagicPC
    {
        /// <summary>
        /// Get the user answer
        /// </summary>
        /// <returns>An answer</returns>
        internal static string GetUserAnswer()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(0, 9);

            switch(randomNumber)
            {
                case 0:
                    return "Yes";
                case 1:
                    return "No";
                case 2:
                    return "It does not appear likely";
                case 3:
                    return "All signs point to yes";
                case 4:
                    return "The answer is too cloudy, please try again later";
                case 5:
                    return "It is certain";
                case 6:
                    return "Impossible";
                case 7:
                    return "Seems plausable...";
                default:
                    return "Maybe";
            }
        }
    }
}
