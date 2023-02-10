namespace Schmitt_BMICalculator
{
    /// <summary>
    /// Responsible for BMI Calculation
    /// </summary>
    internal class BMI
    {
        private double bodyMassIndex;
        private double heightInInches;
        private double weightInPounds;

        internal double BodyMassIndex { get { return bodyMassIndex; } }
        internal double HeightInInches { get { return heightInInches; } }
        internal double WeightInPounds { get { return weightInPounds; } }

        /// <summary>
        /// Constructor
        /// </summary>
        internal BMI() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="height">The height for this BMI Calculation</param>
        /// <param name="weight">The weight for this BMI Calculation</param>
        internal BMI(double height, double weight)
        {
            heightInInches = height;
            weightInPounds = weight;
        }

        /// <summary>
        /// Resources for BMI calculations
        /// </summary>
        private struct BMIResources
        {
            internal const double BMI_MULTIPLIER = 703.0;
            internal const double UnderweightLowerThreshold = 18.5;
            internal const string UnderWeightOut = "Underweight";

            internal const double NormalLowerThreshold = 24.9;
            internal const string NormalOut = "Normal";

            internal const double OverweightLowerThreshold = 29.9;
            internal const string OverweightOut = "Overweight";

            internal const string ObeseOut = "Obese";
        }

        /// <summary>
        /// Calculates the BMI
        /// </summary>
        internal void CalculateBMI()
        {
            //BMI = (weightInPounds / (heightInInches * heightInInches)) * 703.0
            
            bodyMassIndex = (weightInPounds / (heightInInches * heightInInches)) * BMIResources.BMI_MULTIPLIER;
        }

        /// <summary>
        /// Obtain a wieght status from the current BMI
        /// </summary>
        /// <returns>A weight status for the current BMI calculated</returns>
        internal string ObtainWeightStatus()
        {
            switch(bodyMassIndex)
            {
                case var _ when bodyMassIndex < BMIResources.UnderweightLowerThreshold:
                    return BMIResources.UnderWeightOut;
                case var _ when bodyMassIndex < BMIResources.NormalLowerThreshold:
                    return BMIResources.NormalOut;
                case var _ when bodyMassIndex < BMIResources.OverweightLowerThreshold:
                    return BMIResources.OverweightOut;
                default:
                    return BMIResources.ObeseOut;
            }   
        }
    }
}
