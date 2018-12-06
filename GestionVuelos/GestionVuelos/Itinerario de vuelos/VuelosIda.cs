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
        ItinerarioDeVuelos[] escala;
        bool flagEscala;
        int preciovuelo;
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

                if (itinerarioDeVuelos == null)
                {
                    throw new System.Exception("No hay vuelos disponibles para estos filtros");
                }
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

        private void reservarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarReserva agregarReserva = new AgregarReserva();

                int iditinerario = (int)dataGridVuelosIda.CurrentRow.Cells["Iditinerario"].Value;
                int idciudadorigen = (int)dataGridVuelosIda.CurrentRow.Cells["Idciudadorigen"].Value;
                int idciudaddestino = (int)dataGridVuelosIda.CurrentRow.Cells["Idciudaddestino"].Value;
                string ciudadorigen = (string)dataGridVuelosIda.CurrentRow.Cells["Ciudadorigen"].Value;
                string ciudaddestino = (string)dataGridVuelosIda.CurrentRow.Cells["Ciudaddestino"].Value;
                int precioida = (int)dataGridVuelosIda.CurrentRow.Cells["Preciovuelo"].Value;
                

                ItinerarioVuelos vuelosEscala = new ItinerarioVuelos();
                escala = vuelosEscala.consultarEscalas(iditinerario);

                if(flagEscala == false){
                    preciovuelo = precioida;
                    if (escala != null)
                    {
                        btnEscalas.Visible = true;
                        flagEscala = true;
                        for (int i = 0; i < escala.Length; i++)
                        {
                            preciovuelo = preciovuelo + escala[i].Preciovuelo;
                        }
                        throw new System.Exception("Este vuelo tiene escalas, clic en 'Ver escalas'");
                    }
                    else
                    {
                        flagEscala = false;
                        btnEscalas.Visible = false;
                        preciovuelo = (int)dataGridVuelosIda.CurrentRow.Cells["Preciovuelo"].Value;
                    }
                }
                else
                {
                    flagEscala = false;
                    btnEscalas.Visible = false;
                }
                

                agregarReserva.datosAdicionales(iditinerario, idciudadorigen, idciudaddestino, ciudadorigen, ciudaddestino, preciovuelo);
                agregarReserva.Visible = true;
                Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnEscalas_Click(object sender, EventArgs e)
        {
            Escalas escalas = new Escalas();
            escalas.Visible = true;


            escalas.llegarGridEscalas(escala);
        }

    }
}
