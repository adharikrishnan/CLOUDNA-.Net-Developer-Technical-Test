namespace CloudNA.API.Models.Dto;

/// <summary>
/// Customer Order Dto Class
/// </summary>
public class OrderItemDto
{
    public required string Product { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}