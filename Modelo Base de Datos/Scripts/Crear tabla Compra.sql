create sequence compra_sec;
create table Compra (
  idCompra int default nextval('compra_sec') primary key,
  idReserva int,
  valorCompra int,
  metodoPago int,
  numeroTarjeta varchar(100),
  nombreTitular varchar(100),
  fechaCompra date
 );
 
alter table Compra add constraint fk_reserva_compra foreign key (idReserva) references Reserva (idReserva); 
alter table Compra add constraint fk_metodoPago_compra foreign key (metodoPago) references metodoPago (idmetPago); 