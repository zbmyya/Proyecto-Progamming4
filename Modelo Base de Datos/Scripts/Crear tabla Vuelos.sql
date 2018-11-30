create sequence vuelos_sec;
create table Vuelos (
  idVuelo int default nextval('vuelos_sec') primary key,
  idAerolinea int,
  idCiudadDestino int,
  idCiudadOrigen int,
  fechaSalida date,
  fechaLlegada date,
  horaSalida varchar(100),
  horaLlegada varchar(100)
 );