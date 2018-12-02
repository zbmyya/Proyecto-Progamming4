create sequence metodoPago_sec;
create table metodoPago (
  idmetPago int default nextval('metodoPago_sec') primary key,
  desMetPago varchar(1000)
 );