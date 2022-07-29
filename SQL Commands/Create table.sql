if object_id('usuarios') is not null
	drop table usuarios;

create table usuarios
(
	id int identity,
	nombre varchar(20),
	apellido varchar(20),
	email varchar(40) not null,
	contrasena varchar(20) not null,
	primary key (id)
);

insert into usuarios(email,contrasena) values ('admin','admin');
insert into usuarios(email,contrasena) values ('123','123');

select * from usuarios;