using System.Text.Json.Serialization;

namespace CloudNA.API.Models.Response;

/// <summary>
/// Order Item.
/// </summary>
public class OrderItem
{
    [JsonPropertyName("product")]
    public required string Product {get; set;}
    
    [JsonPropertyName("quantity")]
    public int Quantity {get; set;}
    
    [JsonPropertyName("price")]
    public decimal Price {get; set;}
}