
create Database Bd_Foto_Correa


USE Bd_Foto_Correa

GO


create table ROL(
IdRol int primary key identity,
Descripcion varchar(50),
FechaRegistro datetime default getdate()
)

go

create table PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(100),
FechaRegistro datetime default getdate()
)

go

create table USUARIO(
IdUsuario int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar(50),
Clave varchar(50),
IdRol int references ROL(IdRol),
Estado bit,
FechaRegistro datetime default getdate()
)

go

create table CLIENTE(
IdCliente int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar(50),
Telefono varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)

go

create table CATEGORIA(
IdCategoria int primary key identity,
Descripcion varchar(100),
Estado bit,
FechaRegistro datetime default getdate()
)

go

create table PRODUCTO(
IdProducto int primary key identity,
Codigo varchar(50),
Descripcion varchar(50),
IdCategoria int references CATEGORIA(IdCategoria),
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate()
)
go

create table PRODUCTO_DETAL(
IdProducto int primary key identity,
Descripcion varchar(50),
PrecioVenta decimal(10,2) default 0,
Estado bit
)

go

create table VENTA(
IdVenta int primary key identity,
IdProducto int references PRODUCTO(IdProducto),
DatosCliente varchar(50),
Telefono varchar(50),
Especificaciones varchar(50),
ValorVenta decimal(10,2),
ValorPagado decimal(10,2),
ValorResta decimal(10,2),
SubTotal decimal(10,2),
Cantidad int,
EstadoDeuda varchar (50),
NumeroConsecutivo int,
FechaRegistro datetime default getdate()
)

go

create table Venta_Detal(
IdVentaDetal int primary key identity,
IdProducto int references PRODUCTO_DETAL(IdProducto),
NumeroConsecutivo int,
Producto varchar(100),
Cantidad int,
SubTotal decimal(10,2),
PrecioVenta decimal(10,2) default 0,
FechaRegistro datetime default getdate()
)

go

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
Telefono varchar(50),
Especificaciones varchar(50),
Cantidad int,
ValorVenta decimal(10,2),
ValorPagado decimal(10,2),
ValorResta decimal(10,2),
SubTotal decimal(10,2),
FechaRegistro datetime default getdate()
)

go

create table Detalle_VentaDetal(
IdDetVentaDetal int primary key identity,
Cantidad int,
SubTotal decimal(10,2),
IdProducto int references PRODUCTO_DETAL(IdProducto),
PrecioVenta decimal(10,2),
FechaRegistro datetime default getdate()
)

go

create table Evento(
IdEvento int primary key,
DatosCliente varchar(60),
Telefono varchar(60),
Direccion varchar(60),
DescripcionEvento varchar (100),
ValorVenta decimal(10,2),
ValorPagado decimal(10,2),
ValorResta decimal(10),
Estado bit
)

go


/*************************** CREACION DE PROCEDIMIENTOS ALMACENADOS ***************************/
/*--------------------------------------------------------------------------------------------*/

go


create PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into usuario(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values
		(@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'


end

go

create PROC SP_EDITARUSUARIO(
@IdUsuario int,
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento and idusuario != @IdUsuario)
	begin
		update  usuario set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Clave = @Clave,
		IdRol = @IdRol,
		Estado = @Estado
		where IdUsuario = @IdUsuario

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'


end
go

create PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM COMPRA C 
	INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
	WHERE U.IDUSUARIO = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n' 
	END

	IF EXISTS (SELECT * FROM VENTA V
	INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
	WHERE U.IDUSUARIO = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n' 
	END

	if(@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1 
	end

end

go

/* ---------- PROCEDIMIENTOS PARA CATEGORIA -----------------*/


create PROC SP_RegistrarCategoria(
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
	begin
		insert into CATEGORIA(Descripcion,Estado) values (@Descripcion,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		set @Mensaje = 'No se puede repetir la descripcion de una categoria'
	
end


go

Create procedure sp_EditarCategoria(
@IdCategoria int,
@Descripcion varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion =@Descripcion and IdCategoria != @IdCategoria)
		update CATEGORIA set
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'No se puede repetir la descripcion de una categoria'
	end

end

go

create procedure sp_EliminarCategoria(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from CATEGORIA c
	 inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	 where c.IdCategoria = @IdCategoria
	)
	begin
	 delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'La categoria se encuentara relacionada a un producto'
	end

end

GO

/* ---------- PROCEDIMIENTOS PARA PRODUCTO -----------------*/

create PROC sp_RegistrarProducto(
@IdCategoria int,
@Codigo varchar(20),
@Descripcion varchar(30),
@PrecioVenta decimal(10,2),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo)
	begin
		insert into producto(IdCategoria,Codigo,Descripcion,PrecioVenta,Estado) 
		values (@IdCategoria,@Codigo,@Descripcion,@PrecioVenta,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
	 SET @Mensaje = 'Ya existe un producto con el mismo codigo' 
	
end

GO

create procedure sp_ModificarProducto(
@IdProducto int,
@Codigo varchar(20),
@Descripcion varchar(30),
@IdCategoria int,
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE Codigo = @Codigo and IdProducto != @IdProducto)
		
		update PRODUCTO set
		Codigo = @Codigo,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado
		where IdProducto = @IdProducto
	ELSE
	begin
		SET @Resultado = 0
		SET @Mensaje = 'Ya existe un producto con el mismo codigo' 
	end
end

go


create PROC SP_EliminarProducto(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM DETALLE_VENTA dv
	INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n' 
	END

	if(@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1 
	end

end
go

/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------*/

create PROC sp_RegistrarCliente(
@Documento varchar(50),
@NombreCompleto varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
	begin
		insert into CLIENTE(Documento,NombreCompleto,Correo,Telefono,Estado) values (
		@Documento,@NombreCompleto,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end

go

create PROC sp_ModificarCliente(
@IdCliente int,
@Documento varchar(50),
@NombreCompleto varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento and IdCliente != @IdCliente)
	begin
		update CLIENTE set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdCliente = @IdCliente
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end

/****************** INSERTAMOS REGISTROS A LAS TABLAS ******************/
/*---------------------------------------------------------------------*/

GO

 insert into rol (Descripcion)
 values('ADMINISTRADOR')

 GO

  insert into rol (Descripcion)
 values('EMPLEADO')

 GO

 insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('01','ADMIN','@GMAIL.COM','123',1,1)

 GO


 insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
 values 
 ('00','EMPLEADO','@GMAIL.COM','456',2,1)

 GO

  insert into PERMISO(IdRol,NombreMenu) values
  (1,'menu_ventas'),
  (1,'menu_detalle_ventas'),
  (1,'menu_agenda'),
  (1,'menu_productos'),
  (1,'menu_clientes'),
  (1,'menu_usuarios'),
  (1,'Menu_Acercade')

  GO

  insert into PERMISO(IdRol,NombreMenu) values
  (2,'menu_ventas'),
  (2,'menu_detalle_ventas'),
  (2,'menu_agenda'),
  (2,'menu_productos'),
  (2,'Menu_Acercade')

  GO

  insert into Evento(IdEvento,DatosCliente,Telefono,Direccion,DescripcionEvento,ValorVenta,ValorPagado,ValorResta) values
  ('Sujeto Prueba','300000','av35. codigo estudiante 123','prueba','250000','250000','0',1)
