USE CognizantDB;
GO

-- Create a View

CREATE VIEW EmployeeView AS
SELECT
    E.EmployeeID,
    E.EmployeeName,
    D.DepartmentName
FROM Employees E
INNER JOIN Departments D
ON E.DepartmentID = D.DepartmentID;
GO

-- Display the View

SELECT * FROM EmployeeView;
GO

-- Filter the View

SELECT *
FROM EmployeeView
WHERE DepartmentName = 'IT';
GO