CREATE TABLE [dbo].[tbl_AccountantAdvocate] (
    [Id]           INT            NOT NULL,
    [Name]         VARCHAR (100)  NOT NULL,
    [TenantId]     NVARCHAR (128) NOT NULL,
    [MobileNumber] VARCHAR (12)   NULL,
    [EmailAddress] VARCHAR (50)   NULL,
    [CreatedOn]    DATETIME       CONSTRAINT [DF_tbl_AccountantAdvocate_CreatedOn] DEFAULT (getdate()) NOT NULL,
    [CreatedBy]    INT            NULL,
    [ModifiedOn]   DATETIME       NULL,
    [ModifiedBy]   INT            NULL,
    [RowVersion]   ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tbl_AccountantAdvocate] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tbl_AccountantAdvocate_tbl_AccountantAdvocate] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[tbl_Company] ([TenantId])
);

