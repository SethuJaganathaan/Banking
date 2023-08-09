CREATE TABLE KYC
(
KycId UNIQUEIDENTIFIER PRIMARY KEY,
ProofType NVARCHAR(50)
)
SELECT * FROM KYC
INSERT INTO KYC VALUES(NEWID(),'Driver Licence'),(NEWID(),'Pancard'),(NEWID(),'aadharcard'),(NEWID(),'passport'),(NEWID(),'Voter Registration card')

SELECT * FROM KYC

CREATE TABLE SecurityQuestion
(
QuestionId UNIQUEIDENTIFIER PRIMARY KEY,
Question VARCHAR(30)
)

ALTER TABLE SecurityQuestion
ALTER COLUMN Question NVARCHAR(MAX);

SELECT * FROM SecurityQuestion
INSERT INTO SecurityQuestion VALUES(NEWID(),'In which city were you born'),(NEWID(),'Who is your favorite singer'),(NEWID(),'What is name of your favorite pet'),(NEWID(),'What high school did you attend'),(NEWID(),'Name of your favorite food')

CREATE TABLE PersonalDetails
(
UserId UNIQUEIDENTIFIER PRIMARY KEY,
Name VARCHAR(30),
Email VARCHAR(20),
Mobilenumber BIGINT,
Pancard VARCHAR(10),
Aadharcard VARCHAR(12),
DOB DATE,
Address NVARCHAR(MAX)
)

SELECT * FROM PersonalDetails
INSERT INTO PersonalDetails(UserId,Name,Email,Mobilenumber,Pancard,Aadharcard,DOB,Address) VALUES (NEWID(),'Luffy','luffy@gmail.com',8734526738,'ABCD1234D',324262527356,'2000/04/05','25 EastBlue')

CREATE TABLE UserKYCDetails
(
UserKYCId UNIQUEIDENTIFIER PRIMARY KEY,
UserId UNIQUEIDENTIFIER FOREIGN KEY(UserId) REFERENCES PersonalDetails(UserId),
KycId UNIQUEIDENTIFIER FOREIGN KEY(KycId) REFERENCES KYC(KycId),
Filedata VARBINARY(MAX),
Filename NVARCHAR(MAX)
)
SELECT *FROM UserKYCDetails
DROP TABLE UserKYCDetails
DELETE FROM UserKYCDetails WHERE UserKYCId= '00000000-0000-0000-0000-000000000000';


CREATE TABLE UserSecurityQuestion
(
UserQuestionId UNIQUEIDENTIFIER PRIMARY KEY,
UserId UNIQUEIDENTIFIER FOREIGN KEY(UserId) REFERENCES PersonalDetails(UserId),
QuestionId UNIQUEIDENTIFIER FOREIGN KEY(QuestionId) REFERENCES SecurityQuestion(QuestionId),
Answer NVARCHAR(MAX)
)

SELECT * FROM UserSecurityQuestion WHERE  
DELETE FROM UserSecurityQuestion WHERE UserQuestionId= 'B5C74727-9A6C-40D7-9107-4FE10839024B';

