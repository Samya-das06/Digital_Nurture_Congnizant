--SQL FILE 2

--Create a stored procedure
IF OBJECT_ID('dbo.Employees', 'U') IS NOT NULL
    DROP TABLE dbo.Employees;

CREATE TABLE Employees (
    ID INT,
    Name VARCHAR(100),
    Department VARCHAR(50),
    Salary INT
);

INSERT INTO Employees (ID, Name, Department, Salary) VALUES
(1, 'Pritika', 'HR', 75000),
(2, 'Riti', 'IT', 70000),
(3, 'Rinki', 'Finance', 60000),
(4, 'Priti', 'IT', 75000),
(5, 'Pakhi', 'HR', 52000);

IF OBJECT_ID('dbo.GetHighSalaryEmployees', 'P') IS NOT NULL
    DROP PROCEDURE dbo.GetHighSalaryEmployees;
GO

CREATE PROCEDURE dbo.GetHighSalaryEmployees
    @MinSalary INT
AS
BEGIN
    SELECT ID, Name, Department, Salary
    FROM Employees
    WHERE Salary > @MinSalary;
END;
GO

EXEC dbo.GetHighSalaryEmployees @MinSalary = 60000;
