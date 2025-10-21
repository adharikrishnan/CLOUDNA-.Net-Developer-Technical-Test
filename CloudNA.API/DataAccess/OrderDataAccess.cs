using CloudNA.API.Models.Dto;

namespace CloudNA.API.DataAccess;

public class OrderDataAccess : IOrderDataAccess
{
    private string _connectionString;
    
    public OrderDataAccess(IConfiguration config)
    {
        _connectionString = config.GetSection("ConnectionString:OrderDbConnectionString").Value ?? throw new NullReferenceException();
    }
    
    public async Task<CustomerOrderDto> GetCustomerOrder(string customerId)
    {
        throw new NotImplementedException();
    }

    public async Task<CustomerDto?> GetCustomer(string customerId, string email)
    {
        throw new NotImplementedException();
    }
}