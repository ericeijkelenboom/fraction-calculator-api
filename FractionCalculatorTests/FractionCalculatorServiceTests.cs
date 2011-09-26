using FakeItEasy;
using FractionCalculator.Controller;
using FractionCalculator.Service;
using NUnit.Framework;

namespace FractionCalculatorTests
{
    [TestFixture]
    public class FractionCalculatorServiceTests
    {
        private IFractionCalculatorService _fractionCalculatorService;
        private IFractionCalculatorController _fractionCalculatorController;

        [TestFixtureSetUp]
        public void SetupFixture()
        {
            // Create fake controller 
           _fractionCalculatorController = A.Fake<IFractionCalculatorController>();

            // Initialize service with fake controller
           _fractionCalculatorService = new FractionCalculatorService(_fractionCalculatorController);
        }

        [Test]
        public void Add_calls_Add_method_on_controller()
        {
            // Call Add on the service layer
            _fractionCalculatorService.Add(null, null);

            // Assert that Add was called on the controller
            A.CallTo(() => _fractionCalculatorController.Add(null, null)).MustHaveHappened();
        }

        [Test]
        public void Subtract_calls_Subtract_method_on_controller()
        {
            // Call Subtract on the service layer
            _fractionCalculatorService.Subtract(null, null);

            // Assert that Subtract was called on the controller
            A.CallTo(() => _fractionCalculatorController.Subtract(null, null)).MustHaveHappened();
        }

        [Test]
        public void Multiply_calls_Multiply_method_on_controller()
        {
            // Call Multiply on the service layer
            _fractionCalculatorService.Multiply(null, null);

            // Assert that Multiply was called on the controller
            A.CallTo(() => _fractionCalculatorController.Multiply(null, null)).MustHaveHappened();
        }

        [Test]
        public void Divide_calls_Divide_method_on_controller()
        {
            // Call Divide on the service layer
            _fractionCalculatorService.Divide(null, null);

            // Assert that Divide was called on the controller
            A.CallTo(() => _fractionCalculatorController.Divide(null, null)).MustHaveHappened();
        }

    }
}