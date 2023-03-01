using System;

namespace Schmitt_StudentStudyApp
{
    internal class Schmitt_StudentStudyApp
    {
        public static void Main(string[] args)
        {
            Info.DisplayInfo("Assignment 5 | Student Study App");

            StudentUI.UIMain();

            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
        }
    }
}