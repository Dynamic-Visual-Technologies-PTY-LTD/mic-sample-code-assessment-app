using Mic.SampleCodeAssessmentApp.Library;

namespace Mic.SampleCodeAssessmentApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(-1, 1, 0)]
        public void Add_ShouldReturnCorrectSum(double a, double b, double expected)
        {
            var result = _calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-5, -3, -2)]
        [InlineData(5, -3, 8)]
        public void Subtract_ShouldReturnCorrectDifference(double a, double b, double expected)
        {
            var result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, -3, 6)]
        [InlineData(-2, 3, -6)]
        public void Multiply_ShouldReturnCorrectProduct(double a, double b, double expected)
        {
            var result = _calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-6, -3, 2)]
        [InlineData(-6, 3, -2)]
        public void Divide_ShouldReturnCorrectQuotient(double a, double b, double expected)
        {
            var result = _calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 0, 1)]
        [InlineData(2, 3, 8)]
        [InlineData(5, -1, 0.2)]
        public void Power_ShouldReturnCorrectResult(double baseNumber, double exponent, double expected)
        {
            var result = _calculator.Power(baseNumber, exponent);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(0, 0)]
        public void SquareRoot_ShouldReturnCorrectResult(double number, double expected)
        {
            var result = _calculator.SquareRoot(number);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
        }

        [Fact]
        public void SquareRoot_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(-1));
        }
    }
}
