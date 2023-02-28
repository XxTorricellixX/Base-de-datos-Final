create table tblEmpresa
(
  empId number(10,0) not null,
  empNombre  varchar2(14) not null,
  constraint pk_Empresa primary key (empId),
  constraint ckc_empId check (empId>0)
);

create table tblComputadora
(
  compSerial number(12,0) not null,
  compMarca  varchar2(7) not null,
  compCapacidad number(6,0) not null,
  compTipoDisco  varchar2(12) not null,
  constraint pk_Computadora primary key (compSerial),
  constraint ckc_compSerial check (compSerial>0),
  constraint ckc_compMarca check (compMarca in ('Lenovo','Dell','Asus'))
);



create table tblRepara  (
   empId number(10,0) not null,
   compSerial number(12,0) not null,
   fechaIngreso date not null,
   fechaEgreso date ,
   constraint pk_Repara primary key (empId, compSerial,fechaIngreso),
   constraint fk_empRep foreign key (empId) references tblEmpresa (empId),
   constraint fk_compRep foreign key (compSerial) references tblComputadora (compSerial)
);

insert into tblEmpresa(empId,empNombre) values(1022,'CompuMundo');

insert into tblEmpresa(empId,empNombre) values(1026,'ReparaMax');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(123,'Lenovo',100,'SSD');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(456,'Lenovo',500,'SAS');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(789,'Dell',100,'HDD');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(212,'Asus',1000,'HDD');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(234,'Lenovo',100,'SDD');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(256,'Dell',600,'SAS');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(278,'Asus',700,'SSD');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(290,'Lenovo',900,'HDD');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(300,'Asus',100,'SAS');

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(312,'Dell',1000,'HDD');



insert into tblRepara(empId,compSerial,fechaIngreso,fechaEgreso) values(1022,1234,to_date('28/01/2023','dd-mm-yy'),null)

insert into tblRepara(empId,compSerial,fechaIngreso,fechaEgreso) values(1022,1234,to_date('28/01/2023 12:00:00','dd-mm-yy HH24:MI:SS'),null)

insert into tblComputadora(compSerial,compMarca,compCapacidad,compTipoDisco) values(1234,'Dell',100,'SDD')

--1. Primera consulta
select empNombre Nombre_Empresa,tblComputadora.compSerial Número_Serial,compMarca Marca_del_PC,compCapacidad Capacidad_del_disco,fechaEgreso Fecha_de_egreso from tblComputadora 
inner join (select tblEmpresa.empId,empNombre,fechaIngreso,fechaEgreso,tblRepara.compSerial from tblEmpresa inner join tblRepara on tblEmpresa.empId=tblRepara.empId ) T 
on tblComputadora.compSerial=T.compSerial
where fechaIngreso = to_date('28/01/2023 12:00:00','dd-mm-yy HH24:MI:SS') and T.empId=1022

--2. Segunda Consulta

select count(compSerial) from tblComputadora where compMarca like 'Dell' 


