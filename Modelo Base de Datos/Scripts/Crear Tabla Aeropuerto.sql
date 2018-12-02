create sequence aeropuerto_sec;
create table Aeropuerto (
  idAeropuerto int default nextval('aeropuerto_sec') primary key,
  codigoIATA varchar(100),
  nomAeropuerto varchar(1000),
  idCiudad int
 );
 
alter table Aeropuerto add constraint fk_id_ciudad foreign key (idCiudad) references Ciudad(idCiudad)