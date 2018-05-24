--Tabla Categoria
create table Categoria(
	idCategoria int,
	nombreCategoria varchar(30),
	descripcion varchar(60)
	primary key (idCategoria)
)

--Tabla Pais
create table Pais(
	idPais int, 
	nombrePais varchar(30)
	primary key (idPais)
)

--Tabla Estado
create table Estado(
	idEstado int,
	descripcion varchar(60)
	primary key (idEstado)
)

--Tabla SuperHumano
create table SuperHumano(
	DNI int,
	nombre varchar(30),
	apellido1 varchar(30),
	apellido2 varchar(30),
	pais int,
	ciudad varchar(30),
	correoElectronico varchar(30),
	nombreClave varchar(30),
	cumpleannos date,
	estado int,
	salario float,
	primary key (DNI),
	foreign key (pais) references Pais(idPais)
		on delete cascade
		on update cascade,
	foreign key (estado) references Estado(idEstado)
		on delete cascade
		on update cascade
	)

--Tabla MetodoPago
create table MetodoPago(
	idMetodoPago int,
	nombreMetodoPago varchar(30)
	primary key (idMetodoPago)
)

--Tabla EquipoTrabajo
create table EquipoTrabajo(
	idEquipo int,
	nombreEquipo varchar(30),
	primary key (idEquipo)
)

--Tabla Vacaciones
create table Vacaciones(
	idVacaciones int,
	fechaSalida date,
	fechaVuelta date
	primary key (idVacaciones)
)

--Tabla TiposDePoder
create table TiposDePoder(
	idTipo int,
	descripcionTipo varchar(30)
	primary key (idTipo)
)

--Tabla Poderes
create table Poderes(
	idPoder int,
	descripcion varchar(30),
	tipoPoder int
	primary key(idPoder),
	foreign key (tipoPoder) references TiposDePoder(idTipo)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre super humano y categoria
create table IntermediaSuperHumanoCategoria(
	DNI int, 
	idCategoria int,
	primary key (DNI, idCategoria),
	foreign key (DNI) references SuperHumano(DNI)
		on delete cascade
		on update cascade,
	foreign key (idCategoria) references Categoria(idCategoria)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre SuperHumano y EquipoTrabajo
create table IntermediaSuperHumanoEquipoTrabajo(
	DNI int,
	idEquipo int,
	cantidadSuperHumanos int,
	primary key (DNI, idEquipo),
	foreign key (DNI) references SuperHumano(DNI)
		on delete cascade
		on update cascade,
	foreign key (idEquipo) references EquipoTrabajo(idEquipo)
		on delete cascade
		on update cascade
)

--Tabla intermedia pais y vacaciones
create table IntermediaPaisVacaciones(
	idPais int,
	idVacaciones int,
	primary key(idPais, idVacaciones),
	foreign key (idPais) references Pais(idPais)
		on delete cascade
		on update cascade,
	foreign key(idVacaciones) references Vacaciones(idVacaciones)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre SuperHumano y MetodoPago
create table IntermediaSuperHumanoMetodoPago(
	DNI int,
	idMetodoPago int,
	primary key(DNI, idMetodoPago),
	foreign key(DNI) references SuperHumano(DNI)
		on delete cascade
		on update cascade,
	foreign key(idMetodoPago) references MetodoPago(idMetodoPago)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre SuperHumano y Poderes
create table IntermediaSuperHumanoPoderes(
	DNI int,
	idPoder int,
	estadoPoder varchar(30),
	primary key(DNI, idPoder),
	foreign key(DNI) references SuperHumano(DNI)
		on delete cascade
		on update cascade,
	foreign key(idPoder) references Poderes(idPoder)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre SuperHumano y Vacaciones
create table IntermediaSuperHumanoVacaciones(
	DNI int,
	idVacaciones int,
	primary key(DNI, idVacaciones),
	foreign key(DNI) references SuperHumano(DNI)
		on delete cascade
		on update cascade,
	foreign key (idVacaciones) references Vacaciones(idVacaciones)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre Poderes y Pais
create table IntermediaPoderesPais(
	idPais int,
	idPoder int,
	primary key(idPais, idPoder),
	foreign key(idPais) references Pais(idPais)
		on delete cascade
		on update cascade,
	foreign key(idPoder) references Poderes(idPoder)
		on delete cascade
		on update cascade
)