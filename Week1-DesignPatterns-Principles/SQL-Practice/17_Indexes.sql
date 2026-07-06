USE CognizantDB;
GO

-- Create Index

CREATE INDEX IX_EmployeeName
ON Employees(EmployeeName);
GO

-- Verify

SELECT *
FROM sys.indexes
WHERE object_id = OBJECT_ID('Employees');
GO