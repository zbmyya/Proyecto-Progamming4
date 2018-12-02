create sequence vuelos_sec;
create table Vuelos (
  idVuelo int default nextval('vuelos_sec') primary key,
  idAerolinea int,
  idItinerario int,
  idCiudadOrigen int,
  idCiudadDestino int,
  fechaSalida date,
  fechaLlegada date,
  horaSalida varchar(100),
  horaLlegada varchar(100),
  cantSillas int,
  precioVuelo int
 );
 
alter table Vuelos add constraint fk_aerolinea_vuelo foreign key (idAerolinea) references Aerolinea (idAerolinea);
alter table Vuelos add constraint fk_ciudadOr_vuelo foreign key (idCiudadOrigen) references Ciudad (idCiudad);
alter table Vuelos add constraint fk_ciudadDes_vuelo foreign key (idCiudadDestino) references Ciudad (idCiudad);