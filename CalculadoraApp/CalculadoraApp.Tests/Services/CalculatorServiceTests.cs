// Localização: CalculadoraApp.Tests/Services/CalculatorServiceTests.cs

using CalculadoraApp.Services;
using Xunit;

namespace CalculadoraApp.Tests.Services
{
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }

        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            var result = _calculatorService.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            var result = _calculatorService.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectResult()
        {
            var result = _calculatorService.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectResult()
        {
            var result = _calculatorService.Divide(6, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(6, 0));
        }
    }
}
