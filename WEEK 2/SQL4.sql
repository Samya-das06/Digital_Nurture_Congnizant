--SQL FILE 4

--Create an index.
IF OBJECT_ID('dbo.PersonalDetails', 'U') IS NOT NULL
    DROP TABLE dbo.PersonalDetails;

CREATE TABLE dbo.PersonalDetails (
    ID INT,
    Name VARCHAR(100),
    Age INT,
    City VARCHAR(100)
);

INSERT INTO dbo.PersonalDetails (ID, Name, Age, City) VALUES
(1, 'Pritika', 24, 'New York'),
(2, 'Riti', 25, 'Los Angeles'),
(3, 'Rinki', 35, 'Chicago'),
(4, 'Priti', 40, 'Houston'),
(5, 'Pakhi', 28, 'Seattle');

IF OBJECT_ID('dbo.GetOlderPeople', 'P') IS NOT NULL
    DROP PROCEDURE dbo.GetOlderPeople;
GO

CREATE PROCEDURE dbo.GetOlderPeople
    @MinAge INT
AS
BEGIN
    SELECT ID, Name, Age, City
    FROM dbo.PersonalDetails
    WHERE Age > @MinAge;
END;
GO

EXEC dbo.GetOlderPeople @MinAge = 25;

CREATE INDEX idx_age ON PersonalDetails(Age);

CREATE UNIQUE INDEX idx_unique_name ON PersonalDetails(Name);

