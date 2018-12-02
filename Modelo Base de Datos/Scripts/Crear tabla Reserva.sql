create sequence reserva_sec;
create table Reserva (
  idReserva int default nextval('reserva_sec') primary key,
  idItinerario int,
  idUsuario int,
  indEstado int,
  cantPersonas int,
  costoReserva int
 );
 
alter table Reserva add constraint fk_usuario_reserva foreign key (idUsuario) references Usuarios (idUsuario);
