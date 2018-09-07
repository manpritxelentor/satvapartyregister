CREATE TABLE [dbo].[tbl_ITRegister] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId]       INT            NOT NULL,
    [TenantId]         NVARCHAR (128) NOT NULL,
    [FinYearId]        INT            NOT NULL,
    [ITReturnStatusId] INT            NOT NULL,
    [ITReturnStatusBy] INT            NULL,
    [AuditStatusId]    INT            NOT NULL,
    [AuditStatusBy]    INT            NULL,
    [CreatedOn]        DATETIME       CONSTRAINT [DF_tbl_ITRegister_CreatedOn] DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        INT            NULL,
    [ModifiedOn]       DATETIME       NULL,
    [ModifiedBy]       INT            NULL,
    [RowVersion]       ROWVERSION     NOT NULL,
    CONSTRAINT [PK_tbl_ITRegister] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tbl_ITRegister_tbl_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tbl_Customers] ([Id]),
    CONSTRAINT [FK_tbl_ITRegister_tbl_FinancialYear] FOREIGN KEY ([FinYearId]) REFERENCES [dbo].[tbl_FinancialYear] ([Id]),
    CONSTRAINT [FK_tbl_ITRegister_tbl_ITRegister] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[tbl_Tenant] ([TenantId]),
    CONSTRAINT [FK_tbl_ITRegister_tbl_Lookup] FOREIGN KEY ([ITReturnStatusId]) REFERENCES [dbo].[tbl_Lookup] ([Id]),
    CONSTRAINT [FK_tbl_ITRegister_tbl_Lookup1] FOREIGN KEY ([AuditStatusId]) REFERENCES [dbo].[tbl_Lookup] ([Id])
);

