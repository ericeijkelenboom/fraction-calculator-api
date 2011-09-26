using FractionCalculator.Controller;
using FractionCalculator.Entity;
using NUnit.Framework;

namespace FractionCalculatorTests
{
    [TestFixture]
    public class FractionCalculatorControllerTests
    {
        private FractionCalculatorController _controller;

        [TestFixtureSetUp]
        public void SetupFixture()
        {
            _controller = new FractionCalculatorController();
        }

        #region Testcases for Add

        [TestCase(7, 8, 3, 6, 66, 48)] // Unequal denominators
        [TestCase(3, 9, 2, 9, 5, 9)] // Equal denominators
        [TestCase(0, 7, 1, 7, 1, 7)] // Numerator of 0
        public void Add_adds_valid_fractions_correctly(int frac1Numerator, int frac1Denominator, 
                                                       int frac2Numerator, int frac2Denominator, 
                                                       int expectedNumerator, int expectedDenominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);
            var expectedFraction = new Fraction(expectedNumerator, expectedDenominator);

            Fraction actualFraction = _controller.Add(inputFraction1, inputFraction2);

            Assert.AreEqual(expectedFraction, actualFraction);
        }

        [TestCase(3, 0, 1, 2)] // First denominator 0
        [TestCase(3, 5, 1, 0)] // Second denominator 0
        [ExpectedException(typeof (FractionCalculatorException))]
        public void Add_throws_FractionCalculatorException_on_invalid_fractions(int frac1Numerator, int frac1Denominator,
                                                                                int frac2Numerator, int frac2Denominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);

            _controller.Add(inputFraction1, inputFraction2);
        }

        [Test]
        [ExpectedException(typeof (FractionCalculatorException))]
        public void Add_throws_FractionCalculatorException_when_fraction1_is_null()
        {
            _controller.Add(null, new Fraction(1, 2));
        }

        [Test]
        [ExpectedException(typeof (FractionCalculatorException))]
        public void Add_throws_FractionCalculatorException_when_fraction2_is_null()
        {
            _controller.Add(null, new Fraction(1, 2));
        }

        #endregion

        #region Testcases for Subtract

        [TestCase(7, 8, 3, 6, 18, 48)] // Unequal denominators
        [TestCase(3, 9, 2, 9, 1, 9)] // Equal denominators
        [TestCase(12, 8, 13, 3, -68, 24)] // Negative result
        [TestCase(3, 7, 0, 7, 3, 7)] // Numerator of 0
        public void Subtract_subtracts_valid_fractions_correctly(int frac1Numerator, int frac1Denominator,
                                                                 int frac2Numerator, int frac2Denominator, 
                                                                 int expectedNumerator, int expectedDenominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);
            var expectedFraction = new Fraction(expectedNumerator, expectedDenominator);

            Fraction actualFraction = _controller.Subtract(inputFraction1, inputFraction2);

            Assert.AreEqual(expectedFraction, actualFraction);
        }

        [TestCase(3, 0, 1, 2)] // First denominator 0
        [TestCase(3, 5, 1, 0)] // Second denominator 0
        [ExpectedException(typeof (FractionCalculatorException))]
        public void Subtract_throws_FractionCalculatorException_on_invalid_fractions(int frac1Numerator, int frac1Denominator,
                                                                                         int frac2Numerator, int frac2Denominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);

            _controller.Subtract(inputFraction1, inputFraction2);
        }

        [Test]
        [ExpectedException(typeof (FractionCalculatorException))]
        public void Subtract_throws_FractionCalculatorException_when_fraction1_is_null()
        {
            _controller.Subtract(null, new Fraction(1, 2));
        }

        [Test]
        [ExpectedException(typeof (FractionCalculatorException))]
        public void Subtract_throws_FractionCalculatorException_when_fraction2_is_null()
        {
            _controller.Subtract(null, new Fraction(1, 2));
        }

        #endregion

        #region Testcases for Divide

        [TestCase(7, 8, 3, 6, 42, 24)] 
        [TestCase(3, 9, 2, 9, 27, 18)]
        public void Divide_divides_valid_fractions_correctly(int frac1Numerator, int frac1Denominator,
                                                             int frac2Numerator, int frac2Denominator,
                                                             int expectedNumerator, int expectedDenominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);
            var expectedFraction = new Fraction(expectedNumerator, expectedDenominator);

            Fraction actualFraction = _controller.Divide(inputFraction1, inputFraction2);

            Assert.AreEqual(expectedFraction, actualFraction);
        }

        [TestCase(3, 0, 1, 2)] // First denominator 0
        [TestCase(3, 5, 1, 0)] // Second denominator 0
        [TestCase(3, 5, 0, 4)] // Second numerator 0
        [ExpectedException(typeof(FractionCalculatorException))]
        public void Divide_throws_FractionCalculatorException_on_invalid_fractions(int frac1Numerator, int frac1Denominator,
                                                                                       int frac2Numerator, int frac2Denominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);

            _controller.Divide(inputFraction1, inputFraction2);
        }

        [Test]
        [ExpectedException(typeof(FractionCalculatorException))]
        public void Divide_throws_FractionCalculatorException_when_fraction1_is_null()
        {
            _controller.Divide(null, new Fraction(1, 2));
        }

        [Test]
        [ExpectedException(typeof(FractionCalculatorException))]
        public void Divide_throws_FractionCalculatorException_when_fraction2_is_null()
        {
            _controller.Divide(null, new Fraction(1, 2));
        }

        #endregion

        #region Testcases for Multiply

        [TestCase(7, 8, 3, 6, 21, 48)]
        [TestCase(0, 9, 2, 9, 0, 81)] // Denominator of 0
        public void Multiply_multiplies_valid_fractions_correctly(int frac1Numerator, int frac1Denominator,
                                                                  int frac2Numerator, int frac2Denominator,
                                                                  int expectedNumerator, int expectedDenominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);
            var expectedFraction = new Fraction(expectedNumerator, expectedDenominator);

            Fraction actualFraction = _controller.Multiply(inputFraction1, inputFraction2);

            Assert.AreEqual(expectedFraction, actualFraction);
        }

        [TestCase(3, 0, 1, 2)] // First denominator 0
        [TestCase(3, 5, 1, 0)] // Second denominator 0
        [ExpectedException(typeof(FractionCalculatorException))]
        public void Multiply_throws_FractionCalculatorException_on_invalid_fractions(int frac1Numerator, int frac1Denominator,
                                                                                     int frac2Numerator, int frac2Denominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);

            _controller.Multiply(inputFraction1, inputFraction2);
        }

        [Test]
        [ExpectedException(typeof(FractionCalculatorException))]
        public void Multiply_throws_FractionCalculatorException_when_fraction1_is_null()
        {
            _controller.Multiply(null, new Fraction(1, 2));
        }

        [Test]
        [ExpectedException(typeof(FractionCalculatorException))]
        public void Multiply_throws_FractionCalculatorException_when_fraction2_is_null()
        {
            _controller.Multiply(null, new Fraction(1, 2));
        }

        #endregion

        #region Testcases for internal members

        [TestCase(1, 1, true)]
        [TestCase(234, 234, true)]
        [TestCase(1, 6, false)]
        [TestCase(3, -9, false)]
        public void DenominatorsAreEqual_returns_whether_denominators_are_equal(int denominator1, int denominator2, bool denominatorsAreEqual)
        {
            var inputFraction1 = new Fraction(3, denominator1);
            var inputFraction2 = new Fraction(7, denominator2);

            Assert.AreEqual(denominatorsAreEqual, _controller.DenominatorsAreEqual(inputFraction1, inputFraction2));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(98, -4, 5, 5)]
        [TestCase(0, 4, 0, 6)]
        public void ValidateFractions_does_not_throw_exception_on_valid_fractions(int frac1Numerator, int frac1Denominator,
                                                                                  int frac2Numerator, int frac2Denominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);

            _controller.ValidateFractions(inputFraction1, inputFraction2);
        }

        [TestCase(3, 0, 1, 2)] // First denominator 0
        [TestCase(3, 5, 1, 0)] // Second denominator 0
        [ExpectedException(typeof(FractionCalculatorException))]
        public void ValidateFractions_throws_FractionCalculator_on_invalid_fractions(int frac1Numerator, int frac1Denominator,
                                                                                     int frac2Numerator, int frac2Denominator)
        {
            var inputFraction1 = new Fraction(frac1Numerator, frac1Denominator);
            var inputFraction2 = new Fraction(frac2Numerator, frac2Denominator);

            _controller.ValidateFractions(inputFraction1, inputFraction2);
        }

        [Test]
        [ExpectedException(typeof(FractionCalculatorException))]
        public void ValidateFractions_throws_FractionCalculatorException_when_fraction1_is_null()
        {
            _controller.ValidateFractions(null, new Fraction(1, 2));
        }

        [Test]
        [ExpectedException(typeof(FractionCalculatorException))]
        public void ValidateFractions_throws_FractionCalculatorException_when_fraction2_is_null()
        {
            _controller.ValidateFractions(new Fraction(1, 2), null);
        }

        #endregion

    }
}