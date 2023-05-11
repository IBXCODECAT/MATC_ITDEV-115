using System;

namespace SchmittFinal
{
    internal static class GradesUI
    {
        internal static void MainMethod()
        {

            string error = Students.PopulateStudents(@"grades.txt");

            if(string.IsNullOrEmpty(error))
            {
                DisplayInfo();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error);
                Console.ForegroundColor= ConsoleColor.White;
            }
        }

        private static void DisplayInfo()
        {
            Console.WriteLine("Student id\t\tLast Name\t\tAverage\t\tGrade");

            for (int index = 0; index < Students.ListLength; index++)
            {
                Console.WriteLine($" {Students.StudentID(index)}\t\t {Students.StudentLastName(index)}   \t\t {Students.StudentAverage(index)}\t\t  {Students.StudentGrade(index)}");
            }
        }
    }
}
