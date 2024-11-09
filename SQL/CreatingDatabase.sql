CREATE DATABASE PRG282_Project;
GO

USE PRG282_Project;
GO
CREATE TABLE Modules (
	ModuleCode varchar(6) Primary Key,
	ModuleName varchar(MAX),
	ModuleDescription varchar(MAX),
	ModuleLink varchar(MAX)
);

CREATE TABLE Genders (
    GenderID tinyint PRIMARY KEY,
    GenderName varchar(10)
);

CREATE TABLE Students (
    StudentNum varchar(50),
    StudentName varchar(50),
    StudentSurname varchar(25),
    StudentDOB date,
    GenderID tinyint,  -- Foreign key referencing Gender table
    PhoneNum varchar(15),
    HomeAddress varchar(50),
    PRIMARY KEY (StudentNum),
    FOREIGN KEY (GenderID) REFERENCES Genders (GenderID)
);

CREATE TABLE StudentModules (
	StudentNum varchar(50),
    ModuleCode varchar(6),
    PRIMARY KEY (StudentNum, ModuleCode),
    FOREIGN KEY (StudentNum) REFERENCES Students (StudentNum),
    FOREIGN KEY (ModuleCode) REFERENCES Modules (ModuleCode)
);

GO

-- Insert gender values
INSERT INTO Genders (GenderID, GenderName) VALUES (1, 'Male');
INSERT INTO Genders (GenderID, GenderName) VALUES (2, 'Female');

--Inserting Test values
/*INSERT INTO Modules (ModuleCode, ModuleName, ModuleDescription) 
VALUES ('BUC161', 'Business Communication 161', 'Communication in Business');
INSERT INTO Students (StudentNum, StudentName, StudentSurname, StudentDOB, GenderID, PhoneNum, HomeAddress)
VALUES ('577118', 'Jan', 'Mentz', CONVERT(DATE, '2002-12-28'), 1, '0769616131', '35 Spekboom Avenue');
INSERT INTO StudentModules (StudentNum, ModuleCode)
VALUES ('577118', 'BUC161');*/

INSERT INTO Modules (ModuleCode, ModuleName, ModuleDescription, ModuleLink)
VALUES 
('M001', 'Module 1', 'Description 1', 'Link 1'),
('M002', 'Module 2', 'Description 2', 'Link 2'),
('M003', 'Module 3', 'Description 3', 'Link 3'),
('M004', 'Module 4', 'Description 4', 'Link 4'),
('M005', 'Module 5', 'Description 5', 'Link 5'),
('M006', 'Module 6', 'Description 6', 'Link 6'),
('M007', 'Module 7', 'Description 7', 'Link 7'),
('M008', 'Module 8', 'Description 8', 'Link 8'),
('M009', 'Module 9', 'Description 9', 'Link 9'),
('M010', 'Module 10', 'Description 10', 'Link 10');

-- Sample data for Students table
INSERT INTO Students (StudentNum, StudentName, StudentSurname, StudentDOB, GenderID, PhoneNum, HomeAddress)
VALUES
('S001', 'John', 'Doe', '1990-01-01', 1, '123-456-7890', 'Address 1'),
('S002', 'Jane', 'Doe', '1995-02-15', 2, '987-654-3210', 'Address 2'),
('S003', 'Bob', 'Smith', '1988-07-20', 1, '555-123-4567', 'Address 3'),
('S004', 'Alice', 'Johnson', '1992-04-12', 2, '777-888-9999', 'Address 4'),
('S005', 'Chris', 'Brown', '1993-08-05', 1, '111-222-3333', 'Address 5'),
('S006', 'Eva', 'Martinez', '1996-11-30', 2, '444-555-6666', 'Address 6'),
('S007', 'Michael', 'Clark', '1991-03-18', 1, '999-000-1111', 'Address 7'),
('S008', 'Olivia', 'White', '1994-06-25', 2, '222-333-4444', 'Address 8'),
('S009', 'Daniel', 'Lee', '1989-09-10', 1, '666-777-8888', 'Address 9'),
('S010', 'Sophia', 'Anderson', '1997-12-03', 2, '333-444-5555', 'Address 10');

-- Sample data for StudentModules table
INSERT INTO StudentModules (StudentNum, ModuleCode)
VALUES
('S001', 'M001'),
('S002', 'M002'),
('S003', 'M003'),
('S004', 'M004'),
('S005', 'M005'),
('S006', 'M006'),
('S007', 'M007'),
('S008', 'M008'),
('S009', 'M009'),
('S010', 'M010');