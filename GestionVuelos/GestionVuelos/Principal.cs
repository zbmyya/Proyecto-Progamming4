using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Caching;

namespace GestionVuelos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        
        private ObjectCache cacheName = MemoryCache.Default;
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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea Cerrar la sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cacheName.Remove("IdUsuario", null);

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
            int idusuario = Convert.ToInt32(cacheName["IdUsuario"]);

            consultaReserva reservas = new consultaReserva(idusuario);
            this.Visible = false;
            reservas.Visible = true;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea Cerrar la sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cacheName.Remove("IdUsuario",null);
                Form1 form1 = new Form1();
                form1.Visible = true;
            }
            else
            {
                switch (e.CloseReason)
                {
                    case CloseReason.UserClosing:
                        e.Cancel = true;
                        break;
                } 
            }
        }
    }
}
