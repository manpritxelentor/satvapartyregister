CREATE TABLE [dbo].[tbl_FinancialYear] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [TenantId]   NVARCHAR (512) NOT NULL,
    [IsActive]   BIT            CONSTRAINT [DF_tbl_FinancialYear_IsActive] DEFAULT ((1)) NOT NULL,
    [CreatedBy]  INT            NULL,
    [CreatedOn]  DATETIME       CONSTRAINT [DF_tbl_FinancialYear_CreatedOn] DEFAULT (getdate()) NULL,
    [ModifiedBy] INT            NULL,
    [ModifiedOn] DATETIME       NULL,
    [RowVersion] ROWVERSION     NOT NULL,
    [IsDeleted]  BIT            CONSTRAINT [DF_tbl_FinancialYear_IsDeleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tbl_FinancialYear] PRIMARY KEY CLUSTERED ([Id] ASC)
);

