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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void idaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VuelosIda vuelosIda = new VuelosIda();
            this.Visible = false;
            vuelosIda.Visible = true;
        }

        private void idaYVueltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VuelosIdaVuelta vuelosIdaVuelta = new VuelosIdaVuelta();
            this.Visible = false;
            vuelosIdaVuelta.Visible = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Cerrar la sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea Cerrar la sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Visible = true;
                this.Visible = false;
            }
            else
            {
                return;
            }

        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaReserva reservas = new consultaReserva();
            this.Visible = false;
            reservas.Visible = true;
        }
    }
}
