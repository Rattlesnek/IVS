using System;

namespace MathLib
{
    /// <summary>
    /// Class containing math operations for calculator.
    /// </summary>
    public static class MathOp
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="a">First term</param>
        /// <param name="b">Second term</param>
        /// <returns>Sum</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="a">Minuend</param>
        /// <param name="b">Subtrahend</param>
        /// <returns>Difference</returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="a">First factor</param>
        /// <param name="b">Second factor</param>
        /// <returns>Product</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        
        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="a">Divident</param>
        /// <param name="b">Divisor</param>
        /// <returns>Quotient</returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Calculates factorial of a number.
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Factorial of number</returns>
        public static uint Factorial(uint n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// Raises the base "a" to the power of "e".
        /// </summary>
        /// <param name="a">Base</param>
        /// <param name="e">Exponent</param>
        /// <returns>"a" to the power of "e"</returns>
        public static double Exponentiate(double a, uint e)
        {
            return Math.Pow(a, e);
        }

        /// <summary>
        /// Calculates "n"-th root of a radicand "a". 
        /// </summary>
        /// <param name="a">Radicand</param>
        /// <param name="n">Degree</param>
        /// <returns>"n"-th root of "a"</returns>
        public static double NthRoot(double a, uint n)
        {
            return Math.Pow(a, 1.0 / n);
        }

        /// <summary>
        /// Calculates sine of angle in radians.
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Sinus</returns>
        public static double Sinus(double angle)
        {
            return Math.Sin(angle);
        }

        /// <summary>
        /// Calculates tangent of angle in radians.
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Tangens</returns>
        public static double Tangens(double angle)
        {
            return Math.Tan(angle);
        }
    }
}
