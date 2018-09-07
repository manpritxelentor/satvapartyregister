CREATE TABLE [dbo].[tbl_Country] (
    [Id]         INT            NOT NULL,
    [Code]       NVARCHAR (50)  NOT NULL,
    [Name]       VARCHAR (50)   NOT NULL,
    [TenantId]   NVARCHAR (128) NOT NULL,
    [ShortCode]  VARCHAR (10)   NULL,
    [CreatedOn]  DATETIME       CONSTRAINT [DF_tbl_Country_CreatedOn] DEFAULT (getdate()) NOT NULL,
    [CreatedBy]  INT            NULL,
    [ModifiedOn] DATETIME       NULL,
    [ModifiedBy] INT            NULL,
    [RowVersion] ROWVERSION     NULL,
    CONSTRAINT [PK_tbl_Country] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tbl_Country_tbl_Tenant] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[tbl_Tenant] ([TenantId])
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_Country]
    ON [dbo].[tbl_Country]([Name] ASC);

