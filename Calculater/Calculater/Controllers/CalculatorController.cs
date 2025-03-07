using Microsoft.AspNetCore.Mvc;
using Calculater.Models;
using Calculater.Data;
namespace Calculater.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController: ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CalculatorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] Calculation calculation)
        {
            switch (calculation.Operation)
            {
                case "+":
                    calculation.Result = calculation.Num1 + calculation.Num2;
                    break;
                case "-":
                    calculation.Result = calculation.Num1 - calculation.Num2;
                    break;
                case "*":
                    calculation.Result = calculation.Num1 * calculation.Num2;
                    break;
                case "/":
                    if (calculation.Num2 == 0)
                        return BadRequest("Cannot divide by zero");
                    calculation.Result = calculation.Num1 / calculation.Num2;
                    break;
                default:
                    return BadRequest("Invalid operation");
            }

            _context.Calculations.Add(calculation);
            _context.SaveChanges();
            return Ok(calculation);
        }

        [HttpGet("history")]
        public IActionResult GetHistory()
        {
            return Ok(_context.Calculations.ToList());
        }
    }
}
