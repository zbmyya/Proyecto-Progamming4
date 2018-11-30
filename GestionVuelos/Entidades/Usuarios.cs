using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        private String nombreu;

        public String Nombreu
        {
            get { return nombreu; }
            set { nombreu = value; }
        }

        private String nombred;

        public String Nombred
        {
            get { return nombred; }
            set { nombred = value; }
        }
        private String apellidou;

        public String Apellidou
        {
            get { return apellidou; }
            set { apellidou = value; }
        }

        private String apellidod;

        public String Apellidod
        {
            get { return apellidod; }
            set { apellidod = value; }
        }
        private String usuariosis;

        public String Usuariosis
        {
            get { return usuariosis; }
            set { usuariosis = value; }
        }

        private String passwordsis;

        public String Passwordsis
        {
            get { return passwordsis; }
            set { passwordsis = value; }
        }
        private int tipdocumento;

        public int Tipdocumento
        {
            get { return tipdocumento; }
            set { tipdocumento = value; }
        }
        private int numdocumento;

        public int Numdocumento
        {
            get { return numdocumento; }
            set { numdocumento = value; }
        }

        private String celular;

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
