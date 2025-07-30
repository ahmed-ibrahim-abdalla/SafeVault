using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ErrorHandlingController : ControllerBase
{
    [HttpGet("division")]
    public IActionResult GetDivisionResult(int numerator, int denominator)
    {
        try
        {
            var result = numerator / denominator;
            return Ok(result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return BadRequest("Denominator cannot be zero.");
        }   
          
    }
    
}