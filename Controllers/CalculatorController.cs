using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult Getsum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new {a, b ,result});
        }
        
        [HttpGet("rest")]
        public IActionResult Getrest([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new {a, b ,result});
        }
        
        [HttpGet("mult")]
        public IActionResult Getmult([FromQuery] int a, [FromQuery] int b)
        {
            var result = a * b;
            return Ok(new {a, b ,result});
        }
        
        [HttpGet("div")]
        public IActionResult Getdiv([FromQuery] int a, [FromQuery] int b)
        {
            var result = a / b;
            return Ok(new {a, b ,result});
        }
    }
}