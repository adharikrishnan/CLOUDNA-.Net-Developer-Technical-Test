using Microsoft.AspNetCore.Mvc;

namespace CloudNA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    [HttpGet("get")]
    public async Task<IActionResult> GetOrder()
    {
        return Ok();
    }
}