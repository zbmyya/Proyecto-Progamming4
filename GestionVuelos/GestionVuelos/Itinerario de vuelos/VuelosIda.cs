using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDatos;
using Entidades;

namespace GestionVuelos
{
    public partial class VuelosIda : Form
    {
        public VuelosIda()
        {
            InitializeComponent();

            ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();

            Ciudad[] ciudadOrigen = itinerarioVuelos.consultarCiudad();
            valCiudadOrigenIda.DisplayMember = "nomciudad";
            valCiudadOrigenIda.ValueMember = "idciudad";
            valCiudadOrigenIda.DataSource = ciudadOrigen;

            Ciudad[] ciudadDestino = itinerarioVuelos.consultarCiudad();
            valCiudadDestinoIda.DisplayMember = "nomciudad";
            valCiudadDestinoIda.ValueMember = "idciudad";
            valCiudadDestinoIda.DataSource = ciudadDestino;
        }

        private void btnConsultarIda_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (valCiudadOrigenIda.Text == "")
                {
                    throw new System.Exception("Seleccione una ciudad origen");
                }

                if (valCiudadDestinoIda.Text == "")
                {
                    throw new System.Exception("Seleccione una ciudad destino");
                }

                if (valFechaIda.Text == "")
                {
                    throw new System.Exception("Seleccione la fecha");
                }

                string fecha = valFechaIda.Value.ToString("yyyy-MM-dd");

                ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();

                int idCiudadOrigen = Convert.ToInt32(valCiudadOrigenIda.SelectedValue);
                int idCiudadDestino = Convert.ToInt32(valCiudadDestinoIda.SelectedValue);
                ItinerarioDeVuelos[] itinerarioDeVuelos = itinerarioVuelos.consultarItinerarioIda(idCiudadOrigen, idCiudadDestino, fecha);

                dataGridVuelosIda.DataSource = itinerarioDeVuelos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void VuelosIda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal principal = new Principal();
            principal.Visible = true;
        }

    }
}
