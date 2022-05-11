using FromOldToNew.Services;
using Microsoft.AspNetCore.Mvc;

namespace FromOldToNew.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService service)
        {
            _calculatorService = service;
        }
        [HttpGet]
        public IActionResult Add([FromQuery] double x, [FromQuery]double y)
        {
            return StatusCode(StatusCodes.Status200OK,_calculatorService.Add(x, y));
        }
    }
}
