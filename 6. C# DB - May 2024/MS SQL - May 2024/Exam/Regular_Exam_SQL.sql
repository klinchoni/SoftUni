--01. DDL
CREATE DATABASE [Library]

USE [Library]

GO

CREATE TABLE Genres
(
	Id INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR (30) NOT NULL
)

CREATE TABLE Contacts
(
	Id INT PRIMARY KEY IDENTITY
	,Email NVARCHAR (100)
	,PhoneNumber NVARCHAR (20)
	,PostAddress NVARCHAR (200)
	,Website NVARCHAR (50)
)

CREATE TABLE Authors
(
	Id INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR (100) NOT NULL
	,ContactId INT FOREIGN KEY REFERENCES Contacts (Id) NOT NULL
)

CREATE TABLE Libraries
(
	Id INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR (50) NOT NULL
	,ContactId INT FOREIGN KEY REFERENCES Contacts (Id) NOT NULL
)

CREATE TABLE Books
(
	Id INT PRIMARY KEY IDENTITY
	,Title NVARCHAR (100) NOT NULL
	,YearPublished INT NOT NULL
	,ISBN NVARCHAR (13) UNIQUE NOT NULL
	,AuthorId INT FOREIGN KEY REFERENCES Authors (Id) NOT NULL
	,GenreId INT FOREIGN KEY REFERENCES Genres (Id) NOT NULL
)

CREATE TABLE LibrariesBooks
(
	LibraryId INT FOREIGN KEY REFERENCES Libraries (Id) NOT NULL
	,BookId INT FOREIGN KEY REFERENCES Books (Id) NOT NULL
	,PRIMARY KEY (LibraryId, BookId)
)

--02. Insert
INSERT INTO Contacts (
 		 Email, PhoneNumber, PostAddress, Website
  		) 
	VALUES
(NULL, NULL, NULL, NULL),
(NULL, NULL, NULL, NULL),
('stephen.king@example.com', '+4445556666', '15 Fiction Ave, Bangor, ME', 'www.stephenking.com'),
('suzanne.collins@example.com', '+7778889999', '10 Mockingbird Ln, NY, NY', 'www.suzannecollins.com');

INSERT INTO Authors (
  			Name, ContactId
  			) 
	VALUES
('George Orwell', 21),
('Aldous Huxley', 22),
('Stephen King', 23),
('Suzanne Collins', 24);


INSERT INTO Books (
  			Title, YearPublished, ISBN, AuthorId, GenreId
            ) 
	VALUES
('1984', 1949, '9780451524935', 16, 2),
('Animal Farm', 1945, '9780451526342', 16, 2),
('Brave New World', 1932, '9780060850524', 17, 2),
('The Doors of Perception', 1954, '9780060850531', 17, 2),
('The Shining', 1977, '9780307743657', 18, 9),
('It', 1986, '9781501142970', 18, 9),
('The Hunger Games', 2008, '9780439023481', 19, 7),
('Catching Fire', 2009, '9780439023498', 19, 7),
('Mockingjay', 2010, '9780439023511', 19, 7);


INSERT INTO LibrariesBooks (
  				LibraryId, BookId
                ) 
	VALUES
(1, 36),
(1, 37),
(2, 38),
(2, 39),
(3, 40),
(3, 41),
(4, 42),
(4, 43),
(5, 44);

--03. Update
SELECT 
    * 
FROM Contacts

SELECT 
   * 
FROM Authors AS a
LEFT JOIN Contacts AS c ON a.ContactId = c.Id

UPDATE Contacts
SET Website = 'www.' + REPLACE(LOWER(A.Name), ' ', '') + '.com'
FROM Contacts 
LEFT JOIN Authors AS a ON Contacts.Id = a.ContactId
WHERE Contacts.Website IS NULL

--04. Delete
DECLARE @AuthorIdToDelete INT
SET @AuthorIdToDelete = (
			SELECT Id FROM Authors
			WHERE Name = 'Alex Michaelides')

-- First I delete records from 'LibrariesBooks' that reference books by 'Alex Michaelides'
DELETE lb
FROM LibrariesBooks lb
JOIN Books b ON lb.BookId = b.Id
WHERE b.AuthorId = @AuthorIdToDelete

-- Then, I delete books by 'Alex Michaelides'
DELETE FROM Books 
WHERE AuthorId = @AuthorIdToDelete

-- Finally, I delete 'Alex Michaelides' from 'Authors'
DELETE FROM Authors 
WHERE Id = @AuthorIdToDelete

--05. Chronological Order
SELECT Title AS [Book Title], ISBN, YearPublished AS YearReleased
FROM Books
ORDER BY YearPublished DESC, Title 

--06. Books by Genre
SELECT b.Id, b.Title, b.ISBN, g.Name AS Genre
FROM Books b
JOIN Genres g ON b.GenreId = g.Id
WHERE g.Name IN ('Biography', 'Historical Fiction')
ORDER BY g.Name , b.Title 

--07. Missing Genre
SELECT l.Name AS Library, c.Email
FROM Libraries l
JOIN Contacts c ON l.ContactId = c.Id
WHERE l.Id NOT IN (
    SELECT lb.LibraryId
    FROM LibrariesBooks lb
    JOIN Books b ON lb.BookId = b.Id
    JOIN Genres g ON b.GenreId = g.Id
    WHERE g.Name = 'Mystery'
)
ORDER BY l.Name 

--08. First 3 Books
SELECT TOP (3)
b.Title, b.YearPublished AS Year, g.Name AS Genre
FROM Books b
JOIN Genres g ON b.GenreId = g.Id
WHERE (b.YearPublished > 2000 AND b.Title LIKE '%a%') 
   OR (b.YearPublished < 1950 AND g.Name LIKE '%Fantasy%')
ORDER BY b.Title, b.YearPublished DESC

--09. Authors from UK
SELECT a.Name AS Author, c.Email, c.PostAddress AS Address
FROM Authors a
JOIN Contacts c ON a.ContactId = c.Id
WHERE c.PostAddress LIKE '%UK%'
ORDER BY a.Name 

--10. Fictions in Denver
SELECT a.Name AS Author, b.Title, l.Name AS Library, c.PostAddress AS [Library Address]
FROM Books b
JOIN Authors a ON b.AuthorId = a.Id
JOIN LibrariesBooks lb ON b.Id = lb.BookId
JOIN Libraries l ON lb.LibraryId = l.Id
JOIN Contacts c ON l.ContactId = c.Id
JOIN Genres g ON b.GenreId = g.Id
WHERE g.Name = 'Fiction' AND c.PostAddress LIKE '%Denver%'
ORDER BY b.Title


--11. Authors with Books
CREATE FUNCTION udf_AuthorsWithBooks (@name NVARCHAR(100))
RETURNS INT
AS
BEGIN
    DECLARE @BookCount INT;
    SELECT @BookCount = COUNT(b.Id)
    FROM Authors a
    JOIN Books b ON a.Id = b.AuthorId
    JOIN LibrariesBooks lb ON b.Id = lb.BookId
    WHERE a.Name = @name
    
    RETURN @BookCount
END

--12. Search by Genre
CREATE PROCEDURE usp_SearchByGenre (@genreName NVARCHAR(30))
AS
BEGIN
    SELECT b.Title, b.YearPublished AS [Year], b.ISBN, a.Name AS Author, g.Name AS Genre
    FROM Books b
    JOIN Authors a ON b.AuthorId = a.Id
    JOIN Genres g ON b.GenreId = g.Id
    WHERE g.Name = @genreName
    ORDER BY b.Title 
END
