CREATE TABLE [dbo].[tbl_State] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Code]       NVARCHAR (50)  NOT NULL,
    [CountryId]  INT            NOT NULL,
    [StateName]  VARCHAR (50)   NOT NULL,
    [TenantId]   NVARCHAR (128) NOT NULL,
    [ShortCode]  VARCHAR (10)   NULL,
    [CreatedOn]  DATETIME       CONSTRAINT [DF_tbl_State_CreatedOn] DEFAULT (getdate()) NOT NULL,
    [CreatedBy]  INT            NULL,
    [ModifiedOn] DATETIME       NULL,
    [ModifiedBy] INT            NULL,
    [RowVersion] ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tbl_State] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tbl_State_tbl_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[tbl_Country] ([Id]),
    CONSTRAINT [FK_tbl_State_tbl_Tenant] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[tbl_Tenant] ([TenantId])
);






GO



GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_State]
    ON [dbo].[tbl_State]([StateName] ASC);

