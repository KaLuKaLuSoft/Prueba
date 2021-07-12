USE [DB_Prueba]
GO
/****** Object:  Table [dbo].[tb_login]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  Table [dbo].[tb_roles]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  Table [dbo].[tb_usuario]    Script Date: 12/07/2021 3:42:38 ******/
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

INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (1, N'diego', N'choque', N'rodriguez', N'prueba@prueba.com', 231243234, 654645654, N'administrador del sistema')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (2, N'Prueba', N'Prueba', N'Prueba', NULL, 33234234, 12423424, N'Prueba de Insertar Usuario')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (3, N'pruebita', N'pruebita', N'Prueba2', N'pruebita@pruebita.com', 2342354, 34534645, N'Comentario Pruebita')
INSERT [dbo].[tb_usuario] ([id], [nombre], [apellidopaterno], [apellidomaterno], [correo], [telefono], [celular], [comentarios]) VALUES (4, N'Prueba3', N'Prueba3', N'Prueba3', N'prueba3@prueba3.com', 12413432, 564545, N'Mensaje de Prueba 3')
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
/****** Object:  StoredProcedure [dbo].[sp_ActualizarLogin]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ActualizarRoles]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUsuario]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ConsultaLogin]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_EliminarLogin]    Script Date: 12/07/2021 3:42:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EliminarLogin]
	@id INT
AS 
delete from tb_login where id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarRoles]    Script Date: 12/07/2021 3:42:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EliminarRoles]
	@id INT
AS 
delete from tb_roles where id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarLogin]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_InsertarRoles]    Script Date: 12/07/2021 3:42:38 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_InsertarUsuario]    Script Date: 12/07/2021 3:42:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertarUsuario]
	@nombre varchar(50),
	@apellidopaterno varchar(50),
	@apellidomaterno varchar(50),
	@correo varchar(50),
	@telefono int,
	@celular int,
	@comentario varchar (200)
as
begin
insert into tb_usuario values
	(@nombre,@apellidopaterno,@apellidomaterno,@correo,@telefono,@celular,@comentario)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 12/07/2021 3:42:38 ******/
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
