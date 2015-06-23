using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.CSharp
{
    public class Requirements3
    {
        /// <summary>
        /// Area of a triangle calculated based on Heron's Forumla
        /// http://www.mathopenref.com/heronsformula.html
        /// </summary>
        /// <param name="side1">Side 1 of the triangle</param>
        /// <param name="side2">Side 2 of the triangle</param>
        /// <param name="side3">Side 3 of the triangle</param>
        /// <returns></returns>
        public double TriangleArea(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new InvalidTriangleException("Inputs cannot be negative");
            }

            var perimeter = (side1 + side2 + side3) / 2;
            var area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));

            if (area.Equals(Double.NaN))
            {
                throw new InvalidTriangleException("Inputs form an invalid triangle");
            }

            return area;
        }
    }

    /// <summary>
    /// Custom Exception for Triangle Calculations
    /// </summary>
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException() : base()
        {
        }

        public InvalidTriangleException(string message) : base(message)
        {
        }
    }
}