using System;

namespace RectangleApp
{
    /// <summary>
    /// This class is responsible for calculating the things
    /// </summary>
    internal class Dimensions
    {
        #region Fields
        decimal width;
        decimal height;
        #endregion Fields

        /// <summary>
        /// Empty Constructor (Unused in this assignment)
        /// </summary>
        internal Dimensions() { }

        #region Getters

        /// <summary>
        /// Gets the height of this object
        /// </summary>
        /// <returns>The height field for this object</returns>
        internal decimal GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Gets the width of this object
        /// </summary>
        /// <returns>The width field for this object</returns>
        internal decimal GetWidth()
        {
            return width;
        }
        #endregion Getters

        #region Setters
        /// <summary>
        /// Set the height of the rectangle from user's input
        /// </summary>
        internal void InputHeight()
        {
            Console.Write("Please enter the height of the rectangle: ");
            height = Convert.ToDecimal(Console.ReadLine());
        }

        /// <summary>
        /// Set the width of the rectangle from the user's input
        /// </summary>
        internal void InputWidth()
        {
            Console.Write("Please enter the width of the rectangle: ");
            width = Convert.ToDecimal(Console.ReadLine());
        }
        #endregion Setters

        #region Helper Methods
        
        /// <summary>
        /// Calculates the area of the rectangle
        /// </summary>
        /// <param name="width">The width of the rectangle</param>
        /// <param name="height">The height of the rectangle</param>
        /// <returns>A decimal representing the area of the rectangle</returns>
        internal static decimal CalculateArea(decimal width, decimal height)
        {
            return width * height;
        }

        /// <summary>
        /// Calculates the permieter of a rectangle
        /// </summary>
        /// <param name="width">The width of the rectangle</param>
        /// <param name="height">The height of the rectangle</param>
        /// <returns>A decimal representing the permimeter of the rectangle</returns>
        internal static decimal CalculatePerimeter(decimal width, decimal height)
        {
            return (width * 2) + (height * 2);
        }
        #endregion Helper Methods
    }
}
