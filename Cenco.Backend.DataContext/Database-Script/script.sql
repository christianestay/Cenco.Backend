USE [APP-CENCO]
GO
/****** Object:  Table [dbo].[app_tarea]    Script Date: 05-06-2023 22:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[app_tarea](
	[id_tarea] [bigint] IDENTITY(1,1) NOT NULL,
	[id_usuario] [bigint] NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_eliminacion] [datetime] NULL,
	[titulo] [varchar](20) NOT NULL,
	[descripcion] [varchar](1000) NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_app_tarea] PRIMARY KEY CLUSTERED 
(
	[id_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[app_usuario]    Script Date: 05-06-2023 22:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[app_usuario](
	[id_usuario] [bigint] IDENTITY(14,1) NOT NULL,
	[fecha_creacion] [datetime2](0) NOT NULL,
	[fecha_eliminacion] [datetime2](0) NULL,
	[id_perfil] [bigint] NOT NULL,
	[nombres] [nvarchar](30) NOT NULL,
	[apellidos] [nvarchar](30) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[activo] [int] NOT NULL,
 CONSTRAINT [PK_app_usuario_id_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[app_tarea] ON 

INSERT [dbo].[app_tarea] ([id_tarea], [id_usuario], [fecha_creacion], [fecha_eliminacion], [titulo], [descripcion], [estado]) VALUES (3, 1, CAST(N'2023-06-03T14:55:12.000' AS DateTime), NULL, N'Tarea de Eliminación', N'Tarea de Eliminaciónd de Archivos de proyecto web', 1)
INSERT [dbo].[app_tarea] ([id_tarea], [id_usuario], [fecha_creacion], [fecha_eliminacion], [titulo], [descripcion], [estado]) VALUES (4, 2, CAST(N'2023-06-03T17:32:11.000' AS DateTime), NULL, N'Armar BBDD', N'Tarea de creación de script de datos', 1)
INSERT [dbo].[app_tarea] ([id_tarea], [id_usuario], [fecha_creacion], [fecha_eliminacion], [titulo], [descripcion], [estado]) VALUES (5, 2, CAST(N'2023-06-04T09:12:03.000' AS DateTime), NULL, N'Configurar Web', N'Tarea de configuración web', 2)
SET IDENTITY_INSERT [dbo].[app_tarea] OFF
GO
SET IDENTITY_INSERT [dbo].[app_usuario] ON 

INSERT [dbo].[app_usuario] ([id_usuario], [fecha_creacion], [fecha_eliminacion], [id_perfil], [nombres], [apellidos], [email], [password], [activo]) VALUES (14, CAST(N'2023-06-03T11:33:21.0000000' AS DateTime2), NULL, 1, N'Javiera', N'Lepin', N'javiera.lepin@gmail..com', N'123456', 1)
INSERT [dbo].[app_usuario] ([id_usuario], [fecha_creacion], [fecha_eliminacion], [id_perfil], [nombres], [apellidos], [email], [password], [activo]) VALUES (15, CAST(N'2023-06-03T11:43:21.0000000' AS DateTime2), NULL, 1, N'Christian', N'Estay', N'cestay@atomix.cl', N'123456', 1)
SET IDENTITY_INSERT [dbo].[app_usuario] OFF
GO
