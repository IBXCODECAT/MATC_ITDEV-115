using Schmitt_BMICalculator;

namespace BMIApp
{
    internal class Schmitt_BMICalculator
    {
        /// <summary>
        /// Entry point of the program, code will start executing here
        /// </summary>
        /// <param name="args">CLI Args</param>
        public static void Main(string[] args)
        {
            Display.DisplayInfo("Assignment 3 | BMI Calculator");

            new BMIUI().BMIMainModule();
        }
    }
}