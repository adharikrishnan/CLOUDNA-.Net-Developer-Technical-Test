
SET QUOTED_IDENTIFIER ON; 
SET ANSI_NULLS ON;
GO

CREATE OR ALTER PROCEDURE dbo.Get_Products
    @OrderId INT    
AS
BEGIN
    SELECT p.Name, oi.Price, oi.Quantity
    FROM OrderItems oi 
    INNER JOIN Products p 
        ON oi.Productid = p.ProductId
    WHERE Orderid = @OrderId        
END

