using FractionCalculator.Entity;

namespace FractionCalculator.Controller
{
    public class FractionCalculatorController : IFractionCalculatorController
    {
        #region Implementation of IFractionCalculatorController

        public Fraction Add(Fraction fraction1, Fraction fraction2)
        {
            ValidateFractions(fraction1, fraction2);

            int numerator;
            int denominator;

            if (DenominatorsAreEqual(fraction1, fraction2))
            {
                // Use formula (a/b) + (c/b) = (a+c) / b
                numerator = fraction1.Numerator + fraction2.Numerator;
                denominator = fraction1.Denominator;
            }
            else
            {
                // Use formula (a/b) + (c/d) = ((a*d) + (c*b)) / (b*d)
                numerator = ((fraction1.Numerator*fraction2.Denominator) + (fraction2.Numerator*fraction1.Denominator));
                denominator = fraction1.Denominator*fraction2.Denominator;
            }

            return new Fraction(numerator, denominator);
        }

        public Fraction Subtract(Fraction fraction1, Fraction fraction2)
        {
            ValidateFractions(fraction1, fraction2);

            int numerator;
            int denominator;

            if (DenominatorsAreEqual(fraction1, fraction2))
            {
                // Use formula (a/b) - (c/b) = (a-c) / b
                numerator = fraction1.Numerator - fraction2.Numerator;
                denominator = fraction1.Denominator;
            }
            else
            {
                // Use formula (a/b) + (c/d) = ((a*d) - (c*b)) / (b*d)
                numerator = ((fraction1.Numerator*fraction2.Denominator) - (fraction2.Numerator*fraction1.Denominator));
                denominator = fraction1.Denominator*fraction2.Denominator;
            }

            return new Fraction(numerator, denominator);
        }

        public Fraction Divide(Fraction fraction1, Fraction fraction2)
        {
            ValidateFractions(fraction1, fraction2);

            // Do not allow the numerator in the second fraction to be 0, since this would result in devision by 0
            if(fraction2.Numerator == 0)
                throw new FractionCalculatorException("The second fraction can not have a numerator equal to 0");

            // Use formula (a/b) / (c/d) = (a/b) * (d/c)
            return Multiply(new Fraction(fraction1.Numerator, fraction1.Denominator),
                            new Fraction(fraction2.Denominator, fraction2.Numerator));
        }

        public Fraction Multiply(Fraction fraction1, Fraction fraction2)
        {
            ValidateFractions(fraction1, fraction2);

            // Use formula (a/b) * (c/d) = (a*c) / (b*d)
            int numerator = fraction1.Numerator*fraction2.Numerator;
            int denominator = fraction1.Denominator*fraction2.Denominator;

            return new Fraction(numerator, denominator);
        }

        #endregion

        #region Internal helper methods

        internal bool DenominatorsAreEqual(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Denominator == fraction2.Denominator;
        }

        internal void ValidateFractions(Fraction fraction1, Fraction fraction2)
        {
            if (fraction1 == null || fraction2 == null)
                throw new FractionCalculatorException("Fractions must not be null");

            if (fraction1.Denominator == 0 || fraction2.Denominator == 0)
                throw new FractionCalculatorException("Fractions can not have a denominator equal to zero (0)");
        }

        #endregion
    }
}