

CREATE SCHEMA SuperStore;
GO

CREATE TABLE SuperStore.Employee (
	ID INT NOT NULL UNIQUE IDENTITY,
	FirstName NVARCHAR(100) NOT NULL CHECK(LEN(FirstName) > 1),
	LastName NVARCHAR(100) NOT NULL CHECK(LEN(LastName) > 1),
	SSN VARCHAR(9) NOT NULL UNIQUE CHECK(LEN(SSN) = 9),
	DeptID INT NOT NULL,
	PRIMARY KEY (ID),
	FOREIGN KEY (DeptID) REFERENCES SuperStore.Department(ID)
	);

CREATE TABLE SuperStore.EmpDetails (
	Id INT NOT NULL IDENTITY,
	EmployeeID INT NOT NULL UNIQUE,
	FOREIGN KEY (EmployeeID) REFERENCES SuperStore.Employee(ID),
	Salary MONEY,
	Address1 NVARCHAR(100) NOT NULL,
	Address2 NVARCHAR(100),
	City NVARCHAR(100) NOT NULL,
	State NVARCHAR(50) NOT NULL,
	Country NVARCHAR(100) NOT NULL
);

CREATE TABLE SuperStore.Department (
	ID INT NOT NULL UNIQUE,
	Name NVARCHAR (100),
	Location NVARCHAR(100)
);



INSERT INTO SuperStore.Employee(ID, FirstName, LastName, SSN, DeptID) VALUES
	(111, 'Nicko', 'TheMan', 1204232, 997);


DROP TABLE SuperStore.EmpDetails, SuperStore.Department, SuperStore.Employee;