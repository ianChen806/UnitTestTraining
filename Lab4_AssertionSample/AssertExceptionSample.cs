using System;
using FluentAssertions;
using Xunit;

namespace Lab4_AssertionSample
{
    public class AssertExceptionSample
    {
        [Fact]
        public void Divide_positive()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(5, 2);
            
            Assert.Equal(2.5m, actual);
        }

        [Fact]
        public void Divide_Zero()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(5, 0);

            //how to assert expected exception?
            //never use try/catch in unit test
        }
    }

    public class Calculator
    {
        public decimal Divide(decimal first, decimal second)
        {
            if (second == 0)
            {
                throw new YouShallNotPassException();
            }

            return first / second;
        }
    }

    public class YouShallNotPassException : Exception
    {
    }
}