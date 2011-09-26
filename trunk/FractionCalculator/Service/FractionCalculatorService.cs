using System;
using FractionCalculator.Controller;
using FractionCalculator.Entity;

namespace FractionCalculator.Service
{
    public class FractionCalculatorService : IFractionCalculatorService
    {
        private readonly IFractionCalculatorController _controller;

        public FractionCalculatorService(IFractionCalculatorController controller)
        {
            if (controller == null)
            {
                throw new ArgumentNullException("controller", "Controller must be specified");
            }

            _controller = controller;
        }

        #region Implementation of IFractionCalculator

        public Fraction Add(Fraction fraction1, Fraction fraction2)
        {
            return _controller.Add(fraction1, fraction2);
        }

        public Fraction Subtract(Fraction fraction1, Fraction fraction2)
        {
            return _controller.Subtract(fraction1, fraction2);
        }

        public Fraction Divide(Fraction fraction1, Fraction fraction2)
        {
            return _controller.Divide(fraction1, fraction2);
        }

        public Fraction Multiply(Fraction fraction1, Fraction fraction2)
        {
            return _controller.Multiply(fraction1, fraction2);
        }

        #endregion
    }
}