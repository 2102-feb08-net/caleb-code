CREATE SCHEMA WordApp;
GO

-- UNIQUE all rows in table must have unique values for that column

-- IDENTITY Prevents manually setting a the column's value; auto-incrementing value for
-- each new row. not guaranteed unique by itself

CREATE TABLE WordApp.Person (
	Id INT NOT NULL IDENTITY,
	Username NVARCHAR(100) NOT NULL CHECK(LEN(Username) > 4)
		UNIQUE,  -- max length is 100 UTF-16, be generous to size
	AccountCreated DATETIME2 NULL 
		CHECK(AccountCreated < SYSUTCDATETIME())
		DEFAULT (SYSUTCDATETIME()),
	CONSTRAINT PK_Id PRIMARY KEY (Id)    -- PK_Id field will be generated randomly if not specified
);

SELECT * FROM WordApp.Person;

/*
ALTER TABLE WordApp.Person ADD
	AccountCreated DATETIME2;
*/

-- ALTER TABLE WordApp.Person DROP CONSTRAINT CK_Person_AccountC_09A971A2;



--PRIMARY KEY
--	implies NOT NULL and UNIQUE
-- the column will identify the row form the point of view of the other rows.
-- adds a clustered index by default on the column
-- it will be easy to look up a row by a primary key
-- table will be stored in primary key order

-- FOREIGN KEY
-- allow this column to reference another row,


CREATE TABLE WordApp.Message(
	Id INT NOT NULL IDENTITY,
	Contents NVARCHAR(1000) NOT NULL,
	SenderId INT NOT NULL, 
	ReceiverId INT NOT NULL
	CHECK (SenderId != ReceiverId)
);

ALTER TABLE WordApp.Message ADD CONSTRAINT
	FK_Message_Sender_Person FOREIGN KEY (SenderId) REFERENCES WordApp.Person(Id);

	
ALTER TABLE WordApp.Message ADD CONSTRAINT
	FK_Message_Receiver_Person FOREIGN KEY (ReceiverId) REFERENCES WordApp.Person(Id);

INSERT INTO WordApp.Person(Username) VALUES
	('nicko79');





