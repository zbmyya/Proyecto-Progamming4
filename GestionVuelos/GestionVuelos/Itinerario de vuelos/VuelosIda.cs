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
    public partial class VuelosIda : Form
    {
        public VuelosIda()
        {
            InitializeComponent();
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

                var fecha = valFechaIda.Value.ToString("dd/MM/yyyy");

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
