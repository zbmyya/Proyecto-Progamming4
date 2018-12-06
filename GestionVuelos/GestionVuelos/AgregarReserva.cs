using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaDatos;
using System.Runtime.Caching;

namespace GestionVuelos
{
    public partial class AgregarReserva : Form
    {
        public AgregarReserva()
        {
            InitializeComponent();
        }

        private ObjectCache cacheName = MemoryCache.Default;

        Usuarios usuario;
        static int stIditinerario;
        static int stIdciudadorigen;
        static int stIdciudaddestino;
        private void button1_Click(object sender, EventArgs e)
        {
            if (valCantidadPer.Text != "")
            {
                ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();
                int cantidadPer = Convert.ToInt32(valCantidadPer.Text);
                int costoReserva = Convert.ToInt32(valCostoReserva.Text);

                itinerarioVuelos.InsertarReserva(
                        stIditinerario, usuario.IdUsuario, 1, cantidadPer, costoReserva);
            }
        }

        public void datosAdicionales(int iditinerario, int idciudadorigen, int idciudaddestino, string ciudadOrigen, string ciudadDestino, int costoVuelos)
        {
            usuario = new Usuarios();

            usuario = (Usuarios)cacheName["cacheUsuario"];

            stIditinerario = iditinerario;
            stIdciudadorigen = idciudadorigen;
            stIdciudaddestino = idciudaddestino;

            valNombreUsu.Text = usuario.Nombreu + " " + usuario.Nombred + " " + usuario.Apellidou + " " + usuario.Apellidod;
            valCudadOrigen.Text = ciudadOrigen;
            ValCiudadDestino.Text = ciudadDestino;
            valCostoReserva.Text = "200000";
            valCostoVuelos.Text = costoVuelos.ToString();
        }
    }
}
