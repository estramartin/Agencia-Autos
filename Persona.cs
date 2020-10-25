using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    [Serializable]
    abstract class Persona
    {
        protected string nombre;
       
        protected int dni;
        protected long cuit;
        protected string direccion;
        protected int telefono;
        protected DateTime fechanac;
        protected string estadocivil;
        protected string nacionalidad;

        public abstract string DatosPersonales();







    }
}
