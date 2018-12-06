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
    public partial class VuelosIdaVuelta : Form
    {
        public VuelosIdaVuelta()
        {
            InitializeComponent();

            ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();

            Ciudad[] ciudadOrigen = itinerarioVuelos.consultarCiudad();
            valCiudadOrigenIdaVuelta.DisplayMember = "nomciudad";
            valCiudadOrigenIdaVuelta.ValueMember = "idciudad";
            valCiudadOrigenIdaVuelta.DataSource = ciudadOrigen;

            Ciudad[] ciudadDestino = itinerarioVuelos.consultarCiudad();
            valCiudadDestinoIdaVuelta.DisplayMember = "nomciudad";
            valCiudadDestinoIdaVuelta.ValueMember = "idciudad";
            valCiudadDestinoIdaVuelta.DataSource = ciudadDestino;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultarIdaVuelta_Click(object sender, EventArgs e)
        {
            try
            {

                if (valCiudadOrigenIdaVuelta.Text == "")
                {
                    throw new System.Exception("Seleccione una ciudad origen");
                }

                if (valCiudadDestinoIdaVuelta.Text == "")
                {
                    throw new System.Exception("Seleccione una ciudad destino");
                }

                if (valFechaIdaVuelta1.Text == "")
                {
                    throw new System.Exception("Seleccione la fecha");
                }

                if (valFechaIdaVuelta2.Text == "")
                {
                    throw new System.Exception("Seleccione la fecha");
                }

                string fechaIda = valFechaIdaVuelta1.Value.ToString("yyyy-MM-dd");

                ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();

                int idCiudadOrigen = Convert.ToInt32(valCiudadOrigenIdaVuelta.SelectedValue);
                int idCiudadDestino = Convert.ToInt32(valCiudadDestinoIdaVuelta.SelectedValue);
                ItinerarioDeVuelos[] itinerarioDeVuelos = itinerarioVuelos.consultarItinerarioIda(idCiudadOrigen, idCiudadDestino, fechaIda);

                dataGridVuelosIda.DataSource = itinerarioDeVuelos;
                panelVuelosIda.Enabled = true;
                panelVuelosIda.Visible = true;
                panelVuelosVuelta.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void VuelosIdaVuelta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal principal = new Principal();
            principal.Visible = true;
        }

        private void seleccionarVuelo_Click(object sender, EventArgs e)
        {
            int iditinerario = (int)dataGridVuelosIda.CurrentRow.Cells["Iditinerario"].Value;
            string fechaVuelta = valFechaIdaVuelta2.Value.ToString("yyyy-MM-dd");

            int idCiudadOrigen = Convert.ToInt32(valCiudadOrigenIdaVuelta.SelectedValue);
            int idCiudadDestino = Convert.ToInt32(valCiudadDestinoIdaVuelta.SelectedValue);

            ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();
            ItinerarioDeVuelos[] itinerarioDeVuelos = itinerarioVuelos.consultarItinerarioVuelta(idCiudadOrigen, idCiudadDestino, fechaVuelta,iditinerario);

            dataGridVuelosVuelta.DataSource = itinerarioDeVuelos;

            panelVuelosIda.Enabled = false;
            panelVuelosVuelta.Visible = true;
        }

    }
}
