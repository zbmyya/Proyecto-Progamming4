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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();

            Login login = new Login();

            TipoDocumento[] tipoDocumento = login.consultarTipoDocumento();
            valTipDocumento.DisplayMember = "Desdocumento";
            valTipDocumento.ValueMember = "idtipdoc";
            valTipDocumento.DataSource = tipoDocumento;
            
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try{

                if(valNombreu.Text == ""){
                    throw new System.Exception("El campo nombre esta vacio");
                }
                if(valApellidou.Text== ""){
                    throw new System.Exception("El campo apellido esta vacio");
                }
                if(valTipDocumento.Text == "Seleccionar"){
                    throw new System.Exception("Seleccione un tip de documento");
                }
                if(valNumDocumento.Text == ""){
                    throw new System.Exception("El campo documento esta vacio");
                }
                if(valUsuariosis.Text == ""){
                    throw new System.Exception("El campo nombre usuario esta vacio");
                }
                if(valPasswordsis.Text == ""){
                    throw new System.Exception("El campo contraseña esta vacio");
                }
                if(valConfirmarPasswordsis.Text == ""){
                    throw new System.Exception("El campo confirmar contraseña esta vacio");
                }

                Login login = new Login();
                bool flagUsuario = login.buscarUsuario(valUsuariosis.Text);

                if(flagUsuario){
              
                    throw new System.Exception("El nombre del usuario ya existe, intente con otro");
                }

                if(valPasswordsis.Text != valConfirmarPasswordsis.Text){
                    throw new System.Exception("Las contraseñas no coinciden");
                }


                Usuarios usuarios = new Usuarios();

                usuarios.Nombreu = valNombreu.Text;
                usuarios.Nombred = valNombred.Text;
                usuarios.Apellidou = valApellidou.Text;
                usuarios.Apellidod = valApellidod.Text;
                usuarios.Usuariosis = valUsuariosis.Text;
                usuarios.Passwordsis = valPasswordsis.Text;
                //usuarios.tipdocumento = Int32.Parse(valTipDocumento.Text);
                usuarios.Tipdocumento = 1;
                usuarios.Numdocumento = Convert.ToInt32(valNumDocumento.Text);
                usuarios.Celular = valCelular.Text;
                usuarios.Email = valEmail.Text;
                usuarios.Direccion = valDireccion.Text;
    
                login.crearUsuarios(usuarios);
                MessageBox.Show(null, "Se creo el usuario, inicie sesion", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 inicio = new Form1();
                Visible = false;
                inicio.Visible = true;
            }catch(Exception ex){
                MessageBox.Show(null, ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }        
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
