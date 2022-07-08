IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Employeer] (
    [EId] int NOT NULL IDENTITY,
    [EName] nvarchar(max) NULL,
    [EmployeeId] int NOT NULL,
    [EDesign] nvarchar(max) NULL,
    [EDoj] datetime2 NOT NULL,
    CONSTRAINT [PK_Employeer] PRIMARY KEY ([EId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220708095100_FirstMig', N'5.0.17');
GO

COMMIT;
GO

