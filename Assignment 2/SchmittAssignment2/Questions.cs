using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchmittAssignment2
{
    internal static class Questions
    {
        internal static string EmployeeName(string whichOne)
        {
            Console.WriteLine("Enter employee " + whichOne + " name: ");
            return Console.ReadLine();
        }

        internal static double EmployeeTotalSales()
        {
            Console.WriteLine("Enter employee total sales: ");
            return double.Parse(Console.ReadLine());
        }
    }
}
