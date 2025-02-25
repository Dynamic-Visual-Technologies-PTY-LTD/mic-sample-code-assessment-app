namespace Mic.SampleCodeAssessmentApp.Library
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Divide(double a, double b);
        double Multiply(double a, double b);
        double Power(double baseNumber, double exponent);
        double SquareRoot(double number);
        double Subtract(double a, double b);
    }
}