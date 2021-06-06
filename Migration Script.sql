IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [HoneyDoItems] (
    [Id] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NULL,
    [AssignedTo] nvarchar(max) NULL,
    [Priority] nvarchar(max) NULL,
    [Category] nvarchar(max) NULL,
    [DueDate] datetime2 NOT NULL,
    [Recurrence] nvarchar(max) NULL,
    [Completed] bit NOT NULL,
    CONSTRAINT [PK_HoneyDoItems] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200305181929_HoneyDoService.Models.HoneyDoItemContext', N'3.1.2');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AssignedTo', N'Category', N'Completed', N'Description', N'DueDate', N'Priority', N'Recurrence') AND [object_id] = OBJECT_ID(N'[HoneyDoItems]'))
    SET IDENTITY_INSERT [HoneyDoItems] ON;
INSERT INTO [HoneyDoItems] ([Id], [AssignedTo], [Category], [Completed], [Description], [DueDate], [Priority], [Recurrence])
VALUES (1, N'Me', N'Home indoors', CAST(0 AS bit), N'Clean litter box', '2020-03-03T00:00:00.0000000-08:00', N'High', N'Monthly');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AssignedTo', N'Category', N'Completed', N'Description', N'DueDate', N'Priority', N'Recurrence') AND [object_id] = OBJECT_ID(N'[HoneyDoItems]'))
    SET IDENTITY_INSERT [HoneyDoItems] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AssignedTo', N'Category', N'Completed', N'Description', N'DueDate', N'Priority', N'Recurrence') AND [object_id] = OBJECT_ID(N'[HoneyDoItems]'))
    SET IDENTITY_INSERT [HoneyDoItems] ON;
INSERT INTO [HoneyDoItems] ([Id], [AssignedTo], [Category], [Completed], [Description], [DueDate], [Priority], [Recurrence])
VALUES (2, N'Us', N'Errand', CAST(0 AS bit), N'Grocery Shoop', '2020-03-07T00:00:00.0000000-08:00', N'High', N'Weekly');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AssignedTo', N'Category', N'Completed', N'Description', N'DueDate', N'Priority', N'Recurrence') AND [object_id] = OBJECT_ID(N'[HoneyDoItems]'))
    SET IDENTITY_INSERT [HoneyDoItems] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200305182528_HoneyDoService.Models.HoneyDoItemContextSeed', N'3.1.2');

GO

