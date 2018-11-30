using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDocumento
    {
        private int idtipdoc;

        public int Idtipdoc
        {
            get { return idtipdoc; }
            set { idtipdoc = value; }
        }

        private String desdocumento;

        public String Desdocumento
        {
            get { return desdocumento; }
            set { desdocumento = value; }
        }

    }
}
