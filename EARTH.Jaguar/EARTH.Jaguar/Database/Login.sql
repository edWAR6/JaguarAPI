USE [master]
GO
CREATE LOGIN [SGA_Mobile] WITH PASSWORD=N'pwdjaguar', DEFAULT_DATABASE=[SGA_Desarrollo], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [SGA_Desarrollo]
GO
CREATE USER [SGA_Mobile] FOR LOGIN [SGA_Mobile]
GO
USE [SGA_Desarrollo]
GO
EXEC sp_addrolemember N'db_datareader', N'SGA_Mobile'
GO


