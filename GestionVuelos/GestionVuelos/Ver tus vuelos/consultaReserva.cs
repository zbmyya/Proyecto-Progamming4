using Entidades;
using LogicaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVuelos
{
    public partial class consultaReserva : Form
    {
        public consultaReserva(int idusuario)
        {
            InitializeComponent();

            ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();
            Reservas[] reserva = itinerarioVuelos.consultarReservas(idusuario);
            dataGridReservas.DataSource = reserva;

        }

        private void consultaReserva_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal principal = new Principal();
            principal.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
