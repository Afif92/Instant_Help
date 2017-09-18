CREATE TABLE [dbo].[UserInfo] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (20) NULL,
    [UserName]     VARCHAR (20) NULL,
    [Password]     VARCHAR (20) NULL,
    [Email]        VARCHAR (20) NULL,
    [Phone]        VARCHAR (20) NULL,
    [Family_Phone] NCHAR (10)   NULL,
    [Gender]       VARCHAR (10) NULL,
    [UserType] NCHAR(12) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

