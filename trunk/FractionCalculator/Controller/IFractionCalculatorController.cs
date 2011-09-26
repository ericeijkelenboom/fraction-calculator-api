using FractionCalculator.Entity;

namespace FractionCalculator.Controller
{
    public interface IFractionCalculatorController
    {
        Fraction Add(Fraction fraction1, Fraction fraction2);
        Fraction Subtract(Fraction fraction1, Fraction fraction2);
        Fraction Divide(Fraction fraction1, Fraction fraction2);
        Fraction Multiply(Fraction fraction1, Fraction fraction2);
    }
}