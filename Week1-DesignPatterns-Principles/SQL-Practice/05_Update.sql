USE CognizantDB;
GO

UPDATE Employees
SET Salary=60000
WHERE EmployeeID=1;

SELECT * FROM Employees;