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

namespace GestionVuelos
{
    public partial class AgregarReserva : Form
    {
        static Usuarios stUsuaio;
        static int stIditinerario;
        static int stIdciudadorigen;
        static int stIdciudaddestino;
              
        public AgregarReserva()
        {
            InitializeComponent();

            valNombreUsu.Text = stUsuaio.Nombreu + " " + stUsuaio.Nombred + " " + stUsuaio.Apellidou + " " + stUsuaio.Apellidod;
            
        }

        public AgregarReserva(Usuarios usu)
        {
            stUsuaio = usu;
        }

        public void datosAdicionales(int iditinerario,int idciudadorigen, int idciudaddestino,string ciudadOrigen, string ciudadDestino, int costoVuelos)
        {
            stIditinerario = iditinerario;
            stIdciudadorigen = idciudadorigen;
            stIdciudaddestino = idciudaddestino;
            valCudadOrigen.Text = ciudadOrigen;
            ValCiudadDestino.Text = ciudadDestino;
            valCostoReserva.Text = "200000";
            valCostoVuelos.Text = costoVuelos.ToString();
        }

        private void agregarReserva_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valCantidadPer.Text != "")
            {
                ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();
                int cantidadPer = Convert.ToInt32(valCantidadPer.Text);
                int costoReserva = Convert.ToInt32(valCostoReserva.Text);

                itinerarioVuelos.InsertarReserva(
                        stIditinerario, stUsuaio.IdUsuario, 1, cantidadPer, costoReserva);
            }
        }
    }
}
