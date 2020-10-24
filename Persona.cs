using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    abstract class Persona
    {
        string nombre;
        string apellido;
        int dni;
        long cuit;
        string direccion;
        int telefono;
        DateTime fechanac;
        string estadocivil;
        string nacionalidad;

        public abstract string DatosPersonales();







    }
}
