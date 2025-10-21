-- Insert Data into the Customers Table

INSERT INTO Customers (CustomerId, Firstname, Lastname, Email, HouseNo, Street, Town, PostCode)
VALUES ('C34454', 'Bob', 'Marshal', 'bob@aol.com', '1A', 'Uppingham Gate', 'Uppingham', 'LE15 9NY'),
       ('R34788', 'Jack', 'Ross', 'jack@yahoo.com', '4B', 'Strabrokeway', 'Wortley', 'LS12 4NB'),
       ('A99001', 'Chris', 'Gregory', 'chris@gmail.com', '7A', 'Marsh Lane', 'Leeds', 'LS9 7NE'),
       ('X45001', 'Ken', 'Martin', 'ken@aol.com', '32B', 'Harehills', 'York', 'LE15 9NY');

-- Insert Data into Products Table

INSERT INTO Products (ProductId, Name, Color, Size)
VALUES (110, 'Tennis Ball', 'Yellow', 'S'),
       (111, 'Tennis Net', 'White', 'XL'),
       (112, 'Tennis Racket', 'White', 'L'),
       (113, 'Tennis Gear', 'White', 'XL');

--Insert Data into Orders Table

INSERT INTO Orders (OrderId, CustomerId, OrderDate, DeliveryExpected, ContainsGift)
VALUES (456, 'R34788', '2023-05-03', '2023-05-10', 0),
       (545, 'C34454', '2023-06-07', '2023-06-15', 0),
       (652, 'A99001', '2023-07-10', '2023-07-25', 1),
       (667, 'R34788', '2023-09-20', '2023-09-30', 0),
       (786, 'R34788', '2023-10-28', '2023-11-21', 1);

-- Insert Data into Order Items Table
INSERT INTO OrderItems (OrderItemId, OrderId, ProductId, Quantity, Price)
VALUES (965, 456, 110, 3, 45),
       (966, 456, 113, 1, 120),
       (1001, 545, 111, 1, 150),
       (1150, 652, 111, 1, 150),
       (1151, 652, 112, 2, 300),
       (1152, 652, 110, 5, 65),
       (2151, 786, 113, 1, 120),
       (2152, 786, 110, 2, 30),
       (2153, 786, 112, 1, 75);
