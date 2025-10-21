using CloudNA.API.Models.Dto;
using CloudNA.API.Models.Response;

namespace CloudNA.API.DataAccess;

public interface IOrderDataAccess
{
    Task<OrderDto?> GetCustomerOrder(string customerId);
    
    Task<CustomerDto?> GetCustomer(string customerId, string email);
}