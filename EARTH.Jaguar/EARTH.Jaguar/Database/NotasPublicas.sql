USE [SGA_Desarrollo]
GO

/****** Object:  Table [dbo].[P_NotasPublicas]    Script Date: 01/22/2013 09:03:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[P_NotasPublicas](
	[idNotasPublicas] [int] NOT NULL,
	[FechaNota] [datetime] NOT NULL,
	[Nota] [nvarchar](max) NOT NULL,
	[FechaRecordatorio] [datetime] NULL,
	[Activa] [bit] NOT NULL
) ON [PRIMARY]

GO


