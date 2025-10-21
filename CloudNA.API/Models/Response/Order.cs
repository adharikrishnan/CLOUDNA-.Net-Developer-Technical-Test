using System.Text.Json.Serialization;

namespace CloudNA.API.Models.Response;

/// <summary>
/// Order model
/// </summary>
public class Order
{
    [JsonPropertyName("orderId")]
    public int OrderId { get; init; }
    
    [JsonPropertyName("orderDate")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DateTime OrderDate { get; init; }
    
    [JsonPropertyName("deliveryAddress")]
    public required string DeliveryAddress { get; init; }
    
    [JsonPropertyName("orderItems")]
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    
    [JsonPropertyName("deliveryExpected")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DateTime DeliveryExpected { get; set; }
}