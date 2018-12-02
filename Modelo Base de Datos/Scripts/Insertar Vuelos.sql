---------------	vuelo nacional ida

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (3,1,1,2,'4/01/2019','4/01/2019','3:00 pm','3:45 pm',100,400000);

---------------	vuelo nacional ida y vuelta
	
INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,2,1,2,'5/01/2019','5/01/2019','4:00 pm','4:45 pm',100,200000);

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,2,2,1,'7/01/2019','7/01/2019','8:00 am','8:45 am',100,200000);

---------------	vuelo internacional ida

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (2,3,3,9,'5/01/2019','5/01/2019','4:00 pm','7:30 pm',100,1000000);

---------------	vuelo internacional ida y vuelta

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (2,4,3,9,'7/01/2019','7/01/2019','2:00 am','5:30 am',100,500000);

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (2,4,9,3,'10/01/2019','10/01/2019','6:00 pm','9:30 pm',100,500000);

---------------	vuelo nacional ida. escala

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (3,5,1,2,'10/01/2019','10/01/2019','6:00 pm','6:30 pm',100,200000);	

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (3,5,2,4,'10/01/2019','10/01/2019','9:00 pm','9:30 pm',100,200000);

---------------	vuelo nacional ida y vuelta. escala

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,6,1,2,'10/01/2019','10/01/2019','6:00 pm','6:30 pm',100,90000);	

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,6,2,4,'10/01/2019','10/01/2019','9:00 pm','9:30 pm',100,90000);

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,6,4,2,'14/01/2019','14/01/2019','6:00 am','6:30 am',100,90000);

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,6,2,1,'14/01/2019','14/01/2019','3:00 pm','3:30 pm',100,90000);

---------------	vuelo internacional ida. escala

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (2,7,2,9,'14/01/2019','14/01/2019','3:00 pm','6:00 pm',100,250000);

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (4,7,9,11,'15/01/2019','15/01/2019','12:15 am','3:15 am',100,250000);

---------------	vuelo internacional ida y vuelta. escala
	
INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,8,2,9,'18/01/2019','18/01/2019','12:00 am','3:00 am',100,500000);

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (4,8,9,11,'18/01/2019','18/01/2019','7:00 am','10:00 am',100,500000);

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (4,8,11,9,'30/01/2019','30/01/2019','4:00 am','7:00 am',100,500000);	

INSERT INTO Vuelos(
	idAerolinea,
	idItinerario,
	idCiudadOrigen,
	idCiudadDestino,
	fechaSalida,
	fechaLlegada,
	horaSalida,
	horaLlegada,
	cantSillas,
	precioVuelo)
	VALUES (1,8,9,2,'30/01/2019','30/01/2019','3:00 pm','6:00 pm',100,500000);
	