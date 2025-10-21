namespace CloudNA.API.Models.Dto;

/// <summary>
/// Customer Order Dto Class
/// </summary>
public class CustomerOrderDto
{
    public required CustomerDto Customer { get; set; }
    
    public OrderDto? Order { get; set; }
}