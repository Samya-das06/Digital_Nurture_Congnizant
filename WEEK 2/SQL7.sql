--SQL FILE 7

--Create a stored procedure and execute.
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

EXEC dbo.GetOlderPeople @MinAge = 30;
-- Drop the procedure if it already exists
IF OBJECT_ID('dbo.GetPeopleByCity', 'P') IS NOT NULL
    DROP PROCEDURE dbo.GetPeopleByCity;
GO

-- Create a stored procedure with one input parameter
CREATE PROCEDURE dbo.GetPeopleByCity
    @City VARCHAR(100)
AS
BEGIN
    SELECT ID, Name, Age, City
    FROM dbo.PersonalDetails
    WHERE City = @City;
END;
GO
-- Execute the stored procedure with a parameter
EXEC dbo.GetPeopleByCity @City = 'New York';
