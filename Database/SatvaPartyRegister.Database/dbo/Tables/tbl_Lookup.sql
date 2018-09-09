CREATE TABLE [dbo].[tbl_Lookup] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [LookupGroup] VARCHAR (30)   NOT NULL,
    [LookupName]  VARCHAR (40)   NOT NULL,
    [LookupCode]  VARCHAR (30)   NOT NULL,
    [LookupValue] VARCHAR (50)   NOT NULL,
    [TenantId]    NVARCHAR (128) NOT NULL,
    [CreatedOn]   DATETIME       CONSTRAINT [DF_tbl_Lookup_CreatedOn] DEFAULT (getdate()) NOT NULL,
    [CreatedBy]   INT            NULL,
    [ModifiedOn]  DATETIME       NULL,
    [ModifiedBy]  INT            NULL,
    [RowVersion]  ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tbl_Lookup] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tbl_Lookup_tbl_Lookup] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[tbl_Tenant] ([TenantId])
);

