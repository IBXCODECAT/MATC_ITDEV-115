using SchmittAssignment2;
using System;
using System.Text;

namespace Assignment2
{
    public class Schmitt_EmployeeApp
    {
        public static void Main(string[] args)
        {
            AssignmentInfo("Assignment 2: Employee App");

            string fname = Questions.EmployeeName("first");
            string lname = Questions.EmployeeName("last");
            double sales = Questions.EmployeeTotalSales();

            Employee employee = new Employee(fname, lname, sales);

            Console.WriteLine(employee.ToString());

            Console.ReadKey();
        }

        internal static void AssignmentInfo(string assignment)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*************************************\n\n");
            sb.Append("Name:\t\tNathan Schmitt\n");
            sb.Append("Course:\t\tITDEV-115\n");
            sb.Append("Instructor:\tJ. Christie\n");
            sb.Append("Assignment\t");
            sb.Append(assignment);
            sb.Append("\nDate:\t\t");
            sb.Append(DateTime.Now);
            sb.Append("\n\n*************************************\n");

            Console.WriteLine(sb);

        }

        internal static void Directions()
        {
            Console.WriteLine("This program will calculate the area and permiter of a rectangle");
            Console.WriteLine("All you need to do is enter the rectangle's height and width\n");
        }
    }
}