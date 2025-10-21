using CloudNA.API.Models;
using CloudNA.API.Models.Request;
using CloudNA.API.Models.Response;

namespace CloudNA.API.Services;

public interface IOrderService
{
    Task<Result<GetOrderResponse>> GetOrder(GetOrderRequest request);
}