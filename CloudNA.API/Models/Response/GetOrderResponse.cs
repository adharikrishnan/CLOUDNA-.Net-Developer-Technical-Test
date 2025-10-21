namespace CloudNA.API.Models.Response;

public class GetOrderResponse
{
    public required Customer Customer { get; set; }
    
    public Order? Order { get; set; }
}