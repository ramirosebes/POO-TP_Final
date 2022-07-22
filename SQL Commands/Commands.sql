if object_id ('usuarios') is not null
	drop table usuarios;

create table usuarios
(
	id int identity,
	nombre varchar(20),
	apellido varchar(20),
	email varchar(40),
	contrasena varchar(20)
);

go

insert into usuarios(email,contrasena)
	values('admin','12345');

select * from usuarios;

