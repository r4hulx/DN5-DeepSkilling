USE CognizantDB;
GO

-- Create Stored Procedure

CREATE PROCEDURE GetEmployees
AS
BEGIN
    SELECT
        E.EmployeeID,
        E.EmployeeName,
        D.DepartmentName
    FROM Employees E
    INNER JOIN Departments D
    ON E.DepartmentID = D.DepartmentID;
END;
GO

-- Execute Stored Procedure

EXEC GetEmployees;
GO


-- Stored Procedure with Parameter

CREATE PROCEDURE GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

-- Execute

EXEC GetEmployeesByDepartment 1;
GO

EXEC GetEmployeesByDepartment 2;
GO

EXEC GetEmployeesByDepartment 3;
GO