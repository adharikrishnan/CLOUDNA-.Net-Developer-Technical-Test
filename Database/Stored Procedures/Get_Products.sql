
SET QUOTED_IDENTIFIER ON; 
SET ANSI_NULLS ON;
GO

CREATE OR ALTER PROCEDURE dbo.Get_Products
    @OrderId INT    
AS
BEGIN
    SELECT IIF(o.ContainsGift = 1, 'Gift', p.Name) AS Product, oi.Price, oi.Quantity
    FROM Orders o 
    INNER JOIN OrderItems oi 
        ON o.OrderId = oi.Orderid
    INNER JOIN Products p 
        ON oi.Productid = p.ProductId
    WHERE Orderid = @OrderId;           
END

