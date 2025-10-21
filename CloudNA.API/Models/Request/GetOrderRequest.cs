namespace CloudNA.API.Models.Request;

/// <summary>
/// The Get Order Request Model.
/// </summary>
public class GetOrderRequest
{
    public required string User { get; init; }
    
    public required string CustomerId  { get; init; }
}