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


# Ejemplo de análisis
[Catálogo](https://abiesweb.educastur.es/index.php/catalogo/index?codigo=Catalogo_Fondo).

# Base de datos propuesta para el catálogo
```sql
create database biblioteca;
use biblioteca;

CREATE TABLE editorial (
    id int primary key identity,
    nombre vachar(30)
);

CREATE TABLE tipos (
    id int primary key identity,
    nombre_tipo vachar(10)
);

CREATE TABLE libros (
    id int primary key,
    nombre vachar(30),
    ideditorial int,
    numpaginas int,
    FOREIGN KEY (ideditorial) REFERENCES editorial(id)
);

CREATE TABLE ejemplares (
    id int primary key identity,
    codigo vachar(10) unique,
    ubicacion vachar(5),
    idtipo int,
    idlibro int,
    diasprestamo int DEFAULT 8,
    estado varchar(13) DEFAULT 'No Disponible',
    FOREIGN KEY (idlibro) REFERENCES libros(id),
    FOREIGN KEY (idtipo) REFERENCES tipos(id)
);


CREATE TABLE usuarios (
    id int primary key,
    nombre vachar(50),
    direccion vachar(50),
    telefono vachar(15),
    edad int
);


CREATE TABLE prestamos (
    id int primary key identity,
    idusuario int,
    idejemplar int,
    fechaprestamo date,
    fechaLimiteEntrega date,
    fechaDevolucion date,
    FOREIGN KEY (idejemplar) REFERENCES ejemplares(id),
    FOREIGN KEY (idusuario) REFERENCES usuarios(id)

);


```

