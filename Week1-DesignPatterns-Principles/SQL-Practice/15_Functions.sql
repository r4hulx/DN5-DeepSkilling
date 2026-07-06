USE CognizantDB;
GO

-- Scalar Function

CREATE FUNCTION GetDepartmentName
(
    @DepartmentID INT
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @DepartmentName VARCHAR(50);

    SELECT @DepartmentName = DepartmentName
    FROM Departments
    WHERE DepartmentID = @DepartmentID;

    RETURN @DepartmentName;
END;
GO

-- Execute Scalar Function

SELECT
    EmployeeName,
    dbo.GetDepartmentName(DepartmentID) AS Department
FROM Employees;
GO


-- Table-Valued Function

CREATE FUNCTION GetEmployeesByDept
(
    @DepartmentID INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID
);
GO

-- Execute Table-Valued Function

SELECT *
FROM dbo.GetEmployeesByDept(1);
GO

SELECT *
FROM dbo.GetEmployeesByDept(2);
GO

SELECT *
FROM dbo.GetEmployeesByDept(3);
GO