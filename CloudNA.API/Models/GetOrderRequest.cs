namespace CloudNA.API.Models;

/// <summary>
/// The Get Order Request Model.
/// </summary>
public class GetOrderRequest
{
    public required string User { get; init; }
    
    public required string CustomerId  { get; init; }
}