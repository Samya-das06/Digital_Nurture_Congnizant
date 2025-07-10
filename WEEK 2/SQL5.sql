--SQL FILE 5

--Functions-table valued function.
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
(2, 'Rinki', 25, 'Los Angeles'),
(3, 'Riti', 35, 'Chicago'),
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

--
IF OBJECT_ID('dbo.GetPeopleAboveAge', 'IF') IS NOT NULL
    DROP FUNCTION dbo.GetPeopleAboveAge;
GO


CREATE FUNCTION dbo.GetPeopleAboveAge(@MinAge INT)
RETURNS TABLE
AS
RETURN
(
    SELECT ID, Name, Age, City
    FROM dbo.PersonalDetails
    WHERE Age > @MinAge
);
GO

-- Use the function like a table
SELECT * FROM dbo.GetPeopleAboveAge(30);
