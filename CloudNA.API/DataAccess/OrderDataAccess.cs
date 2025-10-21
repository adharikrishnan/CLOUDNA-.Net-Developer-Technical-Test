using System.Data.SqlClient;
using CloudNA.API.Models.Dto;
using CloudNA.API.Models.Response;
using Dapper;

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
        await using var connection = new SqlConnection(_connectionString);
        var parameters = new { CustomerId = customerId };
        
        
    }

    public async Task<CustomerDto?> GetCustomer(string customerId, string email)
    {
        await using var connection = new SqlConnection(_connectionString);
        var parameters = new { CustomerId = customerId, Email = email };
        var customer = await connection
            .QueryFirstOrDefaultAsync<CustomerDto>("EXEC dbo.Get_Customer", parameters).ConfigureAwait(false);
        return customer;
    }
}