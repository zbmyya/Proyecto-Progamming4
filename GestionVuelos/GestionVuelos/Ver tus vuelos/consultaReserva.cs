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
        public consultaReserva()
        {
            InitializeComponent();

            ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();


        }

        private void consultaReserva_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal principal = new Principal();
            principal.Visible = true;
        }
    }
}
