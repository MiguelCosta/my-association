-------------------------------------------------------------------------------
DECLARE @version varchar(50) = '003';
DECLARE @description varchar(50) = 'Create Quotas Table';
DECLARE @author varchar(50) = 'Miguel Costa';

INSERT INTO [dbo].[_DbMigrations]([Version],[Description],[Author],[MigrationDate])
  VALUES (@version,@description,@author,GETDATE())
GO
-------------------------------------------------------------------------------

CREATE TABLE [dbo].[Quotas](
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Name] [nvarchar](255) NOT NULL,
  [Value] [decimal](10,2) NOT NULL,
  [StartDate] [datetime] NOT NULL,
  [EndDate] [datetime] NOT NULL
  CONSTRAINT [PK_Quotas] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO
