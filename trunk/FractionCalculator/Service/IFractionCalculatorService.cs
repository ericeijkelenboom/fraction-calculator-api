using FractionCalculator.Entity;

namespace FractionCalculator.Service
{
    public interface IFractionCalculatorService
    {
        /// <summary>
        /// Add to fractions
        /// </summary>
        /// <param name="fraction1">The first fraction</param>
        /// <param name="fraction2">The second fraction</param>
        /// <returns>A fraction containing the result of the addition</returns>
        Fraction Add(Fraction fraction1, Fraction fraction2);

        /// <summary>
        /// Subtract two fractions
        /// </summary>
        /// <param name="fraction1">The first fraction</param>
        /// <param name="fraction2">The second fraction</param>
        /// <returns><returns>A fraction containing the result of the subtraction</returns></returns>
        Fraction Subtract(Fraction fraction1, Fraction fraction2);

        /// <summary>
        /// Divide two fractions
        /// </summary>
        /// <param name="fraction1">The first fraction</param>
        /// <param name="fraction2">The second fraction</param>
        /// <returns><returns>A fraction containing the result of the division</returns></returns>
        Fraction Divide(Fraction fraction1, Fraction fraction2);

        /// <summary>
        /// Multiply two fractions
        /// </summary>
        /// <param name="fraction1">The first fraction</param>
        /// <param name="fraction2">The second fraction</param>
        /// <returns><returns>A fraction containing the result of the multiplication</returns></returns>
        Fraction Multiply(Fraction fraction1, Fraction fraction2);
    }
}