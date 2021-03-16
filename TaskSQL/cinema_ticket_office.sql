CREATE DATABASE cinema_ticket_office;
GO

USE cinema_ticket_office;

CREATE TABLE Movies
(
	Id INT PRIMARY KEY IDENTITY,
	MovieName NVARCHAR(80) UNIQUE NOT NULL,
	Lenght TIME NOT NULL,
);

CREATE TABLE Genres
(
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(30) UNIQUE NOT NULL
	CONSTRAINT CH_Genre_GenreName CHECK (LEN(GenreName) > 3)
);

CREATE TABLE MovieGenres
(
	MovieId INT,
	GenreId INT,
	PRIMARY KEY (MovieId, GenreId),
	FOREIGN KEY (MovieId) REFERENCES Movies (Id) ON DELETE CASCADE,
	FOREIGN KEY (GenreId) REFERENCES Genres (Id) ON DELETE CASCADE
);

CREATE TABLE CinemaSessions
(
	Id INT PRIMARY KEY IDENTITY,
	MovieId INT NOT NULL,
	StartDate DATETIME UNIQUE NOT NULL,
	FOREIGN KEY (MovieId) REFERENCES Movies (Id)
		ON DELETE CASCADE
);

CREATE TABLE Tickets
(
	RowNumber INT,
	PlaceNumber INT,
	SessionId INT,
	Price MONEY NOT NULL DEFAULT 0,
	PRIMARY KEY (RowNumber, PlaceNumber, SessionId),
	FOREIGN KEY (SessionId) REFERENCES CinemaSessions (ID)
		ON DELETE CASCADE
);

CREATE TABLE Sales
(
	Id INT PRIMARY KEY IDENTITY,
	TicketRowNumber INT NOT NULL,
	TicketPlaceNumber INT NOT NULL,
	SessionId INT NOT NULL,
	SaleTime DATETIME UNIQUE NOT NULL,
	FOREIGN KEY (TicketRowNumber, TicketPlaceNumber, SessionId)
	REFERENCES Tickets (RowNumber, PlaceNumber, SessionId)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);
GO

INSERT INTO Movies
VALUES
('The Shawshank Redemption', '02:22:00'),
('The Lord of the Rings: The Return of the King', '03:21:00'),
('The Green Mile', '03:09:00'),
('Interstellar', '02:49:00'),
('The Lord of the Rings: The Fellowship of the Ring', '02:58:00'),
('Forrest Gump', ' 02:22:00'),
('Schindler''s List', '03:15:00'),
('Intouchables', '01:52:00'),
('The Lion King', '01:28:00'),
('Back to the Future', '01:56:00'),
('Snatch', '01:44:00'),
('Klaus', '01:36:00'),
('Lock, Stock and Two Smoking Barrels', '01:47:00'),
('Pulp Fiction', '02:34:00'),
('Inception', '02:28:00')

INSERT INTO Genres
VALUES
('Thriller'),
('Detective'),
('Drama'),
('Crime '),
('Adventures'),
('Fantasy'),
('Fantastic '),
('Comedy'),
('History'),
('Biography')

INSERT INTO MovieGenres
VALUES
(1, 3),
(2, 5),
(2, 6),
(3,3),
(3,4),
(4,7),
(4,3),
(4,5),
(5,5),
(5,6),
(6,8),
(6,9),
(7,9),
(7,3)

INSERT INTO CinemaSessions
VALUES
(5, '20210212 10:00:00'),
(12, '20210212 16:00:00'),
(6, '20210212 21:00:00'),
(3, '20210213 09:00:00'),
(4, '20210213 15:00:00'),
(7, '20210213 20:00:00'),
(1, '20210214 11:00:00'),
(2, '20210214 17:00:00'),
(11, '20210214 22:00:00'),
(4, '20210215 12:00:00'),
(6, '20210215 18:00:00'),
(7, '20210215 23:00:00')

INSERT INTO Tickets
VALUES
(3, 3, 1, 50),
(2, 4, 1, 75),
(1, 5, 1, 100),
(3, 3, 3, 33),
(1, 1, 3, DEFAULT),
(1, 3, 3, 120),
(3, 3, 4, 40),
(2, 4, 4, 60),
(1, 3, 4, 80),
(3, 5, 6, 50),
(2, 4, 7, 75),
(1, 5, 8, 100),
(3, 3, 9, 50),
(2, 4, 10, 60),
(1, 1, 11, DEFAULT)

INSERT INTO Sales
VALUES
(3, 3, 1, '20210212 10:13:07'),
(2, 4, 10, '20210212 14:05:03'),
(1, 5, 8, '20210212 16:16:16'),
(3, 3, 9, '20210213 10:13:07'),
(2, 4, 4, '20210213 14:05:03'),
(1, 1, 3, '20210213 16:16:16'),
(3, 3, 3, '20210214 10:13:07'),
(2, 4, 1, '20210214 14:05:03'),
(1, 5, 1, '20210214 16:16:16')