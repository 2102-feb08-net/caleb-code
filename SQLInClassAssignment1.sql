CREATE TABLE Customers(

ID INT NOT NULL PRIMARY KEY, 
FirstName NVARCHAR(100),
LastName NVARCHAR(100),
Cardnumber DECIMAL 
);

CREATE TABLE Orders(

	ID INT NOT NULL,
	ProductID INT,
	CustomerID INT
);

CREATE TABLE Products(
	ID INT NOT NULL,
	Name NVARCHAR(200),
	Price MONEY
);