--SQL FILE 1

--Ranking and window functions.
DROP TABLE IF EXISTS Sales;

CREATE TABLE Sales (
    ID INT,
    Employee VARCHAR(50),
    Department VARCHAR(10),
    Sales INT
);

INSERT INTO Sales (ID, Employee, Department, Sales) VALUES
(1, 'Pritika', 'A', 5000),
(2, 'Riti', 'A', 7000),
(3, 'Rinki', 'B', 4000),
(4, 'Priti', 'B', 4000),
(5, 'Pakhi', 'A', 7000);

SELECT 
    Employee,
    Department,
    Sales,
    
    ROW_NUMBER() OVER (PARTITION BY Department ORDER BY Sales DESC) AS RowNum,
    RANK()       OVER (PARTITION BY Department ORDER BY Sales DESC) AS RankNum,
    DENSE_RANK() OVER (PARTITION BY Department ORDER BY Sales DESC) AS DenseRankNum,
    NTILE(2)     OVER (PARTITION BY Department ORDER BY Sales DESC) AS Quartile,
    
    SUM(Sales)   OVER (PARTITION BY Department ORDER BY Sales) AS RunningTotal,
    LAG(Sales)   OVER (PARTITION BY Department ORDER BY Sales) AS PrevSales,
    LEAD(Sales)  OVER (PARTITION BY Department ORDER BY Sales) AS NextSales,
    FIRST_VALUE(Sales) OVER (PARTITION BY Department ORDER BY Sales) AS FirstSale,
    LAST_VALUE(Sales) OVER (
        PARTITION BY Department 
        ORDER BY Sales 
        ROWS BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING
    ) AS LastSale

FROM Sales
ORDER BY Department, Sales DESC;
