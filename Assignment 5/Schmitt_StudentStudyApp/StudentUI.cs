using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Schmitt_StudentStudyApp
{
    internal static class StudentUI
    {
        private static string[] days = 
        {
            "Sunday  ",
            "Monday  ",
            "Tuesday ",
            "Wednsday",
            "Thursday",
            "Friday  ",
            "Saturday"
        };

        internal static void UIMain()
        {
            Student student = new Student();

            FillHours(student);

            bool invalidResponses = true;

            string name = string.Empty;
            int id = 0;

            //Get the users name
            Console.Write("Please Enter your name: ");
            name = Console.ReadLine()!;

            while (invalidResponses)
            {
                try
                {
                    //Get the users student ID
                    Console.Write("Please Enter your student ID: ");
                    id = int.Parse(Console.ReadLine()!);

                    invalidResponses = false;
                }
                catch
                {
                    Console.WriteLine("Bad Input. Student ID must be anumber. Please try again...");
                }
            }

            student.Name = name;
            student.ID = id;

            for (int i = 0; i < days.Length; i++)
            {
                invalidResponses = true;

                double hrs = 0;

                while(invalidResponses)
                {
                    try
                    {
                        //Get the users hours
                        Console.Write("Enter the number of hours you studied for ITDEV-115 on " + days[i] + ": ");
                        hrs = int.Parse(Console.ReadLine()!);

                        invalidResponses = false;
                    }
                    catch
                    {
                        Console.WriteLine("Must enter a number");
                    }

                }
                student.EnterHours(i, hrs);
            }


            DisplayData(student);
            DisplayAverage(student);
        }

        internal static void DisplayAverage(Student student)
        {
            double avg = student.CalculateAvg();

            Console.WriteLine("The average number of hours you studied per day was: " + avg);
        }

        internal static void DisplayData(Student student)
        {
            Console.Clear();

            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("ID: " + student.ID);

            Console.WriteLine("\n\nThe number of hours you have studied this week are shown bellow:\n");

            for(int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i] + "\t\t" + student.GetNumberHours()[i]);
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// Zerofill Hours
        /// </summary>
        /// <param name="student">The student to zerofill</param>
        internal static void FillHours(Student student)
        {
            for(int i = 0; i < days.Length; i++)
            {
                student.EnterHours(i, 0);
            }
        }

        internal static string GetName(Student student)
        {
            return student.Name;
        }

        internal static int GetStudentID(Student student)
        {
            return student.ID;
        }

    }
}
