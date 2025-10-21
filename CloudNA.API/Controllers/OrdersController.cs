using CloudNA.API.Models;
using CloudNA.API.Models.Request;
using CloudNA.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudNA.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;
    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    
    [HttpGet("get")]
    public async Task<IActionResult> GetOrder(GetOrderRequest request)
    {
        var response = await _orderService.GetOrder(request);

        if (!response.Success)
        {
            return NotFound(response.ErrorMessage);
        }
        
        return Ok(response);
    }
}