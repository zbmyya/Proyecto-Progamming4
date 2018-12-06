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

        ItinerarioDeVuelos[] escala;
        int preciovuelo;
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

                if (itinerarioDeVuelos == null)
                {
                    throw new System.Exception("No hay vuelos disponibles para estos filtros");
                }
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
            try
            {
                int iditinerario = (int)dataGridVuelosIda.CurrentRow.Cells["Iditinerario"].Value;
                string fechaVuelta = valFechaIdaVuelta2.Value.ToString("yyyy-MM-dd");

                int idCiudadOrigen = Convert.ToInt32(valCiudadOrigenIdaVuelta.SelectedValue);
                int idCiudadDestino = Convert.ToInt32(valCiudadDestinoIdaVuelta.SelectedValue);

                ItinerarioVuelos vuelosEscala = new ItinerarioVuelos();
                escala = vuelosEscala.consultarEscalas(iditinerario);

                if (escala != null)
                {
                    btnEscalas.Visible = true;
                }
                else
                {
                    btnEscalas.Visible = false;
                }

                ItinerarioVuelos itinerarioVuelos = new ItinerarioVuelos();
                ItinerarioDeVuelos[] itinerarioDeVuelos = itinerarioVuelos.consultarItinerarioVuelta(idCiudadOrigen, idCiudadDestino, fechaVuelta, iditinerario);

                if (itinerarioDeVuelos == null)
                {
                    throw new System.Exception("No hay vuelo de ida para el vuelo que seleccionaste");
                }
                dataGridVuelosVuelta.DataSource = itinerarioDeVuelos;

                panelVuelosIda.Enabled = false;
                panelVuelosVuelta.Visible = true;
            }catch(Exception ex){
                MessageBox.Show(null, ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void reservarVuelo_Click_1(object sender, EventArgs e)
        {
            AgregarReserva agregarReserva = new AgregarReserva();

            int iditinerario = (int)dataGridVuelosIda.CurrentRow.Cells["Iditinerario"].Value;
            int idciudadorigen = (int)dataGridVuelosIda.CurrentRow.Cells["Idciudadorigen"].Value;
            int idciudaddestino = (int)dataGridVuelosIda.CurrentRow.Cells["Idciudaddestino"].Value;
            string ciudadorigen = (string)dataGridVuelosIda.CurrentRow.Cells["Ciudadorigen"].Value;
            string ciudaddestino = (string)dataGridVuelosIda.CurrentRow.Cells["Ciudaddestino"].Value;

            int precioida = (int)dataGridVuelosIda.CurrentRow.Cells["Preciovuelo"].Value;
            int preciovuelta = (int)dataGridVuelosVuelta.CurrentRow.Cells["Preciovuelo"].Value;

            preciovuelo = precioida + preciovuelta;

            ItinerarioVuelos vuelosEscala = new ItinerarioVuelos();
            escala = vuelosEscala.consultarEscalas(iditinerario);

            if (escala != null)
            {
                btnEscalas.Visible = true;
                for (int i = 0; i < escala.Length; i++)
                {
                    preciovuelo = preciovuelo + escala[i].Preciovuelo;
                }
            }
            else
            {
                btnEscalas.Visible = false;
                preciovuelo = (int)dataGridVuelosIda.CurrentRow.Cells["Preciovuelo"].Value;
            }

            agregarReserva.datosAdicionales(iditinerario, idciudadorigen, idciudaddestino, ciudadorigen, ciudaddestino, preciovuelo);
            agregarReserva.Visible = true;
            Enabled = true;
        }

        private void btnEscalas_Click(object sender, EventArgs e)
        {
            Escalas escalas = new Escalas();
            escalas.Visible = true;
            

            escalas.llegarGridEscalas(escala);
        }

    }
}
