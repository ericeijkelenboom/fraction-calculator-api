using FractionCalculator.Entity;

namespace FractionCalculator.Service
{
    public interface IFractionCalculatorService
    {
        Fraction Add(Fraction fraction1, Fraction fraction2);
        Fraction Subtract(Fraction fraction1, Fraction fraction2);
        Fraction Divide(Fraction fraction1, Fraction fraction2);
        Fraction Multiply(Fraction fraction1, Fraction fraction2);
    }
}