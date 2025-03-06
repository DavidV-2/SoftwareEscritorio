CREATE DATABASE DBFOTO_CORREA
    
USE DBFOTO_CORREA

GO

/****************** CREACIÓN DE TABLAS ******************/

CREATE TABLE ROL (
    IdRol INT PRIMARY KEY IDENTITY,
    Descripcion VARCHAR(50),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE PERMISO (
    IdPermiso INT PRIMARY KEY IDENTITY,
    IdRol INT REFERENCES ROL(IdRol),
    NombreMenu VARCHAR(100),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE USUARIO (
    IdUsuario INT PRIMARY KEY IDENTITY,
    Documento VARCHAR(50),
    NombreCompleto VARCHAR(50),
    Correo VARCHAR(50),
    Clave VARCHAR(50),
    IdRol INT REFERENCES ROL(IdRol),
    Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE CLIENTE (
    IdCliente INT PRIMARY KEY IDENTITY,
    Documento VARCHAR(50),
    NombreCompleto VARCHAR(50),
    Correo VARCHAR(50),
    Telefono VARCHAR(50),
	TipoCompra VARCHAR (50),
	EstadoDeuda VARCHAR (50),
    Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE CATEGORIA (
    IdCategoria INT PRIMARY KEY IDENTITY,
    Detalle VARCHAR(100),
    Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE PRODUCTO (
    IdProducto INT PRIMARY KEY IDENTITY,
	IdCategoria INT REFERENCES CATEGORIA(IdCategoria),
    CodProducto VARCHAR(50),
    DetalleProducto VARCHAR(50),
    PrecioVenta DECIMAL(10,2) DEFAULT 0,
    Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE PRODUCTO_DETAL (
    IdProducto INT PRIMARY KEY IDENTITY,
    Producto VARCHAR(50),
    PrecioVenta DECIMAL(10,2) DEFAULT 0,
    Estado BIT
);

GO

CREATE TABLE VENTA (
    IdVenta INT PRIMARY KEY IDENTITY,
    IdProducto INT REFERENCES PRODUCTO(IdProducto),
    DatosCliente VARCHAR(50),
    Telefono VARCHAR(50),
    Especificaciones VARCHAR(50),
    ValorVenta DECIMAL(10,2),
    ValorPagado DECIMAL(10,2),
    ValorResta DECIMAL(10,2),
    SubTotal DECIMAL(10,2),
    Cantidad INT,
    EstadoDeuda VARCHAR(50),
    NumeroConsecutivo INT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE VENTA_DETAL (
    IdVentaDetal INT PRIMARY KEY IDENTITY,
    IdProducto INT REFERENCES PRODUCTO_DETAL(IdProducto),
    NumeroConsecutivo INT,
    Producto VARCHAR(100),
    Cantidad INT,
    SubTotal DECIMAL(10,2),
    PrecioVenta DECIMAL(10,2) DEFAULT 0,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE DETALLE_VENTA (
    IdDetalleVenta INT PRIMARY KEY IDENTITY,
    IdVenta INT REFERENCES VENTA(IdVenta),
    IdProducto INT REFERENCES PRODUCTO(IdProducto),
	DatosCliente VARCHAR(50),
    Telefono VARCHAR(50),
    Especificaciones VARCHAR(50),
    Cantidad INT,
    ValorVenta DECIMAL(10,2),
    ValorPagado DECIMAL(10,2),
    ValorResta DECIMAL(10,2),
    SubTotal DECIMAL(10,2),
	EstadoDeuda VARCHAR(50),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE DETALLE_VENTADETAL (
    IdDetVentaDetal INT PRIMARY KEY IDENTITY,
    Cantidad INT,
    SubTotal DECIMAL(10,2),
    IdProducto INT REFERENCES PRODUCTO_DETAL(IdProducto),
    PrecioVenta DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

GO

CREATE TABLE EVENTO (
    IdEvento INT PRIMARY KEY IDENTITY,
	FechaEvento VARCHAR(60),
    DatosCliente VARCHAR(60),
    Telefono VARCHAR(60),
    Direccion VARCHAR(60),
    DescripcionEvento VARCHAR(100),
    ValorVenta DECIMAL(10,2),
    ValorPagado DECIMAL(10,2),
    ValorResta DECIMAL(10,2),
    Estado BIT,
	FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*************************** CREACIÓN DE PROCEDIMIENTOS ALMACENADOS ***************************/
/*--------------------------------------------------------------------------------------------*/

CREATE PROC SP_RegistrarUsuario (
    @Documento VARCHAR(50),
    @NombreCompleto VARCHAR(100),
    @Correo VARCHAR(100),
    @Clave VARCHAR(100),
    @IdRol INT,
    @Estado BIT,
    @IdUsuarioResultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @IdUsuarioResultado = 0
    SET @Mensaje = ''

    IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento)
    BEGIN
        INSERT INTO USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES
        (@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)

        SET @IdUsuarioResultado = SCOPE_IDENTITY()
        SET @Mensaje = 'Usuario registrado con éxito.'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'No se puede repetir el documento para más de un usuario.'
    END
END

GO

CREATE PROC SP_EditarUsuario (
    @IdUsuario INT,
    @Documento VARCHAR(50),
    @NombreCompleto VARCHAR(100),
    @Correo VARCHAR(100),
    @Clave VARCHAR(100),
    @IdRol INT,
    @Estado BIT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''

    IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento AND IdUsuario != @IdUsuario)
    BEGIN
        UPDATE USUARIO SET
            Documento = @Documento,
            NombreCompleto = @NombreCompleto,
            Correo = @Correo,
            Clave = @Clave,
            IdRol = @IdRol,
            Estado = @Estado
        WHERE IdUsuario = @IdUsuario

        SET @Respuesta = 1
        SET @Mensaje = 'Usuario editado con éxito.'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'No se puede repetir el documento para más de un usuario.'
    END
END

GO

CREATE PROC SP_EliminarUsuario (
    @IdUsuario INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''

    -- Verificar si el usuario existe antes de intentar eliminarlo
    IF EXISTS (SELECT 1 FROM USUARIO WHERE IdUsuario = @IdUsuario)
    BEGIN
        DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario
        SET @Respuesta = 1
        SET @Mensaje = 'Usuario eliminado con éxito.'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'Usuario no encontrado.'
    END
END

GO

/* ---------- PROCEDIMIENTOS PARA CATEGORIA -----------------*/

CREATE PROC SP_RegistrarCategoria (
    @Descripcion VARCHAR(50),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0

    IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Detalle = @Descripcion)
    BEGIN
        INSERT INTO CATEGORIA (Detalle, Estado) VALUES (@Descripcion, @Estado)
        SET @Resultado = SCOPE_IDENTITY()
        SET @Mensaje = 'Categoría registrada con éxito.'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'No se puede repetir la descripción de una categoría.'
    END
END

GO

CREATE PROC SP_EditarCategoria (
    @IdCategoria INT,
    @Descripcion VARCHAR(50),
    @Estado BIT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Detalle = @Descripcion AND IdCategoria != @IdCategoria)
    BEGIN
        UPDATE CATEGORIA SET
            Detalle = @Descripcion,
            Estado = @Estado
        WHERE IdCategoria = @IdCategoria

        SET @Mensaje = 'Categoría editada con éxito.'
    END
    ELSE
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'No se puede repetir la descripción de una categoría.'
    END
END

GO

CREATE PROC SP_EliminarCategoria (
    @IdCategoria INT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    IF NOT EXISTS (
        SELECT * FROM CATEGORIA c
        INNER JOIN PRODUCTO p ON p.IdCategoria = c.IdCategoria
        WHERE c.IdCategoria = @IdCategoria
    )
    BEGIN
        DELETE FROM CATEGORIA WHERE IdCategoria = @IdCategoria
        SET @Mensaje = 'Categoría eliminada con éxito.'
    END
    ELSE
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'La categoría se encuentra relacionada a un producto.'
    END
END

GO

/* ---------- PROCEDIMIENTOS PARA PRODUCTO -----------------*/

CREATE PROC SP_RegistrarProducto (
    @IdCategoria INT,
    @CodProducto VARCHAR(20),
    @DetalleProducto VARCHAR(30),
    @PrecioVenta DECIMAL(10,2),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0

    IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE CodProducto = @CodProducto)
    BEGIN
        INSERT INTO PRODUCTO (IdCategoria, CodProducto, DetalleProducto, PrecioVenta, Estado)
        VALUES (@IdCategoria, @CodProducto, @DetalleProducto, @PrecioVenta, @Estado)

        SET @Resultado = SCOPE_IDENTITY()
        SET @Mensaje = 'Producto registrado con éxito.'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'Ya existe un producto con el mismo código.'
    END
END

GO

CREATE PROC SP_ModificarProducto (
    @IdProducto INT,
    @CodProducto VARCHAR(20),
    @DetalleProducto VARCHAR(30),
    @IdCategoria INT,
    @Estado BIT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE CodProducto = @CodProducto AND IdProducto != @IdProducto)
    BEGIN
        UPDATE PRODUCTO SET
            CodProducto = @CodProducto,
            DetalleProducto = @DetalleProducto,
            IdCategoria = @IdCategoria,
            Estado = @Estado
        WHERE IdProducto = @IdProducto

        SET @Mensaje = 'Producto modificado con éxito.'
    END
    ELSE
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'Ya existe un producto con el mismo código.'
    END
END

GO

CREATE PROC SP_EliminarProducto (
    @IdProducto INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''
    DECLARE @pasoReglas BIT = 1

    IF EXISTS (SELECT * FROM DETALLE_VENTA dv
               INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
               WHERE p.IdProducto = @IdProducto)
    BEGIN
        SET @pasoReglas = 0
        SET @Mensaje = 'No se puede eliminar porque se encuentra relacionado a una VENTA.'
    END

    IF @pasoReglas = 1
    BEGIN
        DELETE FROM PRODUCTO WHERE IdProducto = @IdProducto
        SET @Respuesta = 1
        SET @Mensaje = 'Producto eliminado con éxito.'
    END
END

GO

/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------*/

CREATE PROC SP_RegistrarCliente (
    @Documento VARCHAR(50),
    @NombreCompleto VARCHAR(50),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(50),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0

    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
    BEGIN
        INSERT INTO CLIENTE (Documento, NombreCompleto, Correo, Telefono, Estado)
        VALUES (@Documento, @NombreCompleto, @Correo, @Telefono, @Estado)

        SET @Resultado = SCOPE_IDENTITY()
        SET @Mensaje = 'Cliente registrado con éxito.'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'El número de documento ya existe.'
    END
END

GO

CREATE PROC SP_ModificarCliente (
    @IdCliente INT,
    @Documento VARCHAR(50),
    @NombreCompleto VARCHAR(50),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(50),
    @Estado BIT,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1

    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento AND IdCliente != @IdCliente)
    BEGIN
        UPDATE CLIENTE SET
            Documento = @Documento,
            NombreCompleto = @NombreCompleto,
            Correo = @Correo,
            Telefono = @Telefono,
            Estado = @Estado
        WHERE IdCliente = @IdCliente

        SET @Mensaje = 'Cliente modificado con éxito.'
    END
    ELSE
    BEGIN
        SET @Resultado = 0
        SET @Mensaje = 'El número de documento ya existe.'
    END
END

GO

/****************** INSERTAMOS REGISTROS A LAS TABLAS ******************/
/*---------------------------------------------------------------------*/

INSERT INTO ROL (Descripcion)
VALUES ('ADMINISTRADOR');

GO

INSERT INTO ROL (Descripcion)
VALUES ('EMPLEADO');

GO

INSERT INTO USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
VALUES
    ('01', 'ADMIN', '@GMAIL.COM', '123', 1, 1);

GO

INSERT INTO USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
VALUES
    ('00', 'EMPLEADO', '@GMAIL.COM', '456', 2, 1);

GO

INSERT INTO PERMISO (IdRol, NombreMenu) VALUES
    (1, 'menu_ventas'),
    (1, 'menu_detalle_ventas'),
    (1, 'menu_agenda'),
    (1, 'menu_productos'),
    (1, 'menu_clientes'),
    (1, 'menu_usuarios'),
    (1, 'Menu_Acercade');

GO

INSERT INTO PERMISO (IdRol, NombreMenu) VALUES
    (2, 'menu_ventas'),
    (2, 'menu_detalle_ventas'),
    (2, 'menu_agenda'),
    (2, 'menu_productos'),
    (2, 'Menu_Acercade');

GO

INSERT INTO EVENTO (DatosCliente, Telefono, Direccion, DescripcionEvento, ValorVenta, ValorPagado, ValorResta, Estado) 
VALUES 
    ('Sujeto Prueba', '300000', 'av35. CodProducto estudiante 123', 'prueba', 250000, 250000, 0, 1);
