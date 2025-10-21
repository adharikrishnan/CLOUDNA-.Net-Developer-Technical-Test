CREATE TABLE Orders
(
    OrderId          INT PRIMARY KEY,
    CustomerId       NVARCHAR(10) FOREIGN KEY (CustomerId) REFERENCES Customers (CustomerId),
    OrderDate        DATE,
    DeliveryExpected DATE,
    ContainsGift     BIT,
);