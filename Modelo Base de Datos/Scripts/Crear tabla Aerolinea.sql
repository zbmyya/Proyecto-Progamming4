create sequence aerolinea_sec;
create table Aerolinea (
  idAerolinea int default nextval('aerolinea_sec') primary key,
  razonSocial varchar(1000),
  numIdentifi int
 );