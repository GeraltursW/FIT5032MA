CREATE TABLE [dbo].[Clients](
[Id] int Identity (1,1) not null,
[FirstName] nvarchar (max) not null,
[LastName] nvarchar(max) not null,
 [UserId] nvarchar (max) not null
 PRIMARY KEY (Id)
);
Go

CREATE TABLE [dbo].[Funds](
	[Id] int IDENTITY (1,1) not null,
	[Name] nvarchar (max) not null,
	[Description] nvarchar(max) not null,
		[ClientId] int  not null
	PRIMARY KEY (Id),
	FOREIGN KEY (ClientId) REFERENCES Clients(Id)
);

Go