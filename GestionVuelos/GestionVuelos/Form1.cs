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
<<<<<<< HEAD
using System.Runtime.Caching;
using LogicaDatos;
using Entidades;
=======
>>>>>>> 8dcc1543afb85acd89d30ecccefa779be2e4d014

namespace GestionVuelos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private ObjectCache cacheName = MemoryCache.Default;
        private void label4_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Visible = true;
            Visible = false;
        }

        private void ingresarLogin_Click(object sender, EventArgs e)
        {
            try {
                if (valNombreUsuario.Text != "" || valContrasena.Text != "")
                {
                    Login login = new Login();
                    bool flagLoin = login.validarLogin(valNombreUsuario.Text,valContrasena.Text);
                    if (flagLoin)
                    {
                        CacheItemPolicy policy = new CacheItemPolicy();
                        policy.Priority = CacheItemPriority.Default;

                        Usuarios usu = new Usuarios();
                        usu = login.buscarDatosUsuario(valNombreUsuario.Text);

                        cacheName.Set("IdUsuario",usu.IdUsuario,policy);
                        cacheName.Set("cacheUsuario", usu,policy);

                        Principal principal = new Principal();

                        principal.Visible = true;
                        Visible = false;

                        Usuarios usu = new Usuarios();

                        usu = login.buscarDatosUsuario(valNombreUsuario.Text);

                        AgregarReserva agregarReserva = new AgregarReserva(usu);
                        
                        
                    }
                    else
                    {
                        throw new System.Exception("El nombre del usuario o la contraseña incorrectos");
                    }
                }
                else
                {
                    throw new System.Exception("El nombre del usuario o la contraseña estan vacios");
                }

            }
            catch (Exception ex)
            {
              MessageBox.Show(null, ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            principal.Visible = true;
            Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string password = valContrasena.Text;

            if (checkBox1.Checked)
            {
                valContrasena.UseSystemPasswordChar = false;
                valContrasena.Text = password;
            }
            else
            {
                valContrasena.UseSystemPasswordChar = true;
                valContrasena.Text = password;
            }
        }
    }
}
