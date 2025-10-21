namespace CloudNA.API.Models.Response;

public class OrderItem
{
    public required string Product {get; set;}
    
    public int Quantity {get; set;}
    
    public decimal Price {get; set;}
}