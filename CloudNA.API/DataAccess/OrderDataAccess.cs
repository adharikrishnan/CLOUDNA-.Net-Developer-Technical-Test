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
        _connectionString = config.GetSection("ConnectionString:OrderDbConnectionString").Value ?? throw new NullReferenceException("Connection string not set");
    }
    
    public async Task<OrderDto?> GetCustomerOrder(string customerId)
    {
        await using var connection = new SqlConnection(_connectionString);
        var orderParameters = new { CustomerId = customerId };
        
        var order = await connection
            .QueryFirstOrDefaultAsync<OrderDto>("EXEC dbo.Get_Order", orderParameters).ConfigureAwait(false);

        if (order is null) 
            return order;
        
        var prodcutParametes = new { OrderId = order.OrderId };
        var products = await connection
            .QueryAsync<OrderItemDto>("EXEC dbo.Get_Products", prodcutParametes).ConfigureAwait(false);
            
        order.OrderItems.AddRange(products);

        return order;
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