CREATE DATABASE BillsManagement;

USE BillsManagement;

CREATE TABLE Customers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(150),
LastName VARCHAR(150),
Email VARCHAR(200),
);

CREATE TABLE Addresses
(
Id INT IDENTITY(1,1) PRIMARY KEY,
StreetName VARCHAR(200),
StreetNumber INT,
City VARCHAR(150),
CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Contracts
(
Id INT IDENTITY(1,1) PRIMARY KEY,
ContractType VARCHAR(150),
StartDate DATE,
EndDate DATE,
);

CREATE TABLE Customers_Contracts
(
Id INT IDENTITY(1,1) PRIMARY KEY,
CustomerId INT REFERENCES Customers(Id),
ContractId INT REFERENCES Contracts(Id)
);

CREATE TABLE Bills
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Amount MONEY,
Deadline DATE,
IsPaid BIT,
ContractId INT REFERENCES Contracts(Id)
);

INSERT INTO Customers
VALUES('Ana', 'Mitrea', 'am@gmail.com');
INSERT INTO Customers
VALUES('Andrei', 'Stan', 'as@gmail.com');
INSERT INTO Customers
VALUES('Cristina', 'Ciocan', 'cc@gmail.com');
INSERT INTO Customers
VALUES('Teodor', 'Nistor', 'tn@gmail.com');
INSERT INTO Customers
VALUES('Stefania', 'Iancu', 'si@gmail.com');

SELECT *
FROM Customers;

INSERT INTO Addresses
VALUES('s1', 10, 'Iasi',1);
INSERT INTO Addresses
VALUES('s2', 532, 'Bacau',1);
INSERT INTO Addresses
VALUES('s3', 43, 'Ploiesti',2);
INSERT INTO Addresses
VALUES('s4', 123, 'Constanta',3);
INSERT INTO Addresses
VALUES('s5', 112, 'Suceava',4);
INSERT INTO Addresses
VALUES('s6', 132, 'Iasi',5);
INSERT INTO Addresses
VALUES('s7', 532, 'Suceava',4);
INSERT INTO Addresses
VALUES('s8', 53, 'Cluj',5);
INSERT INTO Addresses
VALUES('s9', 75, 'Timisoara',2);
INSERT INTO Addresses
VALUES('s10', 43, 'Iasi',2);

SELECT *
FROM Addresses;

CREATE TABLE ContractTypes
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(25)
);

ALTER TABLE Contracts
ADD ContractType INT REFERENCES ContractTypes(Id);

INSERT INTO Contracts
VALUES('gas','2020-08-20','2020-05-12');
INSERT INTO Contracts
VALUES('elecTRicity','2021-08-20','2027-05-12');
INSERT INTO Contracts
VALUES('GAS','2019-08-20','2021-05-12');
INSERT INTO Contracts
VALUES('ELECtricity','2021-08-20','2023-05-12');
INSERT INTO Contracts
VALUES('electriCITy','2022-08-20','2024-05-12');
INSERT INTO Contracts
VALUES('gAS','2021-08-20','2025-05-12');
INSERT INTO Contracts
VALUES('Gas','2018-08-20','2023-05-12');
INSERT INTO Contracts
VALUES('electricity','2022-08-20','2027-05-12');

SELECT *
FROM Contracts;

SELECT *
FROM ContractTypes;

SELECT *
FROM Bills;

SELECT *
FROM Customers;

SELECT *
FROM Addresses;

SELECT *
FROM Customers_Contracts;

INSERT INTO Bills
VALUES (234, '2022-01-01',0,1);
INSERT INTO Bills
VALUES (151, '2022-01-01',1,2);
INSERT INTO Bills
VALUES (432, '2023-01-01',0,3);
INSERT INTO Bills
VALUES (313, '2022-02-11',0,4);
INSERT INTO Bills
VALUES (431, '2023-01-11',1,5);
INSERT INTO Bills
VALUES (122, '2022-08-01',0,6);
INSERT INTO Bills
VALUES (215, '2022-11-01',1,7);
INSERT INTO Bills
VALUES (543, '2023-08-16',0,8);
INSERT INTO Bills
VALUES (25, '2022-08-01',1,2);
INSERT INTO Bills
VALUES (642, '2022-06-01',0,3);
INSERT INTO Bills
VALUES (218, '2022-03-11',1,2);

INSERT INTO ContractTypes
VALUES('gas');

INSERT INTO ContractTypes
VALUES ('electricity');

SELECT *
FROM Contracts;
SELECT *
FROM Customers;
SELECT *
FROM Customers_Contracts;

INSERT INTO Customers_Contracts
VALUES(1,1);
INSERT INTO Customers_Contracts
VALUES(1,2);
INSERT INTO Customers_Contracts
VALUES(2,3);
INSERT INTO Customers_Contracts
VALUES(2,4);
INSERT INTO Customers_Contracts
VALUES(3,5);
INSERT INTO Customers_Contracts
VALUES(3,6);
INSERT INTO Customers_Contracts
VALUES(4,7);
INSERT INTO Customers_Contracts
VALUES(1,8);

-- 3. Display all the customers' information ordered by the last name descending.

SELECT *
FROM Customers
ORDER BY LastName DESC;

-- 4. Display information about the bill with the highest amount.

SELECT Id, Amount, Deadline, IsPaid, ContractId
FROM Bills
WHERE Amount =(SELECT MAX(Amount) FROM Bills);

-- 5. Display the customers' information (just customer id, email address, street name, street number and city) together with their corresponding addresses.

SELECT c.Id, c.Email, a.City, a.StreetName, a.StreetNumber
FROM Customers c
INNER JOIN Addresses a ON c.Id = a.CustomerId;

-- 6. Pretend that one bill was paid today. Update it's corresponding information to reflect that.

UPDATE Bills
SET IsPaid = 1
WHERE Id = 3;

-- 7. Display the contract's information (contract id, start date, end date, bill id, amount, deadline, isPaid) together with their corresponding bills.

SELECT c.Id 'Contract ID', c.StartDate, c.EndDate, b.Id 'Bill''s ID', b.Amount,b.Deadline, b.IsPaid
FROM Contracts c
INNER JOIN Bills b ON c.Id = b.ContractId;

-- 8.Display the contract's information (contract id, start date, end date, contract type, bill id, amount, deadline, isPaid) together with their corresponding bills.

SELECT c.Id 'Contract ID', c.StartDate, c.EndDate, ct.Name, b.Id 'Bill''s ID', b.Amount,b.Deadline, b.IsPaid
FROM Contracts c
    LEFT JOIN Bills b ON c.Id = b.ContractId
    INNER JOIN ContractTypes ct ON ct.Id = c.Id;

-- 9. Display the customers' information (just customer id, email address, contract end date & contract type) together with their corresponding contract type(s).

SELECT cu.Id 'Customer ID', cu.Email, ct.EndDate, ct.ContractType 'ID Contract Type'
FROM Customers_Contracts cc
    INNER JOIN Customers cu ON cu.Id = cc.ContractId
    INNER JOIN Contracts ct ON ct.Id = cc.CustomerId;

-- 10. On exercise above make sure to display even the customers who don't have yet a contract.

SELECT cu.Id 'Customer ID', cu.Email, ct.EndDate, ct.ContractType 'ID Contract Type'
FROM Customers_Contracts cc
    INNER JOIN Customers cu ON cu.Id = cc.ContractId
    RIGHT JOIN Contracts ct ON ct.Id = cc.CustomerId;

-- 11.Display the number of addresses a user has based on his / her email. Tip: use the customer's email when counting and grouping the records.

SELECT COUNT(a.StreetName) 'Number of Addresses'
FROM Customers c
INNER JOIN Addresses a ON c.Id = a.CustomerId
GROUP BY c.Email
HAVING c.Email = 'am@gmail.com';

-- 12.Create a function that for a specific customer email returns the number of addresses that he / she has registered. The final column name should have the alias 'NumberOfAddreses'.

GO
CREATE FUNCTION dbo.GetNumberOfAddresses(
    @inputEmail VARCHAR(100)
)
RETURNS INT
AS
BEGIN
    DECLARE @numberOfAddresses INT;
    SET @numberOfAddresses = (
        SELECT COUNT(a.StreetName) 'NumberOfAddreses'
        FROM Customers c
            INNER JOIN Addresses a ON c.Id = a.CustomerId
        GROUP BY c.Email
        HAVING c.Email = @inputEmail)
    RETURN @numberOfAddresses;
END;
GO

SELECT dbo.GetNumberOfAddresses('am@gmail.com') 'NumberOfAddreses';

--  13. Create a view that contains all the information about the customers (id, email) who have unpaid bills, including the bill amount to be paid and the deadline

GO
CREATE VIEW GetCustomersUnpaidBills
AS
    SELECT cc.CustomerId, b.IsPaid, b.Amount, b.Deadline
    FROM Contracts c
            INNER JOIN Bills b ON b.ContractId = c.Id
            INNER JOIN Customers_Contracts cc ON cc.ContractId = c.Id
    WHERE b.IsPaid = 0;
GO

SELECT *
FROM GetCustomersUnpaidBills;

GO
CREATE VIEW CustomersWithUnpaidBills
AS
    SELECT c.Id 'Customer ID', c.Email, gub.Amount 'Amount to be paid', gub.Deadline 
    FROM GetCustomersUnpaidBills gub
     INNER JOIN Customers c ON c.Id = gub.CustomerId;
GO


 --  a) Query the view to get all data.

SELECT *
FROM CustomersWithUnpaidBills;

 --  b) Query the view to get all bills that have a deadline in the future.

SELECT *
FROM CustomersWithUnpaidBills
WHERE Deadline > GETDATE();