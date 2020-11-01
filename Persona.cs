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


        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public long Cuit { get => cuit; set => cuit = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        


        public abstract string DatosPersonales();







    }
}
