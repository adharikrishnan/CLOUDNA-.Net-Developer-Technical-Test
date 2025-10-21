namespace CloudNA.API.Models;

public class GetOrderResponse
{
    public Customer Customer { get; set; }
    
    public Order Order { get; set; }
}