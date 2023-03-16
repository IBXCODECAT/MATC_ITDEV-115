using System;

namespace Schmitt_FarmerChickenFoxGrain
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Info.DisplayInfo("Assignment 7 | Farmer Chicken Grain Game");

            Farmer f = new Farmer();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
