namespace Mic.SampleCodeAssessmentApp.Library;

public class Calculator : ICalculator
{
    /// <summary>
    /// Adds two numbers.
    /// </summary>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides the first number by the second.
    /// Throws a DivideByZeroException if the divisor is zero.
    /// </summary>
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

    /// <summary>
    /// Calculates the power of a number.
    /// </summary>
    public double Power(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }

    /// <summary>
    /// Calculates the square root of a number.
    /// Throws an ArgumentException if the number is negative.
    /// </summary>
    public double SquareRoot(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Cannot calculate the square root of a negative number.");
        }
        return Math.Sqrt(number);
    }
}
