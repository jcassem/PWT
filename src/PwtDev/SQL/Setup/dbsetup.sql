﻿CREATE TABLE [dbo].[Users]
(
	[UserID] INT NOT NULL PRIMARY KEY IDENTITY,
	[Username] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(100) NOT NULL,
	[Password] NVARCHAR(1000) NOT NULL,
)

CREATE TABLE [dbo].[Projects]
(
	[ProjectID] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	[Details] NVARCHAR(MAX) NOT NULL
)
