--SQL FILE 6

--Retuen data from a scalar function.
IF OBJECT_ID('dbo.GetFullName', 'FN') IS NOT NULL
    DROP FUNCTION dbo.GetFullName;
GO

-- Create scalar function
CREATE FUNCTION dbo.GetFullName
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50)
)
RETURNS VARCHAR(101)
AS
BEGIN
    DECLARE @FullName VARCHAR(101);
    SET @FullName = @FirstName + ' ' + @LastName;
    RETURN @FullName;
END;
GO

-- Use the function in a SELECT
SELECT dbo.GetFullName('Pritika', 'Dey') AS FullName;
