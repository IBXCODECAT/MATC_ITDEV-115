using System.Text;

namespace Schmitt_StudentStudyApp
{
    internal static class Info
    {
        internal static void DisplayInfo(string assignment)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Empty)
                .Append("*********************************************\n\n")
                .Append("Name:\t\tNathan Schmitt\n")
                .Append("Course:\t\tITDEV-115\n")
                .Append("Instructor:\tJ. Christie\n")
                .Append("Assignment\t")
                .Append(assignment)
                .Append("\nDate:\t\t")
                .Append(DateTime.Now)
                .Append("\n\n*********************************************\n");

            string output = sb.ToString();

            Console.WriteLine(output);
        }
    }
}
