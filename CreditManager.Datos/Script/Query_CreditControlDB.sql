CREATE DATABASE CreditControlDB
GO

USE CreditControlDB
GO

CREATE TABLE TiposDocumento
(
	IdTipoDocumento INT PRIMARY KEY IDENTITY(1,1),
	Tipo VARCHAR(50),
);

-- Tipos de documentos
INSERT INTO TiposDocumento (Tipo) VALUES ('Cédula de ciudadanía');
INSERT INTO TiposDocumento (Tipo) VALUES ('Tarjeta de identidad');
INSERT INTO TiposDocumento (Tipo) VALUES ('Cédula de extranjería');
INSERT INTO TiposDocumento (Tipo) VALUES ('Pasaporte');
INSERT INTO TiposDocumento (Tipo) VALUES ('RUT');
INSERT INTO TiposDocumento (Tipo) VALUES ('NIT');

CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    PrimerNombre VARCHAR(15) NOT NULL,
    SegundoNombre VARCHAR(15),
    PrimerApellido VARCHAR(15) NOT NULL,
    SegundoApellido VARCHAR(15),
    NumeroDocumento VARCHAR(15) NOT NULL,
    IdTipoDocumento INT NOT NULL REFERENCES TiposDocumento(IdTipoDocumento),
    NumeroTelefono VARCHAR(10),
    Direccion VARCHAR(100),
    NumeroCelular VARCHAR(10),
    CorreoElectronico VARCHAR(50),
	FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(), 
    Estado BIT NOT NULL DEFAULT 1
);

-- Clientes de ejemplo
INSERT INTO Clientes (PrimerNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, CorreoElectronico, NumeroCelular) VALUES ('Juan', 'Pérez', '123456789', 1, 'juan.perez@gmail.com', '3211234567');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('María', 'Luisa', 'González', 'Pérez', '234567890', 2, '3123456789', 'Calle 1 #2-3', '3009876543', 'maria.gonzalez@hotmail.com');
INSERT INTO Clientes (PrimerNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroCelular) VALUES ('Pedro', 'López', '345678901', 1, '3109876543');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Carlos', 'Andrés', 'Rodríguez', 'García', '456789012', 3, '3112345678', 'Carrera 2 #4-5', '3011234567', 'carlos.rodriguez@gmail.com');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Ana', 'María', 'Gómez', '567890123', 1, '3108765432', 'Avenida 3 #6-7', '3023456789', 'ana.gomez@yahoo.com');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Sara', 'Lucía', 'Pérez', 'González', '789012345', 4, '3145678901', 'Calle 4 #8-9', '3034567890', 'sara.perez@hotmail.com');
INSERT INTO Clientes (PrimerNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, NumeroCelular, CorreoElectronico) VALUES ('Jorge', 'García', '890123456', 5, '3156789012', '3045678901', 'jorge.garcia@gmail.com');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, NumeroDocumento, IdTipoDocumento, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Luisa', 'María', 'Gutiérrez', 'Pérez', '901234567', 6, 'Carrera 5 #10-11', '3056789012', 'luisa.gutierrez@yahoo.com');
INSERT INTO Clientes (PrimerNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Pedro', 'Castro', '3456789012', 3, '3456789', 'Avenida 789', '7654321098', 'pedro.castro@yahoo.com');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Ana', 'María', 'Gutiérrez', '4567890123', 4, '4567890', 'Calle 1011', '6543210987', 'ana.gutierrez@gmail.com');
INSERT INTO Clientes (PrimerNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Luis', 'Hernández', '5678901234', 5, '5678901', 'Carrera 1213', '5432109876', 'luis.hernandez@hotmail.com');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Juan', 'Antonio', 'González', 'García', '1234567890', 1, '1234567', 'Calle 123', '9876543210', 'juan.gonzalez@gmail.com');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Carolina', 'Andrea', 'Pérez', 'Gómez', '6789012345', 6, '6789012', 'Avenida 1415', '4321098765', 'carolina.perez@yahoo.com');
INSERT INTO Clientes (PrimerNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Jorge', 'Martínez', '7890123456', 1, '7890123', 'Calle 1617', '3210987654', 'jorge.martinez@gmail.com');
INSERT INTO Clientes (PrimerNombre, SegundoNombre, PrimerApellido, NumeroDocumento, IdTipoDocumento, NumeroTelefono, Direccion, NumeroCelular, CorreoElectronico) VALUES ('Marcela', 'Fernanda', 'Díaz', '8901234567', 2, '8901234', 'Carrera 1819', '2109876543', 'marcela.diaz@hotmail.com');


-- Procedimiento almacenado para crear clientes en la base de datos
CREATE PROC CrearCliente
(
	@NumeroDocumento    VARCHAR(15),
	@IdTipoDocumento    INT,
	@PrimerNombre       VARCHAR(15),
	@SegundoNombre      VARCHAR(15),
	@PrimerApellido     VARCHAR(15),
	@SegundoApellido    VARCHAR(15),
	@NumeroTelefono     VARCHAR(10),
	@NumeroCelular      VARCHAR(10),
    @Direccion          VARCHAR(100),
    @CorreoElectronico  VARCHAR(50),
	@Estado             BIT,
	@Resultado          INT OUTPUT,
	@Mensaje            VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
	DECLARE @IdCliente INT
	IF NOT EXISTS (SELECT * FROM clientes WHERE NumeroDocumento = @NumeroDocumento)
	BEGIN	
		INSERT INTO clientes (
			NumeroDocumento,
			IdTipoDocumento,
			PrimerNombre,
			SegundoNombre,
			PrimerApellido,
			SegundoApellido,
			NumeroTelefono,
			NumeroCelular,
			Direccion,
			CorreoElectronico,
			Estado
		) 
		VALUES (
			@NumeroDocumento,
			@IdTipoDocumento,
			@PrimerNombre,
			@SegundoNombre,
			@PrimerApellido,
			@SegundoApellido,
			@NumeroTelefono,
			@NumeroCelular,
			@Direccion,
			@CorreoElectronico,
			@Estado
			)
			SET @Resultado = SCOPE_IDENTITY()
		END
	ELSE	
		set @Mensaje = 'Este número de documento ya se encuentra registrado.'
END

-- Procedimiento almacenado para listar clientes en la base de datos
CREATE PROC ListarClientes
AS
BEGIN
    SELECT 
        c.IdCliente, 
        c.PrimerNombre, 
        c.SegundoNombre, 
        c.PrimerApellido, 
        c.SegundoApellido, 
        c.NumeroDocumento, 
        td.IdTipoDocumento, 
        td.Tipo AS TipoDocumento, 
        c.NumeroTelefono, 
        c.Direccion, 
        c.NumeroCelular, 
        c.CorreoElectronico, 
        c.FechaRegistro, 
        c.Estado
    FROM 
        Clientes c
    INNER JOIN 
        TiposDocumento td 
    ON 
        c.IdTipoDocumento = td.IdTipoDocumento;
END;

-- Listar a clientes con su respectivo tipo de documento
SELECT c.IdCliente, c.PrimerNombre, c.SegundoNombre, c.PrimerApellido, c.SegundoApellido, c.NumeroDocumento, td.IdTipoDocumento, td.Tipo AS TipoDocumento, c.NumeroTelefono, c.Direccion, c.NumeroCelular, c.CorreoElectronico, c.FechaRegistro, c.Estado
FROM Clientes c
INNER JOIN TiposDocumento td ON c.IdTipoDocumento = td.IdTipoDocumento;

-- Esta sentencia es parecida al DESCRIBE en ORACLE
select * from INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Clientes' -- Aqui pones el nombre de la columna que deeses consultar a detalle
