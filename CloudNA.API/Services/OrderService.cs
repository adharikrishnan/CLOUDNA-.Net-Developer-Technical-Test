using CloudNA.API.DataAccess;
using CloudNA.API.Extensions;
using CloudNA.API.Models;
using CloudNA.API.Models.Request;
using CloudNA.API.Models.Response;

namespace CloudNA.API.Services;

public class OrderService : IOrderService
{
    private readonly IOrderDataAccess _orderDataAccess;
    
    private readonly ILogger<OrderService> _logger;

    public OrderService(ILogger<OrderService> logger, IOrderDataAccess orderDataAccess)
    {
        _orderDataAccess = orderDataAccess;
        _logger = logger;
    }

    public async Task<Result<GetOrderResponse>> GetOrder(GetOrderRequest request)
    {
        try
        {
            var customer = await _orderDataAccess.GetCustomer(request.CustomerId, request.User);

            if (customer is null)
                return new Result<GetOrderResponse>("Customer with the given credentials does not exist.");

            var order = await _orderDataAccess.GetCustomerOrder(request.CustomerId);


            return new Result<GetOrderResponse>(customer.MapToOrderResponse(order));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,"An Error Occured when trying to retrieve order for customer {customerId}", request.CustomerId);
            return new Result<GetOrderResponse>("An unexpected error occured please contact support.");
        }
    }
}