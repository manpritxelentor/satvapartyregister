/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
GO
INSERT [dbo].[tbl_Tenant] ([TenantId], [Name], [IsActive], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [IsDeleted]) VALUES (N'1', N'Test', 1, NULL, CAST(N'2018-09-08 23:48:14.500' AS DateTime), NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[tbl_Country] OFF 

GO
INSERT [dbo].[tbl_Country] ([Id], [Code], [Name], [TenantId], [ShortCode], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (1, N'IN', N'India', N'1', N'IN', CAST(N'2018-09-09 02:16:52.300' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_Country] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_State] OFF 

GO
INSERT [dbo].[tbl_State] ([Id], [Code], [CountryId], [StateName], [TenantId], [ShortCode], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (1, N'GJ', 1, N'Gujarat', N'1', N'GJ', CAST(N'2018-09-09 02:21:16.193' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_State] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Lookup] OFF 

GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (1, N'CustomerTypes', N'Regular', N'CUSTTYPE_MON', N'Regular', N'1', CAST(N'2018-09-09 02:11:59.890' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (2, N'CustomerTypes', N'Composition', N'CUSTTYPE_COMP', N'Composition', N'1', CAST(N'2018-09-09 02:12:22.800' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (3, N'ReturnInterval', N'Monthly', N'RETINT_MONTH', N'7', N'1', CAST(N'2018-09-09 02:13:50.587' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (4, N'ReturnInterval', N'Quarterly', N'RETINT_QUART', N'6', N'1', CAST(N'2018-09-09 02:14:19.477' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (5, N'ITReturnStatus', N'Pending', N'ITRSTATUS_PEN', N'Pending', N'1', CAST(N'2018-09-09 02:32:47.943' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (6, N'ITReturnStatus', N'Filed', N'ITRSTATUS_Filed', N'Filed', N'1', CAST(N'2018-09-09 02:35:06.827' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (7, N'AuditStatus', N'Pending', N'AUDSTATUS_PEN', N'Pending', N'1', CAST(N'2018-09-09 02:36:04.857' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_Lookup] ([Id], [LookupGroup], [LookupName], [LookupCode], [LookupValue], [TenantId], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (8, N'AuditStatus', N'Filed', N'AUDSTATUS_FILED', N'Filed', N'1', CAST(N'2018-09-09 02:36:44.867' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_Lookup] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_FinancialYear] OFF 

GO
INSERT [dbo].[tbl_FinancialYear] ([Id], [Name], [TenantId], [IsActive], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [IsDeleted]) VALUES (1, N'2017-18', N'test', 1, NULL, CAST(N'2018-08-29 01:00:19.110' AS DateTime), NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[tbl_FinancialYear] OFF
GO
