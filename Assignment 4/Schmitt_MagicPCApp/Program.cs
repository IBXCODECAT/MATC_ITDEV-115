namespace Schmitt_MagicPCApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Info.DisplayInfo("Assignment 4 | MagicPCApp");
            Console.WriteLine("\nPress any key to continue...");
            
            Console.ReadKey();

            MagicPCUI.Start();
        }
    }
}