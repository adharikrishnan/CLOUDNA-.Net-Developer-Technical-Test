using CloudNA.API.Models.Dto;
using CloudNA.API.Models.Response;

namespace CloudNA.API.Extensions;

public static class MappingExtensions
{
    public static GetOrderResponse MapToOrderResponse(this CustomerDto customerDto, OrderDto orderDto)
    {
        Customer customer = new Customer()
        {
            FirstName = customerDto.FirstName,
            LastName = customerDto.LastName,
        };
        
        var orderItems = orderDto.OrderItems.Select(x => new OrderItem()
        {
            Product = x.Product,
            Quantity = x.Quantity,
            Price = x.Price,
        }).ToList();

        Order order = new Order()
        {
            OrderId = orderDto.OrderId,
            OrderDate = orderDto.OrderDate,
            OrderItems = orderItems,
            DeliveryAddress = orderDto.DeliveryAddress,
            DeliveryExpected = orderDto.DeliveryExpected,
        };

        return new GetOrderResponse()
        {
            Customer = customer,
            Order = order
        };
    }
}