using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    [Serializable]
    class Empresa
    {
        private string razonSocial;
        private string direccionFiscal;
        private long cuil;
        private string logo;

        public string RazonSocial {

            get { return razonSocial; }
            set { razonSocial = value; }
        
        }

        public long Cuil
        {

            get { return cuil; }
            set { cuil = value; }

        }
        public string DireccionFiscal
        {

            get { return direccionFiscal; }
            set { direccionFiscal = value; }

        }
        public string Logo {

            get { return logo; }
            set { logo = value; }
        
        }

    }
}
