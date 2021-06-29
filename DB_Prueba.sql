USE [DB_Prueba]
GO
/****** Object:  Table [dbo].[tb_login]    Script Date: 28/06/2021 23:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[logueo] [varchar](50) NOT NULL,
	[contrasena] [varchar](50) NOT NULL,
	[idRoles] [int] NULL,
 CONSTRAINT [PK_tb_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_roles]    Script Date: 28/06/2021 23:10:03 ******/
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
SET IDENTITY_INSERT [dbo].[tb_login] ON 

INSERT [dbo].[tb_login] ([id], [logueo], [contrasena], [idRoles]) VALUES (1, N'admin', N'admin', 1)
INSERT [dbo].[tb_login] ([id], [logueo], [contrasena], [idRoles]) VALUES (2, N'bibliotecario', N'12345', 2)
SET IDENTITY_INSERT [dbo].[tb_login] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_roles] ON 

INSERT [dbo].[tb_roles] ([id], [rol]) VALUES (1, N'administrador')
INSERT [dbo].[tb_roles] ([id], [rol]) VALUES (2, N'bibliotecario')
INSERT [dbo].[tb_roles] ([id], [rol]) VALUES (3, N'estudiante')
SET IDENTITY_INSERT [dbo].[tb_roles] OFF
GO
ALTER TABLE [dbo].[tb_login]  WITH CHECK ADD  CONSTRAINT [FK_tb_login_tb_roles] FOREIGN KEY([idRoles])
REFERENCES [dbo].[tb_roles] ([id])
GO
ALTER TABLE [dbo].[tb_login] CHECK CONSTRAINT [FK_tb_login_tb_roles]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarLogin]    Script Date: 28/06/2021 23:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ActualizarLogin]
	@id int,
	@logueo varchar(50),
	@contrasena varchar(50),
	@idRol int
as
begin
update tb_login set logueo=@logueo, contrasena=@contrasena, idRol=@idRol
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarRoles]    Script Date: 28/06/2021 23:10:03 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ConsultaLogin]    Script Date: 28/06/2021 23:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ConsultaLogin]
@logueo varchar(50),
@contrasena varchar(50)
as
select * from tb_login where logueo=@logueo and contrasena=@contrasena
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarLogin]    Script Date: 28/06/2021 23:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EliminarLogin]
	@id INT
AS 
delete from tb_login where id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarRoles]    Script Date: 28/06/2021 23:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_EliminarRoles]
	@id INT
AS 
delete from tb_roles where id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarLogin]    Script Date: 28/06/2021 23:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertarLogin]
	@login varchar(50),
	@contrasena varchar(50),
	@idRol int
as
begin
insert into tb_login values
	(@login,@contrasena,@idRol)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarRoles]    Script Date: 28/06/2021 23:10:03 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 28/06/2021 23:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_login]
@logueo varchar(50),
@contrasena varchar(50)
as
select * from tb_login where logueo=@logueo and contrasena=@contrasena
GO
