USE [Nombre_de_tu_base_de_datos]
GO

/****** Object:  Table [dbo].[Empleados]    Script Date: 14/04/2021 0:35:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Empleados](
	[nombre] [ntext] NULL,
	[apellidos] [ntext] NULL,
	[sexo] [ntext] NULL,
	[sede] [ntext] NULL,
	[localidad] [ntext] NULL,
	[dni] [numeric](8, 0) NOT NULL,
	[disponibilidad] [ntext] NULL,
	[salarioesperado] [ntext] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


