using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchmittFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info.DisplayInfo("StudentListFinal");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            GradesUI.MainMethod();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
