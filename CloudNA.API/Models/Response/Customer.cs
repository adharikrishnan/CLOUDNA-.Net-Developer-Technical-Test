using System.Text.Json.Serialization;

namespace CloudNA.API.Models.Response;

/// <summary>
/// The Customer Model.
/// </summary>
public class Customer
{
    [JsonPropertyName("firstName")]
    public required string FirstName { get; init; }
    
    [JsonPropertyName("lastName")]
    public required string LastName { get; init; } 
}