CREATE TABLE [dbo].[Organization] (
    [Guid]             UNIQUEIDENTIFIER CONSTRAINT [DF_Organization_Guid] DEFAULT (newid()) NOT NULL,
    [OrginizationGuid] UNIQUEIDENTIFIER NULL,
    [Name]             NVARCHAR (500)   NOT NULL,
    CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED ([Guid] ASC),
    CONSTRAINT [FK_Organization_Organization] FOREIGN KEY ([OrginizationGuid]) REFERENCES [dbo].[Organization] ([Guid])
);

