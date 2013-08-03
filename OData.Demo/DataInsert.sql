--	Insert 3 addresses corresponding to 3 employees in 2 departments

DECLARE @departmentID AS INT
DECLARE @addressID AS INT

INSERT INTO [demo].[Department]
([DepartmentName])
VALUES
('Heroes')
SELECT @departmentID=SCOPE_IDENTITY()

INSERT INTO [demo].[Address]
([StreetNumber], [StreetName])
VALUES
('1350', 'Boul. René-Lévesque Ouest')
SELECT @addressID=SCOPE_IDENTITY()

INSERT INTO [demo].[Employee]
([DepartmentID], [AddressID], [FirstName], [LastName])
VALUES
(@departmentID, @addressID, 'Luke', 'Skywalker')

INSERT INTO [demo].[Address]
([StreetNumber], [StreetName])
VALUES
('78123', 'Saint-Laurent')
SELECT @addressID=SCOPE_IDENTITY()

INSERT INTO [demo].[Employee]
([DepartmentID],[AddressID], [FirstName], [LastName])
VALUES
(@departmentID, @addressID, 'Jim', 'Kirk')

INSERT INTO [demo].[Address]
([StreetNumber], [StreetName])
VALUES
('2654', 'Saint-Denis')
SELECT @addressID=SCOPE_IDENTITY()

INSERT INTO [demo].[Department]
([DepartmentName])
VALUES
('Scientists')
SELECT @departmentID=SCOPE_IDENTITY()

INSERT INTO [demo].[Employee]
([DepartmentID],[AddressID], [FirstName], [LastName])
VALUES
(@departmentID, @addressID, 'Doctor', 'Who')

