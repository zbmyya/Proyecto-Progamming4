using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reservas
    {

        private int idReserva;

        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        private string nombreu;

        public string Nombreu
        {
            get { return nombreu; }
            set { nombreu = value; }
        }

        private string nombred;

        public string Nombred
        {
            get { return nombred; }
            set { nombred = value; }
        }

        private string apellidou;

        public string Apellidou
        {
            get { return apellidou; }
            set { apellidou = value; }
        }

        private string apellidod;

        public string Apellidod
        {
            get { return apellidod; }
            set { apellidod = value; }
        }

        private string nomciudador;

        public string Nomciudador
        {
            get { return nomciudador; }
            set { nomciudador = value; }
        }

        private string nomciudaddes;

        public string Nomciudaddes
        {
            get { return nomciudaddes; }
            set { nomciudaddes = value; }
        }

        private string razonsocial;

        public string Razonsocial
        {
            get { return razonsocial; }
            set { razonsocial = value; }
        }

        private int cantPersonas;

        public int CantPersonas
        {
            get { return cantPersonas; }
            set { cantPersonas = value; }
        }


        private int costoReserva;

        public int CostoReserva
        {
            get { return costoReserva; }
            set { costoReserva = value; }
        }

        private int precioVuelo;

        public int PrecioVuelo
        {
            get { return precioVuelo; }
            set { precioVuelo = value; }
        }

    }
}
