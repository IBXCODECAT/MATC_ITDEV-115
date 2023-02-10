using System.Text;

namespace Schmitt_BMICalculator
{
    /// <summary>
    /// Controls the UI for this application
    /// </summary>
    internal class BMIUI
    {
        /// <summary>
        /// Data types for our BMI Prompt
        /// </summary>
        private struct DATA_TYPES
        {
            internal const string WEIGHT = "w";
            internal const string HEIGHT = "h";
        }

        /// <summary>
        /// Entry point for a BMIUI instnace
        /// </summary>
        internal void BMIMainModule()
        {
            UserDirections();

            double height = RequestUserData(DATA_TYPES.HEIGHT);
            double weight = RequestUserData(DATA_TYPES.WEIGHT);

            BMI i_bmi = new BMI(height, weight);
            i_bmi.CalculateBMI();

            DisplayResults(i_bmi);

            //Press any key to continue...
            Console.ReadKey();
        }

        /// <summary>
        /// Displays the results of our BMI Calculation
        /// </summary>
        /// <param name="aUserBMI">An instance of a BMI object</param>
        internal void DisplayResults(BMI aUserBMI)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Empty)
                .Append("For your height of ")
                .Append(aUserBMI.HeightInInches)
                .Append(" inches and your weight of ")
                .Append(aUserBMI.WeightInPounds)
                .Append(" pounds, your BMI is ")
                .Append(aUserBMI.BodyMassIndex)
                .Append(" which gives you a BMI status of ")
                .Append(aUserBMI.ObtainWeightStatus())
                .Append(".");

            string output = sb.ToString();

            Console.WriteLine(output);
        }

        /// <summary>
        /// Requests data from the end user
        /// </summary>
        /// <param name="dataType">The type of data we want to collect</param>
        /// <returns>The data the end user has entered</returns>
        internal double RequestUserData(string dataType)
        {
            //Output an appropriate prompt for the data we want to collect
            switch(dataType)
            {
                case DATA_TYPES.HEIGHT:
                    Console.Write("Please enter your height in inches: ");
                    break;
                case DATA_TYPES.WEIGHT:
                    Console.Write("Please enter your weight in pounds: ");
                    break;
            }

            //Get valid input from the user
            while(true)
            {
                try
                {
                    return Double.Parse(Console.ReadLine()!);
                }
                catch
                {
                    Console.Write("There was an error parsing your input. Try again: ");
                }
            }
        }

        /// <summary>
        /// Displays the initial directions to the user
        /// </summary>
        internal void UserDirections()
        {
            Console.WriteLine("This program will calcualate your Body Mass Index (BMI) using your height and weight.\n");
        }
    }
}
