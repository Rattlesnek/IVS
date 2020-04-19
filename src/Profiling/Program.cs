using System;
using System.Collections.Generic;
using MathLib;

namespace Profiling
{
    class Program
    {
        /// <summary>
        /// Returns list of numbers read from STDIN.
        /// </summary>
        /// <returns>List of numbers</returns>
        static List<double> getNumbers()
        {
            List<double> numbers = new List<double>();
            bool inputExists = true;
            while (inputExists)
            {
                string number = Console.ReadLine();
                if (string.IsNullOrEmpty(number))
                {
                    inputExists = false;
                }
                else
                {
                    numbers.Add(double.Parse(number));
                }
            }

            return numbers;
        }

        /// <summary>
        /// Calculates sample standard deviation.
        /// </summary>
        /// <param name="numbers">
        /// Numbers whose sample standard deviation is to be calculated.
        /// </param>
        /// <returns>Sample standard deviation of the numbers in the list.</returns>
        static double CalcSampleStandardDeviation(List<double> numbers) {
        /*    
            int N = numbers.Count;
            
            double sum = 0;
            numbers.ForEach(i => sum = MathOp.Add(i, sum));
            
            double mean = sum / N;
            
            double squaredSum = 0;
            numbers.ForEach(i => squaredSum = MathOp.Add(MathOp.Exponentiate(i, 2), squaredSum));

            
            double numerator = squaredSum - N * MathOp.Exponentiate(mean, 2);
            double denominator = N - 1;

            return MathOp.NthRoot(numerator / denominator, 2);
            
        */
            int N = numbers.Count;
            double sum = 0;
            for(int i = 0; i < N; i++) {
                sum = MathOp.Add(sum, numbers[i]);
            }

            double mean = sum / N;

            double squaredSum = 0;
            for(int i = 0; i < N; i++) {
                double toPow = MathOp.Exponentiate(numbers[i], 2);
                squaredSum = MathOp.Add(squaredSum, toPow);
            }

            double numerator = squaredSum - N * MathOp.Exponentiate(mean, 2);
            double denominator = N - 1;

            return MathOp.NthRoot(numerator/ denominator, 2);
        }

        static void Main(string[] args)
        {
            List<double> numbers = getNumbers();

            double sampleStandardDeviation = CalcSampleStandardDeviation(numbers);

            Console.WriteLine(sampleStandardDeviation);
            Console.WriteLine("Ukamanga");
            var enter = Console.ReadLine();
        }
    }
}
