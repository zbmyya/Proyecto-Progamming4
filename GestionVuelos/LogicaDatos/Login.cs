using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Npgsql;
using Entidades;

namespace LogicaDatos
{
    public class Login
    {
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=BDVuelos;";

        public Boolean validarLogin(String nombreUsuario, String contrasena)
        {
            string valUsuario = "";
            string valContrasena = "";
            bool retorno = false;

            string query = "SELECT usuariosis, passwordsis FROM usuarios where usuariosis='" + nombreUsuario + "' and passwordsis='" + contrasena + "'";
            try
            {

                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader dt = command.ExecuteReader();
                
                for (int i=0; dt.Read(); i++)
                {
                    //dataItems.Add(dataReader[0].ToString() + "," + dataReader[1].ToString() + "," + dataReader[2].ToString() + "\r\n");
                    valUsuario = dt[0].ToString();
                    valContrasena = dt[1].ToString();
                }
                connection.Close();
                if (valUsuario == nombreUsuario || valContrasena == contrasena)
                {
                    retorno=true;
                }
                else
                {
                    retorno=false;
                }
            }
            catch (Exception)
            {
                
            }
            return retorno;
        }

        public Boolean buscarUsuario(String nombreUsuario)
        {
            string valUsuario = "";
            bool retorno = false;

            string query = "SELECT usuariosis FROM usuarios where usuariosis='" + nombreUsuario + "'";
            
            try{
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader dt = command.ExecuteReader();
                
        
                for (int i=0; dt.Read(); i++)
                {
                    //dataItems.Add(dataReader[0].ToString() + "," + dataReader[1].ToString() + "," + dataReader[2].ToString() + "\r\n");
                    valUsuario = dt[0].ToString();
                }
                connection.Close();
                if (valUsuario == nombreUsuario)
                {
                    retorno=true;
                }
                else
                {
                    retorno=false;
                }
            }
            catch (Exception)
            {
                
            }
            return retorno;
        }

        public TipoDocumento[] consultarTipoDocumento()
        {
            string query = "SELECT idtipdoc, desdocumento FROM tipodocumento ";
            TipoDocumento[] tipoDoc = null;

            try
            {

                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                
                using (NpgsqlDataAdapter npgAdapter = new NpgsqlDataAdapter(command)){

                    DataTable dt = new DataTable();
                    
                    npgAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        tipoDoc = new TipoDocumento[dt.Rows.Count];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            TipoDocumento tpDc = new TipoDocumento
                            {
                                Idtipdoc = Convert.ToInt32(dt.Rows[i]["idtipdoc"]),
                                Desdocumento = dt.Rows[i]["Desdocumento"].ToString()
                            };

                            tipoDoc[i] = tpDc;
                        }
                    }
                    
                }   
            }
            catch (Exception)
            {

            }
            return tipoDoc;
        }
        public void crearUsuarios(Usuarios usuarios)
        {
            string query = "INSERT INTO usuarios "
                          + "(nombreu,nombred,apellidou,apellidod,tipdocumento,numdocumento,usuariosis,passwordsis,celular,direccion,email) "
                          + "VALUES ('" + usuarios.Nombreu + "','" + usuarios.Nombred + "','" + usuarios.Apellidou + "','" + usuarios.Apellidod + "'," + usuarios.Tipdocumento + "," + usuarios.Numdocumento + ",'" + usuarios.Usuariosis + "','" + usuarios.Passwordsis + "','" + usuarios.Celular + "','" + usuarios.Direccion + "','" + usuarios.Email + "');";

            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                 NpgsqlCommand command = new NpgsqlCommand(query, connection);
                 command.ExecuteNonQuery();
                 connection.Close();
           
            }catch(Exception){

            }
        }

        public Usuarios buscarDatosUsuario(string nombreUsuario)
        {
            string query = "select idusuario,nombreu,nombred,apellidou,apellidod,tipdocumento,numdocumento, "
<<<<<<< HEAD
                        + "usuariosis,passwordsis,celular,direccion,email "
                        + "from usuarios where usuariosis = '" + nombreUsuario + "'";
=======
                        +"usuariosis,passwordsis,celular,direccion,email "
                        + "from usuarios where usuariosis = '"+nombreUsuario+"'";
>>>>>>> 8dcc1543afb85acd89d30ecccefa779be2e4d014
            Usuarios usu = null;
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
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
<<<<<<< HEAD
                            usu = new Usuarios
=======
                             usu = new Usuarios
>>>>>>> 8dcc1543afb85acd89d30ecccefa779be2e4d014
                            {
                                IdUsuario = Convert.ToInt32(dt.Rows[i]["idUsuario"]),
                                Nombreu = dt.Rows[i]["nombreu"].ToString(),
                                Nombred = dt.Rows[i]["nombred"].ToString(),
                                Apellidou = dt.Rows[i]["apellidou"].ToString(),
                                Apellidod = dt.Rows[i]["apellidod"].ToString(),
                                Tipdocumento = Convert.ToInt32(dt.Rows[i]["tipdocumento"]),
                                Numdocumento = Convert.ToInt32(dt.Rows[i]["numdocumento"]),
                                Usuariosis = dt.Rows[i]["usuariosis"].ToString(),
                                Passwordsis = dt.Rows[i]["passwordsis"].ToString(),
                                Celular = dt.Rows[i]["celular"].ToString(),
                                Direccion = dt.Rows[i]["direccion"].ToString(),
                                Email = dt.Rows[i]["email"].ToString(),
                            };
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
            return usu;
        }
    }
}
