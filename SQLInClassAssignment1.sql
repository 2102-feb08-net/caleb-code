CREATE TABLE Customers(

ID INT NOT NULL PRIMARY KEY, 
FirstName NVARCHAR(100),
LastName NVARCHAR(100),
Cardnumber DECIMAL 
);

CREATE TABLE Products(
	ID INT NOT NULL PRIMARY KEY,
	Name NVARCHAR(200),
	Price MONEY
);

CREATE TABLE Orders(

	ID INT NOT NULL,
	ProductID INT,
	CustomerID INT
	FOREIGN KEY(CustomerID) REFERENCES Customers(ID),
	FOREIGN KEY(ProductID) REFERENCES Products(ID)
);

INSERT INTO Customers(ID, FirstName, LastName, Cardnumber) VALUES
	(0, 'Jebediah', 'Georgie', 457239),
	(1, 'Sara', 'Miller', 492384),
	(2, 'Brock', 'TheRock', 123456)

INSERT INTO Products(ID, Name, Price) VALUES
	(0, 'Apple', 1.00),
	(1, 'Orange', 2.00),
	(2, 'Banana', 3.00)

INSERT INTO Orders(ID, ProductID, CustomerID) VALUES
	(0, 0, 0),
	(1, 1, 1),
	(2, 2, 2)

INSERT INTO Products(ID, Name, Price) VALUES
	(3, 'Iphone', 200.00)

INSERT INTO Customers(ID, FirstName, LastName, Cardnumber) VALUES
	(3, 'Tina', 'Smith', 987654)

INSERT INTO Orders(ID, ProductID, CustomerID) VALUES
	(3, 3, 3)


SELECT * FROM Orders
WHERE Orders.CustomerID = '3'




UPDATE Products
 SET Price = 250.00
 WHERE Name = 'Iphone';
