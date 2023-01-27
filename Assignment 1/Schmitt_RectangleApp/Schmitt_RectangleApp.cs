using System.Text;

namespace RectangleApp
{
    /// <summary>
    /// This will be the main class for our Rectangle App
    /// </summary>
    internal static class Schmitt_RectangleApp
    {
        /// <summary>
        /// The Main method where our code will start executing
        /// </summary>
        /// <param name="args">Represents a collection of strings that can be typed in the console directly</param>
        internal static void Main(string[] args)
        {
            AssignmentInfo("Rectangle Assignment");
            Directions();

            Dimensions rectangle = new Dimensions();

            rectangle.InputHeight();
            rectangle.InputWidth();

            decimal height = rectangle.GetHeight();
            decimal width = rectangle.GetWidth();

            decimal area = Dimensions.CalculateArea(height, width);
            decimal permiter = Dimensions.CalculatePerimeter(height, width);

            Console.WriteLine("\n\nThe area of the rectangle is " + area);
            Console.WriteLine("The permimter of the rectangle is " + permiter);

            Console.WriteLine("\nPress any key to close this window...");
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