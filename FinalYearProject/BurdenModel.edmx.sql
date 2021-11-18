
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/11/2021 17:48:58
-- Generated from EDMX file: C:\Users\Brent\source\repos\FinalYearProject\FinalYearProject\BurdenModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BurdenSuits];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserCivilSuit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CivilSuits] DROP CONSTRAINT [FK_UserCivilSuit];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[CivilSuits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CivilSuits];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Username] nvarchar(20)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CivilSuits'
CREATE TABLE [dbo].[CivilSuits] (
    [SuitId] int IDENTITY(1,1) NOT NULL,
    [UserUserId] int  NOT NULL,
    [SuitName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [WhichParty] nvarchar(max)  NOT NULL,
    [Progress] nvarchar(max)  NULL,
    [Category] nvarchar(max)  NOT NULL,
    [SubCategory] nvarchar(max)  NOT NULL,
    [Stage] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [SuitId] in table 'CivilSuits'
ALTER TABLE [dbo].[CivilSuits]
ADD CONSTRAINT [PK_CivilSuits]
    PRIMARY KEY CLUSTERED ([SuitId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserUserId] in table 'CivilSuits'
ALTER TABLE [dbo].[CivilSuits]
ADD CONSTRAINT [FK_UserCivilSuit]
    FOREIGN KEY ([UserUserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCivilSuit'
CREATE INDEX [IX_FK_UserCivilSuit]
ON [dbo].[CivilSuits]
    ([UserUserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------