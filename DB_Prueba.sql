USE [DB_Prueba]
GO
/****** Object:  Table [dbo].[tb_login]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idRoles] [int] NULL,
	[idUsuario] [int] NULL,
	[logueo] [varchar](50) NOT NULL,
	[contrasena] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_roles]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_usuario]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidopaterno] [varchar](50) NOT NULL,
	[apellidomaterno] [varchar](50) NOT NULL,
	[correo] [varchar](50) NULL,
	[telefono] [int] NULL,
	[celular] [int] NULL,
	[comentarios] [varchar](200) NULL,
 CONSTRAINT [PK_tb_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_login] ON 

INSERT [dbo].[tb_login] ([id], [idRoles], [idUsuario], [logueo], [contrasena]) VALUES (1, 1, 1, N'admin', N'admin')
INSERT [dbo].[tb_login] ([id], [idRoles], [idUsuario], [logueo], [contrasena]) VALUES (2, 2, NULL, N'bibliotecario', N'12345')
INSERT [dbo].[tb_login] ([id], [idRoles], [idUsuario], [logueo], [contrasena]) VALUES (3, 3, NULL, N'estudiante', N'estudiante')
SET IDENTITY_INSERT [dbo].[tb_login] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_roles] ON 

INSERT [dbo].[tb_roles] ([id], [rol]) VALUES (1, N'administrador')
INSERT [dbo].[tb_roles] ([id], [rol]) VALUES (2, N'bibliotecario')
INSERT [dbo].[tb_roles] ([id], [rol]) VALUES (3, N'estudiante')
SET IDENTITY_INSERT [dbo].[tb_roles] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_usuario] ON 

INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (1, N'111111', N'11111', N'Prueba3', N'pruebita123@pruebita.com', 12345, 12345, N'Este es un comentarios111')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (2, N'hola2', N'hola2', N'Prueba', N'', 33234234, 12423424, N'Prueba de Insertar Usuario')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (3, N'hola3', N'hola3', N'Prueba2', N'pruebita@pruebita.com', 2342354, 34534645, N'Comentario Pruebita')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (4, N'hola4', N'hola4', N'Prueba3', N'prueba3@prueba3.com', 12413432, 564545, N'Mensaje de Prueba 3')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (5, N'Prueba4', N'Prueba4', N'Prueba4', N'Prueba4@Prueba4.com', 43252435, 6547234, N'Prueba4Prueba4Prueba4Prueba4Prueba4')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (6, N'Prueba5', N'Prueba5', N'Prueba5', N'prueba5@prueba.com', 324324, 234234, N'Prueba5')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (7, N'Prueba6', N'Prueba6', N'Prueba6', N'Prueba6@Prueba6.com', 45345345, 167567, N'Prueba6Prueba6Prueba6Prueba6')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (8, N'Prueba7', N'Prueba7', N'Prueba7', N'Prueba7@Prueba7.com', 2524534, 578768768, N'Prueba7Prueba7Prueba7')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (9, N'JAJAJA', N'JAJAJA', N'JAJAJA', N'', 222222, 22222, N'')
SET IDENTITY_INSERT [dbo].[tb_usuario] OFF
GO
ALTER TABLE [dbo].[tb_login]  WITH CHECK ADD  CONSTRAINT [FK_tb_login_tb_roles] FOREIGN KEY([idRoles])
REFERENCES [dbo].[tb_roles] ([id])
GO
ALTER TABLE [dbo].[tb_login] CHECK CONSTRAINT [FK_tb_login_tb_roles]
GO
ALTER TABLE [dbo].[tb_login]  WITH CHECK ADD  CONSTRAINT [FK_tb_login_tb_usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[tb_usuario] ([id])
GO
ALTER TABLE [dbo].[tb_login] CHECK CONSTRAINT [FK_tb_login_tb_usuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarLogin]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ActualizarLogin]
	@id int,
	@idRoles int,
	@idUsuario int,
	@logueo varchar(50),
	@contrasena varchar(50)
as
begin
update tb_login set idRoles=@idRoles,idUsuario=@idUsuario,logueo=@logueo, contrasena=@contrasena
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarRoles]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ActualizarRoles]
	@id int,
	@rol varchar(50)
as
begin
update tb_roles set rol=@rol
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUsuario]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_ActualizarUsuario]
	@id int,
	@nombre varchar(50),
	@apellidopaterno varchar(50),
	@apellidomaterno varchar(50),
	@correo varchar(50),
	@telefono int,
	@celular int,
	@comentarios varchar(200)
as
begin
update tb_usuario set nombre=@nombre,apellidopaterno=@apellidomaterno,@apellidomaterno=@apellidomaterno,correo=@correo,telefono=@telefono,celular=@celular,comentarios=@comentarios
where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultaLogin]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ConsultaLogin]
@logueo varchar(50),
@contrasena varchar(50)
as
SELECT tb_login.logueo, tb_login.contrasena, tb_roles.rol
FROM     tb_login INNER JOIN
                  tb_roles ON tb_login.idRoles = tb_roles.id
				  where logueo=@logueo and contrasena=@contrasena
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarLogin]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EliminarLogin]
	@id INT
AS 
delete from tb_login where id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarRoles]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EliminarRoles]
	@id INT
AS 
delete from tb_roles where id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_filtrarCelular]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_filtrarCelular]
@filtro varchar (200)
as
SELECT nombre + ' ' + apellidopaterno + ' ' + apellidomaterno AS [Nombre_Completo],telefono AS Telefono, celular AS Celular, correo AS Correo, 
                  comentarios AS Comentarios
FROM     tb_usuario
where celular like @filtro + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_filtrarComentarios]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_filtrarComentarios]
@filtro varchar (200)
as
SELECT nombre + ' ' + apellidopaterno + ' ' + apellidomaterno AS [Nombre_Completo],telefono AS Telefono, celular AS Celular, correo AS Correo, 
                  comentarios AS Comentarios
FROM     tb_usuario
where comentarios like @filtro + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_filtrarCorreo]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_filtrarCorreo]
@filtro varchar (200)
as
SELECT nombre + ' ' + apellidopaterno + ' ' + apellidomaterno AS [Nombre_Completo],telefono AS Telefono, celular AS Celular, correo AS Correo, 
                  comentarios AS Comentarios
FROM     tb_usuario
where correo like @filtro + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_filtrarNombre]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_filtrarNombre]
@filtro varchar (200)
as
SELECT nombre + ' ' + apellidopaterno + ' ' + apellidomaterno AS [Nombre_Completo],telefono AS Telefono, celular AS Celular, correo AS Correo, 
                  comentarios AS Comentarios
FROM     tb_usuario
where nombre like @filtro + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_filtrarTelefono]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_filtrarTelefono]
@filtro varchar (200)
as
SELECT nombre + ' ' + apellidopaterno + ' ' + apellidomaterno AS [Nombre_Completo],telefono AS Telefono, celular AS Celular, correo AS Correo, 
                  comentarios AS Comentarios
FROM     tb_usuario
where Telefono like @filtro + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarLogin]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertarLogin]
	@idRol int,
	@idUsuario int,
	@login varchar(50),
	@contrasena varchar(50)
as
begin
insert into tb_login values
	(@idRol,@idUsuario,@login,@contrasena)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarRoles]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertarRoles]
	@rol varchar(50)
as
begin
insert into tb_roles values
	(@rol)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarUsuario]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertarUsuario]
	@nombre varchar(50),
	@apellidopaterno varchar(50),
	@apellidomaterno varchar(50),
	@correo varchar(50),
	@telefono int,
	@celular int,
	@comentarios varchar (200)
as
begin
insert into tb_usuario values
	(@nombre,@apellidopaterno,@apellidomaterno,@correo,@telefono,@celular,@comentarios)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarUsuario]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ListarUsuario]
as
SELECT id AS Id, nombre + ' ' + apellidopaterno + ' ' + apellidomaterno AS [Nombre_Completo], nombre AS Nombre, apellidopaterno AS [Apellido Paterno], apellidomaterno AS [Apellido Materno], telefono AS Telefono, celular AS Celular, correo AS Correo, 
                  comentarios AS Comentarios
FROM     tb_usuario
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 23/07/2021 23:39:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_login]
@logueo varchar(50),
@contrasena varchar(50)
as
SELECT tb_login.logueo, tb_login.contrasena, tb_roles.rol
FROM     tb_login INNER JOIN
                  tb_roles ON tb_login.idRoles = tb_roles.id
				  where logueo=@logueo and contrasena=@contrasena
GO
