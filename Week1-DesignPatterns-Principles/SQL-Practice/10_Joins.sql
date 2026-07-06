USE CognizantDB;
GO

DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;
GO

CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(50)
);

INSERT INTO Departments
VALUES
(1,'IT'),
(2,'HR'),
(3,'Finance');

CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    DepartmentID INT
);

INSERT INTO Employees
VALUES
(101,'Rahul',1),
(102,'Amit',2),
(103,'Priya',3),
(104,'Neha',1),
(105,'John',NULL);

SELECT
    E.EmployeeName,
    D.DepartmentName
FROM Employees E
INNER JOIN Departments D
ON E.DepartmentID = D.DepartmentID;

SELECT
    E.EmployeeName,
    D.DepartmentName
FROM Employees E
LEFT JOIN Departments D
ON E.DepartmentID = D.DepartmentID;

SELECT
    E.EmployeeName,
    D.DepartmentName
FROM Employees E
RIGHT JOIN Departments D
ON E.DepartmentID = D.DepartmentID;

SELECT
    E.EmployeeName,
    D.DepartmentName
FROM Employees E
FULL OUTER JOIN Departments D
ON E.DepartmentID = D.DepartmentID;