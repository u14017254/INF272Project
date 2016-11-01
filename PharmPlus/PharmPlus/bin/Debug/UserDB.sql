USE Master
GO
DROP DATABASE Users
GO
CREATE DATABASE Users
GO
USE Users
GO

CREATE TABLE tbTitle 
(	
	TitleID int identity (1,1)  NOT NULL PRIMARY KEY,
	TitleDescription varchar(20),
)

INSERT INTO tbTitle VALUES('Mr')
INSERT INTO tbTitle VALUES('Mrs')
INSERT INTO tbTitle VALUES('Dr')

CREATE TABLE tbUserLogin
(
	UserID int identity (1,1) NOT NULL PRIMARY KEY,
	UserUsername varchar(40),
	UserPassword varchar(40)
)

INSERT INTO tbUserLogin VALUES ('Admin', 'Admin')

CREATE TABLE tbUser
(	
	UserID int references tbUserLogin(UserID),
	UserName	varchar(40),
	UserSurname varchar(40),
	UserTitle int references tbTitle(TitleID),
)

INSERT INTO tbUser VALUES(1, 'AdminName', 'AdminSurname', 1)
