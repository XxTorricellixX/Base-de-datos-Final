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