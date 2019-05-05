
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/21/2018 15:44:10
-- Generated from EDMX file: C:\Users\AMBIDI SRINIVAS\source\repos\PatientBillingSystem\PatientBillingSystem\Models\dbBedsAvailableModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbPatientBilling];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Beds_Available]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Beds_Available];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Beds_Available'
CREATE TABLE [dbo].[Beds_Available] (
    [service_No] int IDENTITY(1,1) NOT NULL,
    [ward] nvarchar(50)  NOT NULL,
    [bedNo] int  NOT NULL,
    [bed_Availability] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [service_No] in table 'Beds_Available'
ALTER TABLE [dbo].[Beds_Available]
ADD CONSTRAINT [PK_Beds_Available]
    PRIMARY KEY CLUSTERED ([service_No] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------