create sequence usuario_sec;
create table Usuarios (
  idUsuario int default nextval('usuario_sec') primary key,
  nombreU varchar(100),
  nombreD varchar(100),
  apellidoU varchar(100),
  apellidoD varchar(100),
  tipDocumento int,
  numDocumento int,
  usuarioSis varchar(100),
  passwordSis varchar(100),
  celular varchar(100),
  direccion varchar(100),
  email varchar(100)
 );
 alter table Usuarios add constraint fk_tipo_documento foreign key (tipDocumento) references tipoDocumento(idTipDoc)