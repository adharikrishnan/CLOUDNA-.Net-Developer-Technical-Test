using System.Text.Json.Serialization;

namespace CloudNA.API.Models.Response;

/// <summary>
/// Get Order Response Model.
/// </summary>
public class GetOrderResponse
{
    [JsonPropertyName("customer")]
    public required Customer Customer { get; set; }
    
    [JsonPropertyName("order")]
    public Order? Order { get; set; }
}