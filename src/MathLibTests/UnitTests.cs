using System;
using Xunit;
using MathLib;

namespace MathLibTests
{
    public class UnitTests
    {
        [Fact]
        public void FactorialTest()
        {
            double fac;
            fac = MathOp.Factorial(0);
            Xunit.Assert.Equal(1, fac);

            fac = MathOp.Factorial(1);
            Xunit.Assert.Equal(1, fac);

            fac = MathOp.Factorial(2);
            Xunit.Assert.Equal(2, fac);

            fac = MathOp.Factorial(5);
            Xunit.Assert.Equal(120, fac);
        }

        [Fact]
        public void NthRootTest()
        {
            double root;
            root = MathOp.NthRoot(9, 2);
            Xunit.Assert.Equal(3, root);

            root = MathOp.NthRoot(8, 3);
            Xunit.Assert.Equal(2, root);
        }

        [Fact]
        public void AddTest()
        {
            var result = MathOp.Add(1, 2);
            Xunit.Assert.Equal(3, result);

            result = MathOp.Add(-42, 12);
            Xunit.Assert.Equal(-30, result);

            result = MathOp.Add(123456789.123456789, 987654321.987654321);
            Xunit.Assert.Equal(1111111111.11111111, result);
        }

        [Fact]
        public void SubtractTest()
        {
            var result = MathOp.Subtract(1, 2);
            Xunit.Assert.Equal(-1, result);

            result = MathOp.Subtract(-42, 12);
            Xunit.Assert.Equal(-54, result);

            result = MathOp.Subtract(123456789.123456789, 987654321.987654321);
            Xunit.Assert.Equal(-864197532.864197532, result);

            result = MathOp.Subtract(123, -987);
            Xunit.Assert.Equal(1110, result);
        }


        [Fact]
        public void MultiplyTest()
        {
            var result = MathOp.Multiply(42, -42);
            Xunit.Assert.Equal(-1764, result);

            result = MathOp.Multiply(123.321, 321.123);
            Xunit.Assert.Equal(39601.209483, result);

            result = MathOp.Multiply(0.000002, -1000000.1);
            Xunit.Assert.Equal(-2.0000001999999997, result);
        }

        [Fact]
        public void DivideTest()
        {
            var result = MathOp.Divide(42, -42);
            Xunit.Assert.Equal(-1, result);

            result = MathOp.Divide(123.321, 321.123);
            Xunit.Assert.Equal(0.38403041825095057034220532319392, result);

            result = MathOp.Divide(1, 0);
            Xunit.Assert.Equal(Double.PositiveInfinity, result);

            result = MathOp.Divide(-1, 0);
            Xunit.Assert.Equal(Double.NegativeInfinity, result);
        }

        [Fact]
        public void ExponentiateTest()
        {
            var result = MathOp.Exponentiate(1, 999999999);
            Xunit.Assert.Equal(1, result);

            result = MathOp.Exponentiate(2, 4);
            Xunit.Assert.Equal(16, result);

            result = MathOp.Exponentiate(-1, 0);
            Xunit.Assert.Equal(1, result);

            result = MathOp.Exponentiate(2.5, 42);
            Xunit.Assert.Equal(51698788284564229.679463043254373, result);
        }

        [Fact]
        public void SinusTest()
        {
            var result = MathOp.Sinus(1);
            Xunit.Assert.Equal(0.8414709848078965066525023216303, result);

            result = MathOp.Sinus(90);
            Xunit.Assert.Equal(1, result);

            result = MathOp.Sinus(-180);
            Xunit.Assert.Equal(0, result);

            result = MathOp.Sinus(540);
            Xunit.Assert.Equal(0, result);
        }

        [Fact]
        public void TangensTest()
        {
            var result = MathOp.Tangens(1);
            Xunit.Assert.Equal(1.5574077246549022305069748074584, result);

            result = MathOp.Tangens(-1);
            Xunit.Assert.Equal(-1.5574077246549022305069748074584, result);

            result = MathOp.Tangens(0);
            Xunit.Assert.Equal(0, result);

            result = MathOp.Tangens(3.1415926535897932384626433832795);
            Xunit.Assert.InRange(result, -0.00000000000001, 0.00000000000001);
        }
    }
}