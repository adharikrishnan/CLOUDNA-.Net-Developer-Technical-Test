SET QUOTED_IDENTIFIER ON; 
SET ANSI_NULLS ON;
GO

CREATE OR ALTER PROCEDURE dbo.Get_Customer
    @Customerid NVARCHAR(10),
    @Email NVARCHAR(50)
AS
BEGIN
    SELECT Firstname, Lastname
    FROM dbo.Customers
    WHERE Customerid = @Customerid
    AND Email = @Email;
END
