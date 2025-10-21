using CloudNA.API.Models.Response;

namespace CloudNA.API.Models.Dto;

/// <summary>
/// Order Dto class.
/// </summary>
public class OrderDto
{
    public int OrderId { get; init; }
    
    public DateTime OrderDate { get; init; }
    
    public required string DeliveryAddress { get; init; }
    
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    
    public DateTime DeliveryExpected { get; set; }
}