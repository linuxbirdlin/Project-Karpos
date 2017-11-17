CREATE TABLE [dbo].[Contact] (
    [Guid]             UNIQUEIDENTIFIER CONSTRAINT [DF_Contact_Guid] DEFAULT (newid()) NOT NULL,
    [OrginizationGuid] UNIQUEIDENTIFIER NOT NULL,
    [Name]             NCHAR (10)       NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([Guid] ASC),
    CONSTRAINT [FK_Contact_Organization] FOREIGN KEY ([OrginizationGuid]) REFERENCES [dbo].[Organization] ([Guid]) ON DELETE CASCADE
);

