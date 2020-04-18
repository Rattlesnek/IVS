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
    }
}
