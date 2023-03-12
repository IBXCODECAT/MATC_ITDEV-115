namespace Schmitt_ElectionProgram
{
    internal class Schmitt_ElectionProgram
    {
        public static void Main(string[] args)
        {
            Info.DisplayInfo("Assignment 6 | Election App");

            ElectionUI electionUI = new ElectionUI();
            electionUI.MainMethod();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}