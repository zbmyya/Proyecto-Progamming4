create sequence tipDoc_sec;
create table tipoDocumento (
  idTipDoc int default nextval('tipDoc_sec') primary key,
  desDocumento varchar(100)
 );