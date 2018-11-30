create sequence ciudad_sec;
create table Ciudad (
  idCiudad int default nextval('ciudad_sec') primary key,
  NomCiudad varchar(1000)
 );