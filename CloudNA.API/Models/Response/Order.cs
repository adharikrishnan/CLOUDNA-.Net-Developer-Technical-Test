using System.Text.Json.Serialization;

namespace CloudNA.API.Models.Response;

public class Order
{
    public int OrderId { get; init; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DateTime OrderDate { get; init; }
    
    public required string DeliveryAddress { get; init; }
    
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DateTime DeliveryExpected { get; set; }
}