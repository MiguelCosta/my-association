-- 001

-- CREATE Migrations table
CREATE TABLE [dbo].[_DbMigrations](
  [Version] [varchar](50) NOT NULL,
  [Description] [varchar](150) NOT NULL,
  [Author] [varchar](150) NOT NULL,
  [MigrationDate] [datetime] NOT NULL,
  CONSTRAINT [PK_DbMigrations] PRIMARY KEY CLUSTERED
([Version] ASC)) ON [PRIMARY]
GO

DECLARE @version varchar(50) = '001';
DECLARE @description varchar(50) = 'Create Database';
DECLARE @author varchar(50) = 'Miguel Costa';

INSERT INTO [dbo].[_DbMigrations]([Version],[Description],[Author],[MigrationDate])
  VALUES (@version,@description,@author,GETDATE())
GO
