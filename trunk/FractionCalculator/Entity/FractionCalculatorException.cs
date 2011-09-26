using System;

namespace FractionCalculator.Entity
{
    public class FractionCalculatorException : Exception
    {
        public FractionCalculatorException(string message) : base(message)
        {
        }

        public FractionCalculatorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}