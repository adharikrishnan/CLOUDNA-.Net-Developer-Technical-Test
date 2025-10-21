using CloudNA.API.DataAccess;
using CloudNA.API.Extensions;
using CloudNA.API.Models;
using CloudNA.API.Models.Request;
using CloudNA.API.Models.Response;

namespace CloudNA.API.Services;

public class OrderService : IOrderService
{
    private readonly IOrderDataAccess _orderDataAccess;
    
    public OrderService(IOrderDataAccess orderDataAccess)
    {
        _orderDataAccess = orderDataAccess;
    }
    
    public async Task<Result<GetOrderResponse>> GetOrder(GetOrderRequest request)
    {
        var customer = await _orderDataAccess.GetCustomer(request.CustomerId, request.User);
        
        if(customer is null)
            return new Result<GetOrderResponse>("Customer with the given credentials does not exist.");

        var order = await _orderDataAccess.GetCustomerOrder(request.CustomerId);
        
        
        return new Result<GetOrderResponse>(customer.MapToOrderResponse(order))
    }
}