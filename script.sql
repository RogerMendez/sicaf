

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_empleado]
(
	@pat varchar(20),
	@mat varchar(20),
	@nom varchar(30),
	@uni varchar(3),
	@fono varchar(10),
	@cargo varchar(100),
	@ci varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE       empleado
SET                pat = @pat, mat = @mat, nombres = @nom, cod_uni = @uni, telf_fun = @fono, cargo = @cargo
WHERE        (ci = @ci)
GO
/****** Object:  StoredProcedure [dbo].[actualizar_oficina]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_oficina]
(
	@des varchar(100),
	@ubi varchar(20),
	@uni varchar(3),
	@piso varchar(2),
	@pat varchar(20),
	@mat varchar(20),
	@nom varchar(50),
	@cod varchar(4)
)
AS
	SET NOCOUNT OFF;
UPDATE       oficina
SET                descripcion = @des, ubicacion = @ubi, cod_unid = @uni, piso = @piso, pat_reso = @pat, mat_resp = @mat, nom_reso = @nom
WHERE        (cod_ofi = @cod)
GO
/****** Object:  StoredProcedure [dbo].[actualizar_usuario]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizar_usuario]
(
	@nom varchar(30),
	@ape varchar(30),
	@pass varchar(15),
	@rol varchar(50),
	@tipo char(1),
	@nick varchar(20),
	@cod varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE       users
SET                nombres = @nom, apellidos = @ape, password = @pass, rol = @rol, tipo = @tipo, usuario = @nick
WHERE        (cod_user = @cod)
GO
/****** Object:  StoredProcedure [dbo].[buscando]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscando]
	@cod varchar(10),
	@codigo varchar(10)output
as
	set @codigo = (select u.cod_user from users u where(u.cod_user = @cod))
	
	
	
	
	
	
GO
/****** Object:  StoredProcedure [dbo].[eliminar_empleado]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_empleado]
(
	@ci varchar(10)
)
AS
	SET NOCOUNT OFF;
DELETE FROM empleado
WHERE        (ci = @ci)
GO
/****** Object:  StoredProcedure [dbo].[eliminar_oficina]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_oficina]
(
	@cod varchar(4)
)
AS
	SET NOCOUNT OFF;
DELETE FROM oficina
WHERE        (cod_ofi = @cod)
GO
/****** Object:  StoredProcedure [dbo].[eliminar_proveedores]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminar_proveedores]
(
	@nit varchar(15)
)
AS
	SET NOCOUNT OFF;
DELETE FROM proveedores
WHERE        (nit = @nit)

GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_usuario]
(
	@cod varchar(10)
)
AS
	SET NOCOUNT OFF;
DELETE FROM users
WHERE        (cod_user = @cod)
GO
/****** Object:  StoredProcedure [dbo].[existe_activof]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[existe_activof]
@cod varchar(10),
@existe varchar(5) output
as
	if exists (select * from activof where(codaf=@cod))
	begin
		set @existe = 'TRUE'
	end
	else
	begin
		set @existe = 'FALSE'
	end

GO
/****** Object:  StoredProcedure [dbo].[existe_empleado]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[existe_empleado]
@car varchar(10),
@existe varchar(5) output
as
	if exists (select * from empleado where(ci=@car))
	begin
		set @existe = 'TRUE'
	end
	else
	begin
		set @existe = 'FALSE'
	end

GO
/****** Object:  StoredProcedure [dbo].[existe_nick]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[existe_nick]
@nick varchar(10),
@existe varchar(5) output
as
	if exists (select * from users where(usuario=@nick))
	begin
		set @existe = 'TRUE'
	end
	else
	begin
		set @existe = 'FALSE'
	end


GO
/****** Object:  StoredProcedure [dbo].[existe_oficina]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[existe_oficina]
@cod varchar(10),
@existe varchar(5) output
as
	if exists (select * from oficina where(cod_ofi =@cod))
	begin
		set @existe = 'TRUE'
	end
	else
	begin
		set @existe = 'FALSE'
	end

GO
/****** Object:  StoredProcedure [dbo].[existe_proveedor]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[existe_proveedor]
@nit varchar(10),
@existe varchar(5) output
as
	if exists (select * from proveedores where(nit=@nit))
	begin
		set @existe = 'TRUE'
	end
	else
	begin
		set @existe = 'FALSE'
	end

GO
/****** Object:  StoredProcedure [dbo].[existe_unidad]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[existe_unidad]
@cod varchar(10),
@existe varchar(5) output
as
	if exists (select * from unidad where(cod_uni=@cod))
	begin
		set @existe = 'TRUE'
	end
	else
	begin
		set @existe = 'FALSE'
	end

GO
/****** Object:  StoredProcedure [dbo].[insertar_activof]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_activof]
@codaf varchar(10),
@desaf varchar(200),
@unidad varchar(20),
@marca varchar(20),
@proce varchar(15),
@num_ser varchar(15),
@tdoc varchar(15),
@nrodoc varchar(15),
@precio decimal(10,2),
@tasa decimal(10,3),
@cprov varchar(15),
@res_reg varchar(10),
@cond_act varchar(25),
@status varchar(20),
@codt int,
@cods int
as
begin transaction
	INSERT into activof
	values(@codaf,@desaf,@unidad,@marca,@proce,@num_ser,@tdoc,@nrodoc,@precio,@tasa,@cprov,GETDATE(),@res_reg,@cond_act,@status)
	insert into activof_tipo values(@codt,@cods,@codaf)
if(@@ERROR = 0)
begin
	commit transaction
end
else
begin
	rollback transaction
end

GO
/****** Object:  StoredProcedure [dbo].[insertar_bajaaf]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[insertar_bajaaf]
	@codaf varchar(10),
	@respo varchar(20),
	@funci varchar(10),
	@motivo varchar(50),
	@obs varchar(200)
AS
begin transaction
	INSERT INTO bajact
	values(@codaf,@respo,@funci,GETDATE(),@motivo,@obs)
	update activof set status='DE BAJA' where(codaf=@codaf)
if(@@ERROR=0)
begin
	commit transaction
end
else
begin
	rollback transaction
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_mantenimiento]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_mantenimiento]
	@codaf varchar(10),
	@fechamant datetime,
	@fechaconclu datetime,
	@descrip varchar(200),
	@tipoman varchar(15),
	@cospar decimal(10,2),
	@cosman decimal(10,2),
	@persomant varchar(100)
AS
begin transaction
	declare @max int
	if exists(select * from mantenimiento)
	begin
		set @max = convert(int,(select MAX(cod_man)from mantenimiento)) + 1
	end
	else
	begin
		set @max = 1
	end
	INSERT INTO mantenimiento
	VALUES(@max,@codaf,@fechamant,@fechaconclu,@descrip,@tipoman,@cospar,@cosman,@persomant)
	update activof set status='MANTENIMIENTO' where(codaf=@codaf)
if(@@ERROR=0)
begin
	commit transaction
end
else
begin
	rollback transaction
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_revaluo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[insertar_revaluo]
	@codaf varchar(10),
	@fecha datetime,
	@respo varchar(20),
	@obs varchar(200)
AS
begin transaction
	INSERT INTO revaluos 
	values(@codaf,@fecha,@respo,@obs)
	update activof set status='REVALUO' where(codaf=@codaf)
if(@@ERROR=0)
begin
	commit transaction
end
else
begin
	rollback transaction
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_tipo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_tipo]
	@nombre varchar(50),
	@codi int output
as
	insert into tipo values(@nombre)
	set @codi=(select MAX(codigo)  from tipo)
	
GO
/****** Object:  StoredProcedure [dbo].[insertar_users]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_users]
(
	@nom varchar(30),
	@ap varchar(30),
	@pass varchar(15),
	@rol varchar(50),
	@tip char(1),
	@nick varchar(20)
)
AS
	declare @max int
	if exists(select * from users)
	begin
		set @max = convert(int,(select MAX(cod_user)from users)) + 1
	end
	else
	begin
		set @max = 1
	end
	INSERT INTO users (cod_user, nombres, apellidos, password, rol, tipo, usuario)
	VALUES(@max,@nom,@ap,@pass,@rol,@tip,@nick)
GO
/****** Object:  StoredProcedure [dbo].[logeo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[logeo]
	@nick varchar(50),
	@pass varchar(50),
	@existe varchar(10) output,
	@nivel varchar(20)output,
	@codigo varchar(20)output
as
if exists(select * from users u where(u.password=@pass and u.usuario=@nick))
begin
	set @existe='TRUE'
	set @nivel = (select rol from users where(password=@pass and usuario=@nick))
	set @codigo = (select cod_user from users where(password=@pass and usuario=@nick))
end
else
begin
	set @existe = 'FALSE'
	set @nivel = 'NOTHING'
end
GO
/****** Object:  StoredProcedure [dbo].[modificar_proveedor]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[modificar_proveedor]
(
	@nit1 varchar(15),
	@nom varchar(30),
	@fono varchar(10),
	@direc varchar(50),
	@web varchar(50),
	@tipo varchar(50),
	@nit varchar(15)
)
AS
	SET NOCOUNT OFF;
UPDATE       proveedores
SET                nit = @nit1, nom_pro = @nom, tel_prov = @fono, dir_prov = @direc, wev_prov = @web, tipo = @tipo
WHERE        (nit = @nit)

GO
/****** Object:  StoredProcedure [dbo].[mostrar_activos_unidad_asinado]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_activos_unidad_asinado]
@unidad varchar(100)
as
	select * from asignacion_unidad
	where(cod_uni = @unidad)
GO
/****** Object:  StoredProcedure [dbo].[mostrar_asignaciones_funcionario]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_asignaciones_funcionario]
(
	@ci varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT      cod_asing,  [Codigo A. F.], [Nombre Tipo], [Nombre SubTipo], unidad, marca, Cedula, Funcionario, cargo, [Fecha Asignación], Observacion
FROM            mostrar_asignaciones
WHERE        (Cedula = @ci)
GO
/****** Object:  StoredProcedure [dbo].[mostrar_asing_activo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[mostrar_asing_activo]
AS
	SET NOCOUNT ON;
SELECT        distinct(codaf), desaf, unidad, marca, proce, num_ser, tdoc, nrodoc, precio, tasa, cprov, fecha_reg, res_reg, cond_act, status
FROM            activof, asigns 
WHERE        (activof.codaf  not in (select cod_act from asigns where(estado = 1) ))
GO
/****** Object:  StoredProcedure [dbo].[mostrar_nombres]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[mostrar_nombres]
	@codt int,
	@cods int,
	@nomtip varchar(50) output,
	@nomsub varchar(50) output
as
	set @nomtip = (select t.nombre from tipo t, subtipo s where(t.codigo=@codt and s.codigosub=@cods))
	set @nomsub = (select s.nombre from tipo t, subtipo s where(t.codigo=@codt and s.codigosub=@cods))
	
GO
/****** Object:  StoredProcedure [dbo].[mostrar_subtipo_codtipo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_subtipo_codtipo]
(
	@cod int
)
AS
	SET NOCOUNT ON;
SELECT codigosub, nombre, codtipo FROM dbo.subtipo
where(codtipo=@cod)
GO
/****** Object:  StoredProcedure [dbo].[quitar_suptipo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[quitar_suptipo]
(
	@cod int
)
AS
	SET NOCOUNT OFF;
DELETE FROM subtipo
WHERE        (codigosub = @cod)
GO
/****** Object:  StoredProcedure [dbo].[registro_asignacion]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registro_asignacion]
	@codaf varchar(50),
	@cod_fun varchar(10),
	@resp varchar(10),
	@obs varchar(100)
as
begin transaction
	insert into asigns values(@codaf,@cod_fun,GETDATE(),@resp,@obs, 1)
	update activof set status='ASIGNADO' where(codaf=@codaf)
if(@@ERROR=0)
begin
	commit transaction
end
else
begin
	rollback transaction
end
GO
/****** Object:  StoredProcedure [dbo].[registro_devolucion]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registro_devolucion]
	@codaf varchar(10),
	@codfun varchar(60),
	@resp varchar(50),
	@obs varchar(200),
	@cod_asig int
as
begin transaction
	insert into devol values(@codaf,@codfun,GETDATE(),@resp,@obs)
	update activof set status='DEVUELTO'
	--update asigns set estado = 0 where
	where(codaf=@codaf)
	update asigns set estado = 0
	where (cod_asing = @cod_asig)
if(@@ERROR=0)
begin
	commit transaction
end
else
begin
	rollback transaction
end
GO
/****** Object:  StoredProcedure [dbo].[seleccionar_activof_tipo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[seleccionar_activof_tipo]
	@codt int,
	@cods int
as
select a.* from activof a, activof_tipo t
where(a.codaf=t.codaf and t.codt=@codt and t.codst=@cods and a.codaf  not in (select cod_act from asigns where(estado = 1) ))
order by a.codaf asc

GO
/****** Object:  StoredProcedure [dbo].[seleccionar_empleado]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[seleccionar_empleado]
(
	@var varchar(30)
)
AS
	SET NOCOUNT ON;
SELECT * FROM empleado 
WHERE(nombres LIKE '%' + @var + '%' or pat like '%' + @var + '%' or ci like '%' + @var + '%')
GO
/****** Object:  StoredProcedure [dbo].[seleccionar_oficina]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[seleccionar_oficina]
(
	@var varchar(30)
)
AS
	SET NOCOUNT ON;
SELECT        *
from oficina 
WHERE (ubicacion like '%'+ @var +'%' or  descripcion like '%'+ @var +'%' or cod_ofi=@var)

GO
/****** Object:  StoredProcedure [dbo].[seleccionar_proveedor]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[seleccionar_proveedor]
(
	@nom varchar(30),
	@ni varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT        nit, nom_pro, dir_prov, tel_prov, wev_prov, tipo
FROM            proveedores
WHERE        (nom_pro LIKE '%' + @nom + '%' or nit like '%' + @ni + '%')

GO
/****** Object:  StoredProcedure [dbo].[seleccionar_usuario]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[seleccionar_usuario]
(
	@nom varchar(30),
	@ape varchar(30),
	@nick varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT * FROM users 
WHERE(nombres LIKE '%' + @nom + '%' or apellidos like '%' + @ape + '%' or usuario like '%' + @nick + '%')
GO
/****** Object:  StoredProcedure [dbo].[select_mostrar_bajas]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[select_mostrar_bajas]
as 
SELECT *from mostrar_bajas

GO
/****** Object:  StoredProcedure [dbo].[select_report_asigna]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[select_report_asigna]
as
declare @id int
set @id = (select MAX(cod_asing)from reportes_asignaciones )
select *from reportes_asignaciones where cod_asing = @id

GO
/****** Object:  StoredProcedure [dbo].[select_report_asigna_id]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[select_report_asigna_id]
@id int
as
select *from reportes_asignaciones where cod_asing = @id



GO
/****** Object:  StoredProcedure [dbo].[unidad_empleado]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[unidad_empleado]
@ci int,
@unidad varchar(100) output
as
	if exists(select * from empleado where(@ci = ci))
	begin
		set @unidad = (select cod_uni from empleado where(@ci = ci))
	end
	else
	begin
		set @unidad = 'FALSE'
	end
GO
/****** Object:  Table [dbo].[activof]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[activof](
	[codaf] [varchar](10) NOT NULL,
	[desaf] [varchar](200) NOT NULL,
	[unidad] [varchar](20) NOT NULL,
	[marca] [varchar](20) NULL,
	[proce] [varchar](15) NULL,
	[num_ser] [varchar](15) NULL,
	[tdoc] [varchar](15) NOT NULL,
	[nrodoc] [varchar](15) NOT NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[tasa] [decimal](10, 3) NOT NULL,
	[cprov] [varchar](15) NOT NULL,
	[fecha_reg] [datetime] NOT NULL,
	[res_reg] [varchar](10) NOT NULL,
	[cond_act] [varchar](25) NOT NULL,
	[status] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codaf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[activof_tipo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[activof_tipo](
	[codt] [int] NULL,
	[codst] [int] NULL,
	[codaf] [varchar](10) NOT NULL,
UNIQUE NONCLUSTERED 
(
	[codaf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[asigns]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asigns](
	[cod_asing] [int] IDENTITY(1,1) NOT NULL,
	[cod_act] [varchar](10) NOT NULL,
	[cod_fun] [varchar](10) NOT NULL,
	[fch_ass] [datetime] NOT NULL,
	[resp_ass] [varchar](10) NOT NULL,
	[obs] [varchar](100) NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_asing] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bajact]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bajact](
	[num_baja] [int] IDENTITY(1,1) NOT NULL,
	[cod_act] [varchar](10) NOT NULL,
	[cod_resp] [varchar](10) NOT NULL,
	[cod_fun] [varchar](10) NOT NULL,
	[fch_baj] [datetime] NOT NULL,
	[motivo] [varchar](300) NOT NULL,
	[obs] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[num_baja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cuentacontable]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cuentacontable](
	[num_cuenta] [varchar](11) NOT NULL,
	[cod_act] [varchar](10) NOT NULL,
	[importe] [decimal](10, 2) NOT NULL,
	[fech_proc] [datetime] NULL,
	[dep_acu] [decimal](10, 2) NULL,
	[sal_lib] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[num_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[devol]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[devol](
	[cod_dev] [int] IDENTITY(1,1) NOT NULL,
	[cod_act] [varchar](10) NOT NULL,
	[cod_func] [varchar](10) NOT NULL,
	[fech_dev] [datetime] NOT NULL,
	[resp_dev] [varchar](10) NOT NULL,
	[obs] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_dev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[ci] [varchar](10) NOT NULL,
	[pat] [varchar](20) NOT NULL,
	[mat] [varchar](20) NULL,
	[nombres] [varchar](30) NOT NULL,
	[cod_uni] [varchar](3) NOT NULL,
	[telf_fun] [varchar](10) NULL,
	[cargo] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[mantenimiento]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mantenimiento](
	[cod_man] [varchar](5) NOT NULL,
	[cod_act] [varchar](10) NOT NULL,
	[fech_man] [datetime] NOT NULL,
	[fech_ret] [datetime] NOT NULL,
	[desc_man] [varchar](200) NOT NULL,
	[tipo_man] [varchar](20) NOT NULL,
	[cost_part] [decimal](10, 2) NULL,
	[cost_man] [decimal](10, 2) NULL,
	[pers_man] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_man] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[oficina]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[oficina](
	[cod_ofi] [varchar](4) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[ubicacion] [varchar](20) NULL,
	[piso] [varchar](2) NOT NULL,
	[cod_unid] [varchar](3) NOT NULL,
	[pat_reso] [varchar](20) NOT NULL,
	[mat_resp] [varchar](20) NOT NULL,
	[nom_reso] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_ofi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedores](
	[nit] [varchar](15) NOT NULL,
	[nom_pro] [varchar](30) NOT NULL,
	[dir_prov] [varchar](50) NOT NULL,
	[tel_prov] [varchar](10) NOT NULL,
	[wev_prov] [varchar](50) NULL,
	[tipo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[revaluos]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[revaluos](
	[cod] [int] IDENTITY(1,1) NOT NULL,
	[cod_act] [varchar](10) NOT NULL,
	[fecha] [date] NULL,
	[resp_rev] [varchar](50) NULL,
	[obs] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subtipo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subtipo](
	[codigosub] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[codtipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigosub] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tpcambio]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tpcambio](
	[fech] [datetime] NOT NULL,
	[dolar] [decimal](10, 2) NOT NULL,
	[ufv] [decimal](10, 2) NOT NULL,
	[resp_reg] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[fech] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[unidad]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[unidad](
	[cod_uni] [varchar](3) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_uni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[cod_user] [varchar](10) NOT NULL,
	[nombres] [varchar](30) NOT NULL,
	[apellidos] [varchar](30) NOT NULL,
	[password] [varchar](15) NULL,
	[rol] [varchar](50) NOT NULL,
	[tipo] [char](1) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[asignacion_unidad]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[asignacion_unidad]
as
	select distinct (a.codaf),u.cod_uni, a.desaf[Descripcion],(t.nombre+' - '+st.nombre)[Tipo - Subtipo A.],
	e.ci[Cedula], (e.nombres+' '+e.pat+' '+e.mat)[Nombre],
	a.marca[Marca], a.unidad [Unidad], a.proce[Procedencia],
	 a.cond_act[Cond. Activo], asi.fch_ass[F. Asignacion],
			u.descripcion[U. Decripcion], asi.obs[Observacion]
	 
	from activof a, asigns asi, empleado e, unidad u, tipo t, subtipo st, activof_tipo at
	where(
		asi.estado = 1
		and a.codaf=asi.cod_act
		and asi.cod_fun = e.ci 
		and e.cod_uni = u.cod_uni
		and at.codaf = a.codaf
		and at.codt = t.codigo 
		and at.codst = st.codigosub
		and st.codtipo = t.codigo
	)


GO
/****** Object:  View [dbo].[devoluciones]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[devoluciones]
as
select  a.codaf,a.desaf,a.unidad,a.marca,a.precio,a.cond_act, e.nombres, e.pat,e.mat,e.cargo,d.fech_dev,t.nombre,(s.nombre) AS sup_tipo, u.descripcion
 from  activof a, devol d, empleado e, activof_tipo at, tipo t, subtipo s ,unidad u 
 where a.codaf = d.cod_act  and d.cod_func = e.ci and   a.codaf = at.codaf and
  s.codtipo = t.codigo and   at.codst = s.codigosub and e.cod_uni = u.cod_uni


GO
/****** Object:  View [dbo].[mostrar_asignaciones]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[mostrar_asignaciones]
as
	select a.cod_asing, af.codaf[Codigo A. F.], ti.nombre[Nombre Tipo],st.nombre [Nombre SubTipo],af.unidad,af.marca,
	e.ci[Cedula],(e.nombres+' '+e.pat+' '+e.mat)[Funcionario], e.cargo,
	a.fch_ass[Fecha Asignación], substring(a.obs,0,20)[Observacion]
	from asigns a inner join activof af on(af.codaf=a.cod_act)
	inner join empleado e on(a.cod_fun=e.ci)
	inner join activof_tipo at on(at.codaf=af.codaf)
	inner join tipo ti on(at.codt=ti.codigo)
	inner join subtipo st on(st.codigosub=at.codst)
	where(a.estado = 1)
GO
/****** Object:  View [dbo].[mostrar_bajas]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[mostrar_bajas]
as
select a.codaf, a.desaf,a.unidad,a.marca,a.precio, e.nombres, e.pat,e.mat,e.cargo,b.fch_baj,b.motivo,  t.nombre,(s.nombre) AS sup_tipo 
from  activof a, bajact b, empleado e, activof_tipo at, tipo t, subtipo s  
where a.codaf = b.cod_act  and b.cod_fun  = e.ci and   a.codaf = at.codaf and s.codtipo = t.codigo and   at.codst = s.codigosub


GO
/****** Object:  View [dbo].[mostrar_empleados]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[mostrar_empleados]
as
select e.ci,e.pat,e.mat,e.nombres,e.cargo,u.descripcion  from empleado e,unidad u where e.cod_uni = u.cod_uni

GO
/****** Object:  View [dbo].[mostrar_mantenimiento]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[mostrar_mantenimiento]
as
select  m.cod_man,a.codaf,a.desaf,a.unidad,a.marca,a.precio,t.nombre,(s.nombre) AS sup_tipo, m.fech_man,m.fech_ret,m.desc_man,m.tipo_man,m.cost_part,m.cost_man,m.pers_man from  activof a, mantenimiento m, activof_tipo at, tipo t, subtipo s  where a.codaf = m.cod_act  and   a.codaf = at.codaf and s.codtipo = t.codigo and   at.codst = s.codigosub


GO
/****** Object:  View [dbo].[mostrar_revauos]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[mostrar_revauos]
as
select  a.desaf,a.unidad,a.marca,a.precio,t.nombre,(s.nombre) AS sup_tipo, r.resp_rev,r.obs,r.fecha from  activof a, revaluos r, activof_tipo at, tipo t, subtipo s  where a.codaf = r.cod_act  and   a.codaf = at.codaf and s.codtipo = t.codigo and   at.codst = s.codigosub

GO
/****** Object:  View [dbo].[reportes_asignaciones]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[reportes_asignaciones]
as
select  asi.cod_asing,a.codaf, a.desaf,a.unidad,a.marca,a.precio,a.status,a.cond_act ,t.nombre,(s.nombre)AS sup_tipo,
e.ci,e.pat,e.mat,e.nombres,e.cargo,u.descripcion,asi.obs,asi.fch_ass 
from  activof a, activof_tipo at, tipo t, subtipo s, asigns asi, empleado e,unidad u 
where a.codaf = at.codaf and s.codtipo = t.codigo and   at.codst = s.codigosub and
asi.cod_act = a.codaf and asi.cod_fun = e.ci and e.cod_uni = u.cod_uni 

GO
/****** Object:  View [dbo].[view_activos]    Script Date: 12/07/2013 10:00:43 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[view_activos]
as
select  a.codaf, a.desaf,a.unidad,a.marca,a.precio,a.status, a.cond_act ,t.nombre,(s.nombre)AS sup_tipo from  activof a, activof_tipo at, tipo t, subtipo s where a.codaf = at.codaf and s.codtipo = t.codigo and   at.codst = s.codigosub 

GO
ALTER TABLE [dbo].[activof]  WITH CHECK ADD FOREIGN KEY([cprov])
REFERENCES [dbo].[proveedores] ([nit])
GO
ALTER TABLE [dbo].[activof]  WITH CHECK ADD FOREIGN KEY([cprov])
REFERENCES [dbo].[proveedores] ([nit])
GO
ALTER TABLE [dbo].[activof]  WITH CHECK ADD FOREIGN KEY([res_reg])
REFERENCES [dbo].[users] ([cod_user])
GO
ALTER TABLE [dbo].[activof]  WITH CHECK ADD FOREIGN KEY([res_reg])
REFERENCES [dbo].[users] ([cod_user])
GO
ALTER TABLE [dbo].[activof_tipo]  WITH CHECK ADD FOREIGN KEY([codaf])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[activof_tipo]  WITH CHECK ADD FOREIGN KEY([codaf])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[activof_tipo]  WITH CHECK ADD FOREIGN KEY([codst])
REFERENCES [dbo].[subtipo] ([codigosub])
GO
ALTER TABLE [dbo].[activof_tipo]  WITH CHECK ADD FOREIGN KEY([codst])
REFERENCES [dbo].[subtipo] ([codigosub])
GO
ALTER TABLE [dbo].[activof_tipo]  WITH CHECK ADD FOREIGN KEY([codt])
REFERENCES [dbo].[tipo] ([codigo])
GO
ALTER TABLE [dbo].[activof_tipo]  WITH CHECK ADD FOREIGN KEY([codt])
REFERENCES [dbo].[tipo] ([codigo])
GO
ALTER TABLE [dbo].[asigns]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[asigns]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[asigns]  WITH CHECK ADD FOREIGN KEY([cod_fun])
REFERENCES [dbo].[empleado] ([ci])
GO
ALTER TABLE [dbo].[asigns]  WITH CHECK ADD FOREIGN KEY([cod_fun])
REFERENCES [dbo].[empleado] ([ci])
GO
ALTER TABLE [dbo].[asigns]  WITH CHECK ADD FOREIGN KEY([resp_ass])
REFERENCES [dbo].[users] ([cod_user])
GO
ALTER TABLE [dbo].[asigns]  WITH CHECK ADD FOREIGN KEY([resp_ass])
REFERENCES [dbo].[users] ([cod_user])
GO
ALTER TABLE [dbo].[bajact]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[bajact]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[bajact]  WITH CHECK ADD FOREIGN KEY([cod_fun])
REFERENCES [dbo].[empleado] ([ci])
GO
ALTER TABLE [dbo].[bajact]  WITH CHECK ADD FOREIGN KEY([cod_fun])
REFERENCES [dbo].[empleado] ([ci])
GO
ALTER TABLE [dbo].[bajact]  WITH CHECK ADD FOREIGN KEY([cod_resp])
REFERENCES [dbo].[users] ([cod_user])
GO
ALTER TABLE [dbo].[bajact]  WITH CHECK ADD FOREIGN KEY([cod_resp])
REFERENCES [dbo].[users] ([cod_user])
GO
ALTER TABLE [dbo].[cuentacontable]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[cuentacontable]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[devol]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[devol]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[devol]  WITH CHECK ADD FOREIGN KEY([cod_func])
REFERENCES [dbo].[empleado] ([ci])
GO
ALTER TABLE [dbo].[devol]  WITH CHECK ADD FOREIGN KEY([cod_func])
REFERENCES [dbo].[empleado] ([ci])
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_uni])
REFERENCES [dbo].[unidad] ([cod_uni])
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_uni])
REFERENCES [dbo].[unidad] ([cod_uni])
GO
ALTER TABLE [dbo].[mantenimiento]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[mantenimiento]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[oficina]  WITH CHECK ADD FOREIGN KEY([cod_unid])
REFERENCES [dbo].[unidad] ([cod_uni])
GO
ALTER TABLE [dbo].[oficina]  WITH CHECK ADD FOREIGN KEY([cod_unid])
REFERENCES [dbo].[unidad] ([cod_uni])
GO
ALTER TABLE [dbo].[revaluos]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[revaluos]  WITH CHECK ADD FOREIGN KEY([cod_act])
REFERENCES [dbo].[activof] ([codaf])
GO
ALTER TABLE [dbo].[subtipo]  WITH CHECK ADD FOREIGN KEY([codtipo])
REFERENCES [dbo].[tipo] ([codigo])
GO
ALTER TABLE [dbo].[subtipo]  WITH CHECK ADD FOREIGN KEY([codtipo])
REFERENCES [dbo].[tipo] ([codigo])
GO
ALTER TABLE [dbo].[tpcambio]  WITH CHECK ADD FOREIGN KEY([resp_reg])
REFERENCES [dbo].[users] ([cod_user])
GO
ALTER TABLE [dbo].[tpcambio]  WITH CHECK ADD FOREIGN KEY([resp_reg])
REFERENCES [dbo].[users] ([cod_user])
GO
insert into users values ('1','ADMINISTRADOR', 'ADMINISTRADOR', 'ADMINISTRADOR','ADMINISTRADOR', 'A', 'ADMINISTRADOR')
