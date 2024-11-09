// Localização: CalculadoraApp/Services/CalculatorService.cs

using CalculadoraApp.Models;

namespace CalculadoraApp.Services
{
    public class CalculatorService
    {
        private readonly Calculator _calculator;

        public CalculatorService()
        {
            _calculator = new Calculator();
        }

        public double Add(double a, double b) => _calculator.Add(a, b);
        public double Subtract(double a, double b) => _calculator.Subtract(a, b);
        public double Multiply(double a, double b) => _calculator.Multiply(a, b);
        public double Divide(double a, double b) => _calculator.Divide(a, b);
    }
}
