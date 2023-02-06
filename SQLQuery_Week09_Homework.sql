CREATE DATABASE LibrariesManagement;

USE LibrariesManagement;

CREATE TABLE Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(50),
    StreetName VARCHAR(50),
    City VARCHAR(50)
)

CREATE TABLE Librarians
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(30),
    HireDate Date,
    IsOnHoliday VARCHAR(3),
    LibraryId INT REFERENCES Libraries(Id)
)

CREATE TABLE Books
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Title VARCHAR(50),
    AuthorFirstName VARCHAR(30),
    AuthorLastName VARCHAR(30),
    Type VARCHAR(10), -- crime, fantasy, horror, adventure
)

CREATE TABLE Books_Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    LibraryId INT REFERENCES Libraries(Id)
)

CREATE TABLE Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    NumberOfCopies INT,
    LibraryId INT REFERENCES Libraries(Id),
    LibrarianId INT REFERENCES Librarians(Id)
)

CREATE TABLE Books_Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    SalesId INT REFERENCES Sales(Id)
)

-- column LibraryID is redundanted. We can join with Sales table for connect with Library table

ALTER TABLE Librarians 
DROP CONSTRAINT FK__Librarian__Libra__398D8EEE;

ALTER TABLE Librarians
DROP COLUMN LibraryId;

-- We need to create an Authors table so that the Books table will have a reference to it

CREATE TABLE Authors
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(150),
    Birthday DATE
)

-- we will delete columns AuthorFirstName and AuthorLastName from Books table and will create a column AuthorId, with a reference to Id from Authors table.

ALTER TABLE Books
DROP COLUMN AuthorFirstName;

ALTER TABLE Books
DROP COLUMN AuthorLastName;

ALTER TABLE Books
ADD AuthorId INT REFERENCES Authors(Id);

-- we will create a table TypesOfBooks with references type in Books table - TypeId

CREATE TABLE TypesOfBooks
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Type VARCHAR(60) NOT NULL
)

ALTER TABLE Books 
DROP COLUMN Type;

ALTER TABLE Books 
ADD TypeId INT REFERENCES TypesOfBooks(Id);

ALTER TABLE Authors
ADD CONSTRAINT Email CHECK(Email LIKE '%@%');

-- INSERT VALUES

INSERT INTO Authors
VALUES ('Mihai','Popescu','mp@email.com','1988-11-11');
INSERT INTO Authors
VALUES ('Catalin','Zamfirescu','cz@email.com','1973-06-08');
INSERT INTO Authors
VALUES ('Mircea','Stoian','ms@email.com','1969-02-14');

INSERT INTO TypesOfBooks
VALUES ('comedy');
INSERT INTO TypesOfBooks
VALUES ('adventure');
INSERT INTO TypesOfBooks
VALUES ('fantasy');
INSERT INTO TypesOfBooks
VALUES ('crime');
INSERT INTO TypesOfBooks
VALUES ('horror');

INSERT INTO Books 
VALUES ('Book1', 2, 2);
INSERT INTO Books 
VALUES ('Book2', 1, 3);
INSERT INTO Books 
VALUES ('Book3', 3, 1);
INSERT INTO Books 
VALUES ('Book4', 2, 4);
INSERT INTO Books 
VALUES ('Book5', 3, 5);
INSERT INTO Books 
VALUES ('Book6', 2, 1);
INSERT INTO Books 
VALUES ('Book7', 3, 1);
INSERT INTO Books 
VALUES ('Book8', 2, 4);
INSERT INTO Books 
VALUES ('Book9', 2, 5);
INSERT INTO Books 
VALUES ('Book10', 3, 3);

--delete all values and reset Id from Books because i had some errors
DELETE FROM Books;
DBCC CHECKIDENT ('Books', RESEED, 0);

-- INSERT VALUES

INSERT INTO Libraries
VALUES ('Library1', 'Bucegilor','Bucuresti');
INSERT INTO Libraries
VALUES ('Library2', 'Carol I','Iasi');
INSERT INTO Libraries
VALUES ('Library3', 'Independentei','Brasov');
INSERT INTO Libraries
VALUES ('Library4', 'Timisoarei','Craiova');
INSERT INTO Libraries
VALUES ('Library5', 'Stejarului','Arad');
INSERT INTO Libraries
VALUES ('Library6', 'Soarelui','Oradea');

-- alter column IsOnHoliday from Librarians table into BIT

ALTER TABLE Librarians
ALTER COLUMN IsOnHoliday BIT;

-- insert values

INSERT INTO Librarians
VALUES ('Mihai Ionel','2005-12-14', 0);
INSERT INTO Librarians
VALUES ('Catalin Popescu','2009-07-08', 1);
INSERT INTO Librarians
VALUES ('Stoian Petru','2015-02-04', 0);
INSERT INTO Librarians
VALUES ('Cristian Ioan','2012-08-09', 1);
INSERT INTO Librarians
VALUES ('Mircea Popa','2010-11-20', 0);
INSERT INTO Librarians
VALUES ('Carol Dumitru','2011-09-08', 0);
INSERT INTO Librarians
VALUES ('Robert Dumitrescu','2019-10-10', 1);

INSERT INTO Sales
VALUES(22,1,2);
INSERT INTO Sales
VALUES(64,2,1);
INSERT INTO Sales
VALUES(25,3,3);
INSERT INTO Sales
VALUES(72,4,4);
INSERT INTO Sales
VALUES(14,5,5);
INSERT INTO Sales
VALUES(34,6,6);
INSERT INTO Sales
VALUES(41,1,7);

INSERT INTO Books_Libraries
VALUES (1,5);
INSERT INTO Books_Libraries
VALUES (2,3);
INSERT INTO Books_Libraries
VALUES (3,4);
INSERT INTO Books_Libraries
VALUES (4,2);
INSERT INTO Books_Libraries
VALUES (5,1);
INSERT INTO Books_Libraries
VALUES (6,4);
INSERT INTO Books_Libraries
VALUES (7,6);
INSERT INTO Books_Libraries
VALUES (8,2);
INSERT INTO Books_Libraries
VALUES (9,3);
INSERT INTO Books_Libraries
VALUES (10,2);
INSERT INTO Books_Libraries
VALUES (5,3);
INSERT INTO Books_Libraries
VALUES (5,1);
INSERT INTO Books_Libraries
VALUES (2,5);
INSERT INTO Books_Libraries
VALUES (1,3);
INSERT INTO Books_Libraries
VALUES (7,1);
INSERT INTO Books_Libraries
VALUES (8,2);
INSERT INTO Books_Libraries
VALUES (10,3);

INSERT INTO Books_Sales
VALUES (1,1);
INSERT INTO Books_Sales
VALUES (3,2);
INSERT INTO Books_Sales
VALUES (5,3);
INSERT INTO Books_Sales
VALUES (6,4);
INSERT INTO Books_Sales
VALUES (7,5);
INSERT INTO Books_Sales
VALUES (9,6);
INSERT INTO Books_Sales
VALUES (10,7);

-- 2. Display all the librarians together with the library name they work in ordered by librarian name and library name descending.

SELECT l.Name, LI.Name
FROM Sales s
    INNER JOIN Librarians l ON l.Id = s.LibrarianId
    INNER JOIN Libraries LI ON LI.Id = s.LibraryId
ORDER BY l.Name, LI.Name DESC;

-- 3. Update all the street names to start with "STR.".

UPDATE Libraries
SET StreetName = CONCAT('STR. ', StreetName);

-- 4. Display the authors' email for those who have more than 3 books published.

SELECT a.Email 'Authors''s email with more than 3 books published'
FROM Books b
    INNER JOIN Authors a ON a.Id = b.AuthorId
GROUP BY a.Email
HAVING COUNT(AuthorId) > 3;

-- 5. Display the library name and the book title of the largest sale (the highest number of copies sold in one sale).

GO
CREATE VIEW BookIdAndNumberOfCopiesByLibrary
AS
    SELECT b.Title, s.LibraryId, s.NumberOfCopies
    FROM Books_Sales bs
     INNER JOIN Books b ON b.Id = bs.BookId
     INNER JOIN Sales s ON s.Id = bs.SalesId;
GO

SELECT SUM(bv.NumberOfCopies), l.Name
FROM BookIdAndNumberOfCopiesByLibrary bv
    INNER JOIN Libraries l ON l.Id = bv.LibraryId
GROUP BY l.Name
HAVING SUM(bv.NumberOfCopies) = (SELECT MAX(NumberOfCopies) FROM BookIdAndNumberOfCopiesByLibrary)

-- 6. Display all the librarians that are not on holiday and are hired more than 5 years ago.

SELECT * 
FROM Librarians l
WHERE l.IsOnHoliday = 0 AND DATEDIFF(YYYY,l.HireDate,GETDATE()) > 5;

--OR

-- GO
-- CREATE PROCEDURE GetExperienceByYearsForPresentLibrarians(
--     @yearsExperience INT
-- )
-- AS 
-- BEGIN
--     SELECT *
--     FROM Librarians l
--     WHERE l.IsOnHoliday = 0 AND DATEDIFF(YYYY,l.HireDate,GETDATE()) > @yearsExperience;
-- END
-- GO

-- EXEC GetExperienceByYearsForPresentLibrarians 5;

-- 7. Create a stored procedure that displays, based on the book title, the number of libraries in which the book is found. Call the procedure with three different book titles.

GO
CREATE PROCEDURE GetNumberOfLibrariesByBookTitle(
    @customerBookTitle VARCHAR(100)
)
AS 
BEGIN
    SELECT COUNT(l.Id)
    FROM Books_Libraries bl
        INNER JOIN Books b ON bl.BookId = b.Id
        INNER JOIN Libraries l ON bl.LibraryId = l.Id
    GROUP BY b.Title
    HAVING b.Title = @customerBookTitle;
END
GO

EXEC GetNumberOfLibrariesByBookTitle 'Book1';
EXEC GetNumberOfLibrariesByBookTitle 'Book3';
EXEC GetNumberOfLibrariesByBookTitle 'Book5';

-- 8. Create a function that returns, based on the author's email, the number of copies sold for each of his / her books. Call the function with three different emails.

GO
CREATE VIEW BookIdAndNumberOfCopiesByAuthorId
AS
    SELECT b.Title, s.LibraryId, s.NumberOfCopies, b.AuthorId 
    FROM Books_Sales bs
     INNER JOIN Books b ON b.Id = bs.BookId
     INNER JOIN Sales s ON s.Id = bs.SalesId;
GO

GO
CREATE FUNCTION dbo.GetNumberOfCopiesOfBooksByAuthorsEmail(
    @customerAuthorsEmail VARCHAR(100)
)
RETURNS INT
AS
BEGIN
    DECLARE @numberOfCopies INT;
    SET @numberOfCopies = (SELECT SUM(bc.NumberOfCopies)
                           FROM BookIdAndNumberOfCopiesByAuthorId bc
                                INNER JOIN Authors a ON a.Id = bc.AuthorId
                            GROUP BY a.Email
                            HAVING a.Email = @customerAuthorsEmail);
    RETURN @numberOfCopies;
END;
GO

SELECT dbo.GetNumberOfCopiesOfBooksByAuthorsEmail('mp@email.com') as 'Number of copies';
SELECT dbo.GetNumberOfCopiesOfBooksByAuthorsEmail('ms@email.com') as 'Number of copies';
SELECT dbo.GetNumberOfCopiesOfBooksByAuthorsEmail('cz@email.com') as 'Number of copies';


-- 9. Create a trigger so that when a new librarian is added to the system with no library assigned (NULL on LibraryId), he / she is automatically assigned to a library.

GO
CREATE VIEW LibrariesAndLibrarians
AS
    SELECT LL.Id 'Library ID', LL.Name 'Library Name', L.Id 'Librarian ID', L.Name 'Librarian Name'
    FROM Sales s
        INNER JOIN Librarians L ON s.LibrarianId = L.Id
        INNER JOIN Libraries LL ON s.LibraryId = LL.Id;
GO

SELECT * FROM LibrariesAndLibrarians

GO
CREATE TRIGGER AutoAssignedLibraryToNewLibrarianWithoutLibrary
ON Librarians
AFTER INSERT
AS
BEGIN
    INSERT INTO Sales (NumberOfCopies, LibraryId, LibrarianId)
    VALUES (0, 1, (SELECT MAX(Id) FROM Librarians))
END
GO

DROP TRIGGER AutoAssignedLibraryToNewLibrarianWithoutLibrary

DBCC CHECKIDENT ('Librarians', RESEED, 1)

SET IDENTITY_INSERT Librarians ON;
INSERT INTO Librarians(Id, Name, HireDate, IsOnHoliday)
VALUES (8,'Catalin Stefanescu','2022-12-12',0);
SET IDENTITY_INSERT Librarians OFF;

SELECT * FROM Librarians
SELECT * FROM Sales
SELECT * FROM LibrariesAndLibrarians
SELECT * FROM TypesOfBooks

-- 10. Create a transaction that should have at least three commands inside it. Based on the logic you think of use at least one savepoint and at least one rollback operation.

BEGIN TRANSACTION
UPDATE TypesOfBooks SET Type = CONCAT('Type: ', Type);
SAVE TRANSACTION InsertWordTypeOnTypesOfBooks;
UPDATE TypesOfBooks SET Type = CONCAT('Genre: ', Type);
ROLLBACK TRANSACTION InsertWordTypeOnTypesOfBooks;

BEGIN TRANSACTION AddDefaultOneValueCopiesBooks
UPDATE Sales SET NumberOfCopies = NumberOfCopies + 1;

BEGIN TRANSACTION DefaulValuesCopiesBooks -- ??? REDUNDANT ????
UPDATE Sales SET NumberOfCopies = NumberOfCopies -1;
SAVE TRANSACTION DefaultCopiesBooks;
UPDATE Sales SET NumberOfCopies = NumberOfCopies + 100;
ROLLBACK TRANSACTION DefaultCopiesBooks;