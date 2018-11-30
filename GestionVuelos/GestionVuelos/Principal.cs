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
            Visible = false;
            vuelosIda.Visible = true;
        }

        private void idaYVueltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VuelosIdaVuelta vuelosIdaVuelta = new VuelosIdaVuelta();
            Visible = false;
            vuelosIdaVuelta.Visible = true;
        }
    }
}
