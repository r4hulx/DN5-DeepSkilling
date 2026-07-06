USE CognizantDB;
GO

-- Audit Table

CREATE TABLE EmployeeAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT,
    EmployeeName VARCHAR(100),
    ActionPerformed VARCHAR(20),
    ActionDate DATETIME
);
GO

-- Trigger

CREATE TRIGGER trg_AfterInsertEmployee
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeAudit
    (
        EmployeeID,
        EmployeeName,
        ActionPerformed,
        ActionDate
    )
    SELECT
        EmployeeID,
        EmployeeName,
        'INSERT',
        GETDATE()
    FROM inserted;
END;
GO

-- Test Trigger

INSERT INTO Employees
VALUES
(106,'David',2);
GO

-- Verify

SELECT *
FROM EmployeeAudit;
GO