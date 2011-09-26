using FractionCalculator.Controller;
using FractionCalculator.Entity;
using FractionCalculator.Service;

namespace FractionCalculator
{
    public class FractionCalculatorFacade
    {
        private readonly FractionCalculatorService _fractionCalculatorService;

        public FractionCalculatorFacade()
        {
            // Wire up dependencies manually
            _fractionCalculatorService = new FractionCalculatorService(new FractionCalculatorController());
        }

        public Fraction Add(Fraction fraction1, Fraction fraction2)
        {
            return _fractionCalculatorService.Add(fraction1, fraction2);
        }

        public Fraction Subtract(Fraction fraction1, Fraction fraction2)
        {
            return _fractionCalculatorService.Subtract(fraction1, fraction2);
        }
        
        public Fraction Divide(Fraction fraction1, Fraction fraction2)
        {
            return _fractionCalculatorService.Divide(fraction1, fraction2);
        }
        
        public Fraction Multilpy(Fraction fraction1, Fraction fraction2)
        {
            return _fractionCalculatorService.Multiply(fraction1, fraction2);
        }
    }
}