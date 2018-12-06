using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Npgsql;
using System.Data;

namespace LogicaDatos
{
    public class ItinerarioVuelos
    {
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=BDVuelos;";

        public Ciudad[] consultarCiudad()
        {
            string query = "SELECT idciudad, nomciudad FROM ciudad ";
            Ciudad[] ciudad = null;

            try
            {

                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                using (NpgsqlDataAdapter npgAdapter = new NpgsqlDataAdapter(command))
                {

                    DataTable dt = new DataTable();

                    npgAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        ciudad = new Ciudad[dt.Rows.Count];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Ciudad ciu = new Ciudad
                            {
                                Idciudad = Convert.ToInt32(dt.Rows[i]["idciudad"]),
                                Nomciudad = dt.Rows[i]["nomciudad"].ToString()
                            };

                            ciudad[i] = ciu;
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
            return ciudad;
        }

        public ItinerarioDeVuelos[] consultarItinerarioIda(int idciudadorigen, int idciudaddestino, string fecha)
        {
            string query = "select idvuelo,iditinerario,razonsocial,ciudadorigen.idciudad idciudadorigen, ciudadorigen.nomciudad ciudadorigen,ciudaddestino.idciudad idciudaddestino,ciudaddestino.nomciudad ciudaddestino,fechasalida, "
                          +"horasalida,fechallegada,horallegada,cantsillas,preciovuelo "
                          +"from vuelos "
                          +"inner join aerolinea on aerolinea.idaerolinea = vuelos.idaerolinea "
                          +"inner join ciudad ciudadorigen on ciudadorigen.idciudad = vuelos.idciudadorigen "
                          +"inner join ciudad ciudaddestino on ciudaddestino.idciudad = vuelos.idciudaddestino "
                          +"where ciudadorigen.idciudad = "+idciudadorigen+" and  ciudaddestino.idciudad = "+idciudaddestino+" " 
                          +"and fechasalida = '"+fecha+"' ";

            ItinerarioDeVuelos[] itinerarioDeVuelos = null;

            try
            {

                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                using (NpgsqlDataAdapter npgAdapter = new NpgsqlDataAdapter(command))
                {

                    DataTable dt = new DataTable();

                    npgAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        itinerarioDeVuelos = new ItinerarioDeVuelos[dt.Rows.Count];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            ItinerarioDeVuelos itinerDeVuelos = new ItinerarioDeVuelos
                            {
                                Idvuelo = Convert.ToInt32(dt.Rows[i]["idvuelo"]),
                                Iditinerario = Convert.ToInt32(dt.Rows[i]["iditinerario"]),
                                Razonsocial = dt.Rows[i]["razonsocial"].ToString(),
                                Idciudadorigen = Convert.ToInt32(dt.Rows[i]["idciudadorigen"]),
                                Ciudadorigen = dt.Rows[i]["ciudadorigen"].ToString(),
                                Idciudaddestino = Convert.ToInt32(dt.Rows[i]["idciudaddestino"]),
                                Ciudaddestino = dt.Rows[i]["ciudaddestino"].ToString(),
                                Fechasalida = Convert.ToDateTime(dt.Rows[i]["fechasalida"]),
                                Horasalida = dt.Rows[i]["horasalida"].ToString(),
                                Fechallegada = Convert.ToDateTime(dt.Rows[i]["fechallegada"]),
                                Horallegada = dt.Rows[i]["horallegada"].ToString(),
                                Cantsillas = Convert.ToInt32(dt.Rows[i]["cantsillas"]),
                                Preciovuelo = Convert.ToInt32(dt.Rows[i]["preciovuelo"])
                            };
                            itinerarioDeVuelos[i] = itinerDeVuelos;            
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
            return itinerarioDeVuelos;

        }

        public ItinerarioDeVuelos[] consultarItinerarioVuelta(int idciudadorigen, int idciudaddestino, string fechaVuelta, int iditinerario)
        {
            string query = "select idvuelo,iditinerario,razonsocial,ciudadorigen.nomciudad ciudadorigen,ciudaddestino.nomciudad ciudaddestino,fechasalida, "
                          + "horasalida,fechallegada,horallegada,cantsillas,preciovuelo "
                          + "from vuelos as v2 "
                          + "inner join aerolinea on aerolinea.idaerolinea = v2.idaerolinea  "
                          + "inner join ciudad ciudadorigen on ciudadorigen.idciudad = v2.idciudadorigen "
                          + "inner join ciudad ciudaddestino on ciudaddestino.idciudad = v2.idciudaddestino "
                          + "where ciudadorigen.idciudad = " + idciudaddestino + " and  ciudaddestino.idciudad = " + idciudadorigen + " "
                          + "and v2.fechasalida = '" + fechaVuelta + "' and iditinerario = "+iditinerario+"; ";

            ItinerarioDeVuelos[] itinerarioDeVuelos = null;

            try
            {

                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                using (NpgsqlDataAdapter npgAdapter = new NpgsqlDataAdapter(command))
                {

                    DataTable dt = new DataTable();

                    npgAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        itinerarioDeVuelos = new ItinerarioDeVuelos[dt.Rows.Count];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            ItinerarioDeVuelos itinerDeVuelos = new ItinerarioDeVuelos
                            {
                                Idvuelo = Convert.ToInt32(dt.Rows[i]["idvuelo"]),
                                Iditinerario = Convert.ToInt32(dt.Rows[i]["iditinerario"]),
                                Razonsocial = dt.Rows[i]["razonsocial"].ToString(),
                                Ciudadorigen = dt.Rows[i]["ciudadorigen"].ToString(),
                                Ciudaddestino = dt.Rows[i]["ciudaddestino"].ToString(),
                                Fechasalida = Convert.ToDateTime(dt.Rows[i]["fechasalida"]),
                                Horasalida = dt.Rows[i]["horasalida"].ToString(),
                                Fechallegada = Convert.ToDateTime(dt.Rows[i]["fechallegada"]),
                                Horallegada = dt.Rows[i]["horallegada"].ToString(),
                                Cantsillas = Convert.ToInt32(dt.Rows[i]["cantsillas"]),
                                Preciovuelo = Convert.ToInt32(dt.Rows[i]["preciovuelo"])
                            };
                            itinerarioDeVuelos[i] = itinerDeVuelos;
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
            return itinerarioDeVuelos;

        }

        public void InsertarReserva(int iditinerario, int idusuario, int indestado, int cantpersonas, int costoreserva)
        {
            string query = "INSERT INTO reserva "
                          + "(iditinerario,idusuario,indestado,cantpersonas,costoreserva) "
                          + "VALUES (" + iditinerario + "," + idusuario + "," + indestado + "," + cantpersonas + "," + costoreserva + ");";

            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {

            }
        }
    }
}
