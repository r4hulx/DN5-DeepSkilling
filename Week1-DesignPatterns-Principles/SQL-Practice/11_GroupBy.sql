USE CognizantDB;
GO

-- Number of employees in each department

SELECT
    DepartmentID,
    COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY DepartmentID;


-- Employee count greater than 1

SELECT
    DepartmentID,
    COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY DepartmentID
HAVING COUNT(*) > 1;