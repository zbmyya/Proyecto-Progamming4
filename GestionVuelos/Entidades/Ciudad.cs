using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudad
    {
        private int idciudad;

        public int Idciudad
        {
            get { return idciudad; }
            set { idciudad = value; }
        }
        private string nomciudad;

        public string Nomciudad
        {
            get { return nomciudad; }
            set { nomciudad = value; }
        }
    }
}
