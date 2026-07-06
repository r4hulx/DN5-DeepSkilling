USE CognizantDB;
GO

-- View existing data
SELECT * FROM Students;

-- Test PRIMARY KEY
INSERT INTO Students
VALUES
(1,'Neha',20,'neha@gmail.com');

-- Test UNIQUE
INSERT INTO Students
VALUES
(3,'Neha',20,'rahul@gmail.com');

-- Test CHECK
INSERT INTO Students
VALUES
(3,'Neha',15,'neha@gmail.com');

-- Valid Insert
INSERT INTO Students
VALUES
(3,'Neha',20,'neha@gmail.com');

-- Verify
SELECT * FROM Students;