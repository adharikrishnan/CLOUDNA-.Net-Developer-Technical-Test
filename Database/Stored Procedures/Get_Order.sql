SET QUOTED_IDENTIFIER ON; 
SET ANSI_NULLS ON;
GO

CREATE OR ALTER PROCEDURE dbo.Get_Order
    @Customerid NVARCHAR(10)    
AS
BEGIN
    SELECT TOP 1
        o.OrderId,
        o.OrderDate,
        CONCAT_WS(', ', CONCAT(c.Houseno, ' ' ,c.Street), c.Town, c.PostCode) AS DeliveryAddress,
        o.DeliveryExpected
    FROM Orders o
    INNER JOIN Customers c ON c.CustomerId = o.CustomerId
    WHERE c.CustomerId = @Customerid
    ORDER BY OrderDate DESC;
END
