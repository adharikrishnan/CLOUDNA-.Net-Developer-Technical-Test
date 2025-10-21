CREATE TABLE OrderItems
(
    Orderitemid INT IDENTITY PRIMARY KEY,
    Orderid     INT FOREIGN KEY REFERENCES orders,
    Productid   INT FOREIGN KEY REFERENCES products,
    Quantity    INT,
    Price       DECIMAL(9, 2),
);