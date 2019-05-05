
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/21/2018 15:43:20
-- Generated from EDMX file: C:\Users\AMBIDI SRINIVAS\source\repos\PatientBillingSystem\PatientBillingSystem\Models\dbBedAllotmentModel.edmx
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

IF OBJECT_ID(N'[dbo].[Bed_Allocation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bed_Allocation];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bed_Allocation'
CREATE TABLE [dbo].[Bed_Allocation] (
    [Allocation_No] int  NOT NULL,
    [Patient_ID] int  NULL,
    [Patient_Name] nvarchar(50)  NULL,
    [Ward_Aolloted] nvarchar(50)  NULL,
    [Bed_Aolloted] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Allocation_No] in table 'Bed_Allocation'
ALTER TABLE [dbo].[Bed_Allocation]
ADD CONSTRAINT [PK_Bed_Allocation]
    PRIMARY KEY CLUSTERED ([Allocation_No] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------