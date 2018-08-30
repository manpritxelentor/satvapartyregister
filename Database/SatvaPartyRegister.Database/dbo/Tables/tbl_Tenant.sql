CREATE TABLE [dbo].[tbl_Tenant] (
    [TenantId]   NVARCHAR (128) NOT NULL,
    [Name]       NVARCHAR (512) NOT NULL,
    [IsActive]   BIT            CONSTRAINT [DF_tbl_Company_IsActive] DEFAULT ((1)) NOT NULL,
    [CreatedBy]  INT            NULL,
    [CreatedOn]  DATETIME       CONSTRAINT [DF_tbl_Company_CreatedOn] DEFAULT (getdate()) NULL,
    [ModifiedBy] INT            NULL,
    [ModifiedOn] DATETIME       NULL,
    [RowVersion] ROWVERSION     NOT NULL,
    [IsDeleted]  BIT            CONSTRAINT [DF_tbl_Company_IsDeleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tbl_Company] PRIMARY KEY CLUSTERED ([TenantId] ASC)
);

