using Microsoft.AspNetCore.Mvc;
using CalculadoraApp.Services;

namespace CalculadoraApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        [HttpGet("add")]
        public IActionResult Add(double a, double b)
        {
            return Ok(_calculatorService.Add(a, b));
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b)
        {
            return Ok(_calculatorService.Subtract(a, b));
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            return Ok(_calculatorService.Multiply(a, b));
        }

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            try
            {
                return Ok(_calculatorService.Divide(a, b));
            }
            catch (DivideByZeroException)
            {
                return BadRequest("Cannot divide by zero.");
            }
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
