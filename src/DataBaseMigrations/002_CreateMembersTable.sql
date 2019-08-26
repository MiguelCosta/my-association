-------------------------------------------------------------------------------
DECLARE @version varchar(50) = '002';
DECLARE @description varchar(50) = 'Create Members Table';
DECLARE @author varchar(50) = 'Miguel Costa';

INSERT INTO [dbo].[_DbMigrations]([Version],[Description],[Author],[MigrationDate])
  VALUES (@version,@description,@author,GETDATE())
GO
-------------------------------------------------------------------------------

CREATE TABLE [dbo].[Members](
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Name] [nvarchar](255) NOT NULL,
  [Vat] [nvarchar](255) NOT NULL,
  [Email] [nvarchar](255) NOT NULL,
  [PhoneNumber] [nvarchar](255) NOT NULL,
  [AddressLine1] [nvarchar](255) NOT NULL,
  [AddressLine2] [nvarchar](255) NOT NULL,
  [PostalCode] [nvarchar](255) NOT NULL,
  [City] [nvarchar](255) NOT NULL,
  CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO
