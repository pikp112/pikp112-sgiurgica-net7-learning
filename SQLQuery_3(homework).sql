CREATE DATABASE ZooManagement;

USE ZooManagement;

CREATE TABLE ZooInstitutions (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL, 
    City VARCHAR(150) DEFAULT 'Country Romania',
);


CREATE TABLE Visitors (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TypeOfDay VARCHAR(50) NOT NULL,
    FirstName VARCHAR(100) NOT NULL, 
    LastName VARCHAR(100) NOT NULL,
    ZooId INT REFERENCES ZooInstitutions(Id)

);


CREATE TABLE Tickets (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TypeOfTicket VARCHAR (100) NOT NULL,
    Price MONEY CHECK(Price > 1) NOT NULL DEFAULT 1,
    StartDate DATE CHECK(StartDate >= GetDate()),
    EndDate DATE CHECK(EndDate >= GetDate()+1),
    VisitorId INT REFERENCES Visitors(Id),
    ZooId INT REFERENCES ZooInstitutions(Id)
);

CREATE TABLE Animals (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TypeOfSpecies VARCHAR (100) NOT NULL UNIQUE,
    NumberOfSpecies INT DEFAULT 0,
    ZooId INT REFERENCES ZooInstitutions(Id)
);

CREATE TABLE Caretakers (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL, 
    LastName VARCHAR(100) NOT NULL,
    Salary MONEY CHECK(Salary > 100) DEFAULT 100,
    ZooId INT REFERENCES ZooInstitutions(Id)
);

CREATE TABLE Caretakers_Animals(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Caretaker INT REFERENCES Caretakers(Id),
    Animal VARCHAR (100) REFERENCES Animals(TypeOfSpecies)
);

SELECT *
FROM ZooInstitutions;

SELECT *
FROM Visitors;

SELECT *
FROM Tickets;

SELECT *
FROM Caretakers;

SELECT *
FROM Animals;

SELECT *
FROM Caretakers_Animals;

INSERT INTO ZooInstitutions
VALUES ('Magic Zoo', 'Iasi');

INSERT INTO Visitors
VALUES ('Monday', 'Alex', 'Marian',1);
INSERT INTO Visitors
VALUES ('Tuesday', 'Cosmin', 'Enache',1);
INSERT INTO Visitors
VALUES ('Wednesday', 'Marius', 'Fanea',1);
INSERT INTO Visitors
VALUES ('Monday', 'Maria', 'Anton',1);
INSERT INTO Visitors
VALUES ('Friday', 'Cosmin', 'Petrea',1);
INSERT INTO Visitors
VALUES ('Thursday', 'Ioana', 'Maria',1);
INSERT INTO Visitors
VALUES ('Saturday', 'Cristea', 'Mariana',1);
INSERT INTO Visitors
VALUES ('Sunday', 'Mircea', 'Daniela',1);
INSERT INTO Visitors
VALUES ('Sunday', 'Alexa', 'Ioan',1);
INSERT INTO Visitors
VALUES ('Friday', 'Florina', 'Petre',1);
INSERT INTO Visitors
VALUES ('Sunday', 'Cristi', 'Ion',1);

INSERT INTO Tickets
VALUES ('one day', 20, '2023-01-20', '2023-01-21', 2,1);
INSERT INTO Tickets
VALUES ('one day', 20, '2023-01-20', '2023-01-21', 1,1);
INSERT INTO Tickets
VALUES ('one week', 100, '2023-01-20', '2023-01-27', 3,1);
INSERT INTO Tickets
VALUES ('one month', 300, '2023-02-01', '2023-03-01', 4,1);
INSERT INTO Tickets
VALUES ('one day', 20, '2023-02-12', '2023-02-13', 5,1);
INSERT INTO Tickets
VALUES ('one day', 20, '2023-02-05', '2023-02-06', 6,1);
INSERT INTO Tickets
VALUES ('one week', 20, '2023-03-12', '2023-03-19', 7,1);
INSERT INTO Tickets
VALUES ('one month', 20, '2023-03-01', '2023-04-01', 8,1);
INSERT INTO Tickets
VALUES ('one day', 20, '2023-02-11', '2023-02-12', 9,1);
INSERT INTO Tickets
VALUES ('one week', 20, '2023-03-02', '2023-03-09', 10,1);
INSERT INTO Tickets
VALUES ('one day', 20, '2023-02-18', '2023-02-19', 11,1);
INSERT INTO Tickets
VALUES ('one week', 20, '2023-03-22', '2023-03-29', 6,1);
INSERT INTO Tickets
VALUES ('one day', 20, '2023-02-26', '2023-02-27', 5,1);
INSERT INTO Tickets
VALUES ('one day', 20, '2023-02-26', '2023-02-27', 9,1);

INSERT INTO Animals
VALUES ('Monkey', 8, 1);
INSERT INTO Animals
VALUES ('Tiger', 2, 1);
INSERT INTO Animals
VALUES ('Lion', 2, 1);
INSERT INTO Animals
VALUES ('Elephant', 1, 1);
INSERT INTO Animals
VALUES ('Horse', 3, 1);
INSERT INTO Animals
VALUES ('Snake', 6, 1);
INSERT INTO Animals
VALUES ('Penguin', 4, 1);
INSERT INTO Animals
VALUES ('Giraffe', 2, 1);
INSERT INTO Animals
VALUES ('Crocodile', 5, 1);

INSERT INTO Caretakers
VALUES ('Cristian','Dumitru', 2900, 1);
INSERT INTO Caretakers
VALUES ('Florin','Casian', 2500, 1);
INSERT INTO Caretakers
VALUES ('Mihai','Popa', 4000, 1);
INSERT INTO Caretakers
VALUES ('Catalin','Popescu', 3200, 1);
INSERT INTO Caretakers
VALUES ('Narcis','Andrei', 3700, 1);
INSERT INTO Caretakers
VALUES ('Robert','Amariei', 3000, 1);

INSERT INTO Caretakers_Animals
VALUES (1,'Monkey');
INSERT INTO Caretakers_Animals
VALUES (1,'Snake');
INSERT INTO Caretakers_Animals
VALUES (2,'Horse');
INSERT INTO Caretakers_Animals
VALUES (3,'Lion');
INSERT INTO Caretakers_Animals
VALUES (3,'Tiger');
INSERT INTO Caretakers_Animals
VALUES (4,'Elephant');
INSERT INTO Caretakers_Animals
VALUES (5,'Penguin');
INSERT INTO Caretakers_Animals
VALUES (5,'Giraffe');
INSERT INTO Caretakers_Animals
VALUES (6,'Crocodile');

--Number of total animals group by zoo name

SELECT zoo.name AS 'Zoo Name', SUM(a.NumberOfSpecies)'Total Animals'
FROM Animals a
INNER JOIN ZooInstitutions zoo ON a.zooId = zoo.Id
GROUP BY Name;

--Number of total animals group by zoo name and species

SELECT  zoo.Name AS 'Zoo Name', SUM(a.NumberOfSpecies) 'Total Animals' , TypeOfSpecies 'Type of Species'
FROM Animals a
INNER JOIN ZooInstitutions zoo ON a.zooId = zoo.Id
GROUP BY Name, TypeOfSpecies;

--the number of visitors per day

SELECT v.TypeOfDay 'The day of every week', zoo.Name 'Zoo Name', COUNT(v.Id) 'Number of visitors'
FROM Visitors v
INNER JOIN ZooInstitutions zoo ON zoo.Id = v.ZooId
GROUP BY Name, TypeOfDay;

--the ticket price and validity order by start date

SELECT zoo.Name, t.Price, t.StartDate, t.EndDate
FROM Tickets t
INNER JOIN ZooInstitutions zoo ON zoo.Id = t.ZooId
ORDER BY t.StartDate;

--details about the caretakers order desc by salary

SELECT zoo.Name 'Zoo Name', ct.FirstName, ct.LastName, ct.Salary
FROM Caretakers ct
INNER JOIN ZooInstitutions zoo ON zoo.Id = ct.ZooId
ORDER BY ct.Salary DESC;

--average salary by zoo

SELECT zoo.Name 'Zoo Name', AVG(ct.Salary) 'Average salaries'
FROM Caretakers ct 
LEFT JOIN ZooInstitutions zoo ON ct.ZooId = zoo.Id
GROUP BY Name;

--details about the caretakers and the total work areas they take care

SELECT ct.FirstName, ct.LastName, COUNT(a.TypeOfSpecies) 'Number of areas'
FROM Caretakers_Animals ca
    INNER JOIN Caretakers ct ON ct.Id = ca.Caretaker
    INNER JOIN Animals a ON a.TypeOfSpecies = ca.Animal
GROUP BY FirstName, LastName;

--details about the caretakers and their work area 

SELECT ct.FirstName, ct.LastName, a.TypeOfSpecies 'Type of work area'
FROM Caretakers_Animals ca
    INNER JOIN Caretakers ct ON ct.Id = ca.Caretaker
    INNER JOIN Animals a ON a.TypeOfSpecies = ca.Animal
GROUP BY FirstName, LastName, TypeOfSpecies;

-- view with caretakers from zoo

GO
CREATE VIEW ZooCaretakers
AS
SELECT zoo.Name 'Zoo Name', ct.FirstName, ct.LastName
FROM Caretakers ct JOIN ZooInstitutions zoo
ON ct.ZooId = zoo.Id;
GO

 SELECT *
 FROM ZooCaretakers;

 --view total number of tickets by type from a view

 GO 
 CREATE VIEW TotalTickets
 AS
 SELECT COUNT(t.Id) 'Total number o ticket', t.TypeOfTicket 'Type of ticket'
 FROM Tickets t
 GROUP BY TypeOfTicket;
 GO

 SELECT *
 FROM TotalTickets;

--create procedure to add a number of existing species

GO
CREATE PROCEDURE AddExistingSpecies(
    @typeOfSpecies VARCHAR(100),
    @numberOfSpecies INT
)
AS
BEGIN
    UPDATE Animals
    SET NumberOfSpecies = @numberOfSpecies
    WHERE TypeOfSpecies = @typeOfSpecies;
END;
GO

EXEC AddExistingSpecies 'Lion', 3 ;

--create function that return smallest salary by zoo id

GO
CREATE FUNCTION dbo.GetSmallestSalaryByZooId(
    @inputId INT
)
RETURNS MONEY
AS
BEGIN
    DECLARE @smallestSalary MONEY;
    SET @smallestSalary = 
        (SELECT MIN(Salary) FROM Caretakers c JOIN ZooInstitutions ON c.ZooId = ZooInstitutions.Id);
    RETURN @smallestSalary;
END;
GO

SELECT dbo.GetSmallestSalaryByZooId(1) 'Smallest Salary';

-- index

CREATE INDEX TypeOfSpeciesAndNumbers
ON Animals(TypeOfSpecies,NumberOfSpecies);

SELECT * 
FROM Animals
WHERE TypeOfSpecies = 'Crocodile';