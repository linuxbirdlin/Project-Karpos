CREATE TABLE [dbo].[Login] (
    [Guid]        UNIQUEIDENTIFIER CONSTRAINT [DF_Login_Guid] DEFAULT (newid()) NOT NULL,
    [ContactGuid] UNIQUEIDENTIFIER NOT NULL,
    [Username]    NVARCHAR (200)   NOT NULL,
    [Password]    NVARCHAR (200)   NOT NULL,
    CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED ([Guid] ASC),
    CONSTRAINT [FK_Login_Contact] FOREIGN KEY ([ContactGuid]) REFERENCES [dbo].[Contact] ([Guid]) ON DELETE CASCADE
);

