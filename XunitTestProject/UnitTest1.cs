using System;
using Xunit;
using CalculatorDemo;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            Calculator calc = new Calculator();

            int answer = calc.Add(1, 2);

            Assert.Equal(3, answer);
        }
    }
}
