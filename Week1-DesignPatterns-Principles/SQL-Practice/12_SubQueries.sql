USE CognizantDB;
GO

-- Employees in DepartmentID = 1

SELECT *
FROM Employees
WHERE DepartmentID =
(
    SELECT DepartmentID
    FROM Departments
    WHERE DepartmentName = 'IT'
);


-- Employees not in IT department

SELECT *
FROM Employees
WHERE DepartmentID <>
(
    SELECT DepartmentID
    FROM Departments
    WHERE DepartmentName = 'IT'
);


-- Employees whose DepartmentID exists in Departments

SELECT *
FROM Employees
WHERE DepartmentID IN
(
    SELECT DepartmentID
    FROM Departments
);


-- Employees whose DepartmentID is not present

SELECT *
FROM Employees
WHERE DepartmentID NOT IN
(
    SELECT DepartmentID
    FROM Departments
);