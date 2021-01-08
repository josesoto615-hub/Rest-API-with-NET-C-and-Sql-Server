# Rest-API-with-NET-C-and-Sql-Server
Rest API with .NET, C# and Sql Server
This sample show as built a application .NET including the funtions get, post, put and delete.
This REST API is designed to be complemented with a front end application.
It is connected to a Sql Server Database handling Vehiculs information.

You just have to change the following attributes of the "ConnectionStrings" in the file "appsetting.json" of the project, according to SQL Server's configuration and then copy and paste the script to create "vehiculos" table.

Attibutes: data source (Server), initial catalog (Database), user id, password.

Script: 
CREATE TABLE [dbo].[vehiculos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dominio] [varchar](16) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[anio] [int] NOT NULL,
	[color] [varchar](50) NULL
) ON [PRIMARY]
GO
