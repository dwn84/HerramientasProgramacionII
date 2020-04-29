# Herramientas de programacion II
Herramientas de programación II

[En herencia en C#](https://dwn84.github.io/diapositivas/herencia.html).


[Polimorfismo en C#](https://dwn84.github.io/diapositivas/Polimorfismo.html).


# Conjuntos de datos en aplicaciones de Visual Studio

[DataGridView ](https://docs.microsoft.com/es-es/dotnet/api/system.windows.forms.datagridview?view=netframework-4.8).

# Base de datos
```sql
create table Proveedores(
	CodigoProveedor varchar(12) primary key,
	NombreComercial varchar(77) not null,
	TelefonoContacto varchar(12),
	Direccion varchar(80),
	Email varchar(120)
);

create table Categorias(
	CodigoCategoria varchar(3) primary key,
	NombreCategoria varchar(80) not null
);

create table Articulos(
	CodigoArticulo varchar(12) primary key,
	Descripcion varchar(120) not null,
	precio float not null,
	CodigoProv varchar(12) not null,
	CodigoCat varchar(3) not null,
	foreign key (CodigoProv) references Proveedores(CodigoProveedor),
	foreign key (CodigoCat) references Categorias(CodigoCategoria)
);


insert into Proveedores values ('p1','Colanta','2113344','cra 1 #22','colanta@colanta.com');
insert into Proveedores values ('p2','Alqueria','4118344','cra 2 #33','gerencia@alqueria.com');
insert into Proveedores values ('p4','Marion','4448877','cra 54 #50-34','marion@marion.com');
insert into Proveedores values ('p9','Samsung','5448877','cra 10 #10-34','samsung@samsung.com');

insert into Categorias values ('c1','Mercado');
insert into Categorias values ('c2','Electrodomésticos');
insert into Categorias values ('c3','Papeleria');

insert into Articulos values('A00001','Bolsa de leche',3500,'p1','c1');
insert into Articulos values('A00002','Bolsa de leche',2900,'p2','c1');
insert into Articulos values('A00001','Bolsa de leche',5500,'p3','c1');

```
