--Procedures para realizar diferentes operaciones en la BD
--Crear SuperHumano
create procedure crearSuperHumano
	@DNI int,
	@nombre varchar (30),
	@apellido1 varchar(30),
	@apellido2 varchar (30),
	@pais int,
	@ciudad varchar(30),
	@correoElectronico varchar(30),
	@nombreClave varchar(30),
	@cumpleannos date,
	@estado int,
	@salario float
	as
	begin
		insert into SuperHumano values (@DNI, @nombre, @apellido1, @apellido2, @pais, @ciudad, @correoElectronico,@nombreClave, @cumpleannos, @estado, @salario)
	end
--Asignar poder 
create procedure asignarPoder
	@DNI int,
	@idPoder int,
	@estadoPoder varchar(30)
	as
	begin
		insert into IntermediaSuperHumanoPoderes values(@DNI, @idPoder, @estadoPoder)
	end
--Asignar categoria
create procedure asignarCategoria
	@DNI int,
	@idCategoria int
	as
	begin
		insert into IntermediaSuperHumanoCategoria values(@DNI, @idCategoria)
	end

--Actualizar SuperHumano
create procedure actualizarSuperHumano
	@DNI int,
	@nombre varchar (30),
	@apellido1 varchar(30),
	@apellido2 varchar (30),
	@pais int,
	@ciudad varchar(30),
	@correoElectronico varchar(30),
	@nombreClave varchar(30),
	@cumpleannos date,
	@estado int,
	@salario float
	as
	begin
	SET NOCOUNT ON
	UPDATE SuperHumano
	SET
		nombre = @nombre,
		apellido1 = @apellido1,
		apellido2 = @apellido2,
		pais = @pais,
		ciudad = @ciudad,
		correoElectronico = @correoElectronico,
		nombreClave = @nombreClave,
		cumpleannos = @cumpleannos,
		estado = @estado,
		salario = @salario
		from SuperHumano
		where 
		DNI = @DNI
	end

--Borrar SuperHumano
create procedure borrarSuperHumano
	@DNI int
	as
	begin
		delete SuperHumano
		from SuperHumano
		where DNI = @DNI
	end

--Asignar Pais a Poderes
create procedure asignarPaisaPoderes
	@idPoder int,
	@idPais int
	as
	begin
		insert into IntermediaPoderesPais values(@idPoder, @idPais)
	end

--Crear Poder
create procedure crearPoder
	@idPoder int,
	@descripcion varchar(30),
	@tipoPoder int
	as
	begin
		insert into Poderes values(@idPoder, @descripcion, @tipoPoder)
	end

--Actualizar Poder
create procedure actualizarPoder
	@idPoder int,
	@descripcion varchar(30),
	@tipoPoder int
	as
	begin
	SET NOCOUNT ON
	UPDATE Poderes
	SET
		descripcion = @descripcion,
		tipoPoder = @tipoPoder
		from SuperHumano
		where 
		idPoder = @idPoder
	end

--Borrar Poder
create procedure borrarPoder
	@idPoder int
	as
	begin
		delete Poderes
		from Poderes
		where idPoder = @idPoder
	end

--Registrar metodo pago
create procedure registraMetodoPagoconSuper
	@DNI int,
	@idMetodoPago int
	as
	begin
		insert into IntermediaSuperHumanoMetodoPago values(@DNI, @idMetodoPago)
	end

--Crear itinerario
create procedure crearItinerario
	@idVacaciones int,
	@fechaSalida date,
	@fechaVuelta date,
	@lugares varchar(200)
	as
	begin
		insert into Vacaciones values (@idVacaciones, @fechaSalida, @fechaVuelta, @lugares)
	end

--Asignar vacaciones a Super Humano
create procedure asignaVacacionesSuperHumano
	@DNI int,
	@idVacaciones int
	as
	begin
		insert into IntermediaSuperHumanoVacaciones values (@DNI, @idVacaciones)
	end

--Crear equipo
create procedure crearEquipo
	@idEquipo int,
	@nombreEquipo varchar(30)
	as
	begin
		insert into EquipoTrabajo values (@idEquipo, @nombreEquipo)
	end

--Actualizar equipo
create procedure actualizarEquipo
	@idEquipo int,
	@nombreEquipo varchar(30)
	as
	begin
	SET NOCOUNT ON
	UPDATE EquipoTrabajo
	SET
		nombreEquipo = @nombreEquipo
		from EquipoTrabajo
		where 
		idEquipo = @idEquipo
	end

--Borrar equipo

create procedure borrarEquipo
	@idEquipo int
	as
	begin
		delete EquipoTrabajo
		from EquipoTrabajo
		where idEquipo = @idEquipo
	end
--Asignar super humano a equipo
create procedure asignarSuperHumanoaEquipo
	@DNI int,
	@idEquipo int
	as
	begin
		insert into IntermediaSuperHumanoEquipoTrabajo values (@DNI, @idEquipo)
	end

--Quitar super humano de equipo
create procedure quitarSuperHumanodeEquipo
	@DNI int,
	@idEquipo int
	as
	begin
	delete IntermediaSuperHumanoEquipoTrabajo
	from IntermediaSuperHumanoEquipoTrabajo
	where DNI = @DNI and idEquipo = @idEquipo
	end

